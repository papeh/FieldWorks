// Copyright (c) 2012-2013 SIL International
// This software is licensed under the LGPL, version 2.1 or later
// (http://www.gnu.org/licenses/lgpl-2.1.html)

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace SIL.Utils
{
	/// ----------------------------------------------------------------------------------------
	/// <summary>
	/// Allows to create COM objects from a manifest file when running unit tests.
	/// </summary>
	/// <remarks>Registration-free activation of native COM components reads the information
	/// about what COM objects implement which interface etc from a manifest file. This manifest
	/// file is usually embedded as a resource in the executable (as we do with the unmanaged
	/// tests). However, when running unit tests with NUnit this doesn't work since we can't
	/// modify the NUnit executable for each test assembly. Therefore we have to make use
	/// of activation contexts which tells the OS which manifest file to use. Note that
	/// activation contexts are thread specific.</remarks>
	/// <seealso href="http://stackoverflow.com/a/12621792"/>
	/// <seealso href="http://msdn.microsoft.com/en-us/library/ms973913.aspx#rfacomwalk_topic9"/>
	/// ----------------------------------------------------------------------------------------
	public static class ManifestHelper
	{
#if !__MonoCS__
		[SuppressUnmanagedCodeSecurity]
		private sealed class ManifestHelperImpl: IDisposable
		{
			#region Unmanaged structs and methods
			[StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
			private struct ActCtx
			{
				public int cbSize;
				public uint dwFlags;
				public string lpSource;
				public ushort wProcessorArchitecture;
				public short wLangId;
				public string lpAssemblyDirectory;
				public string lpResourceName;
				public string lpApplicationName;
				public IntPtr hModule;
			}

			[DllImport("Kernel32.dll", SetLastError = true, EntryPoint = "CreateActCtxW")]
			private static extern IntPtr CreateActCtx(ref ActCtx actCtx);

			[DllImport("Kernel32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool ActivateActCtx(IntPtr hActCtx, out IntPtr lpCookie);

			[DllImport("Kernel32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			private static extern bool DeactivateActCtx(int dwFlags, IntPtr lpCookie);

			[DllImport("Kernel32.dll", SetLastError = true)]
			private static extern void ReleaseActCtx(IntPtr hActCtx);
			#endregion // Unmanaged structs and methods

			[ThreadStatic]
			private static IntPtr m_ActivationContext;
			[ThreadStatic]
			private static IntPtr m_Cookie;
			[ThreadStatic]
			private static int m_Count;

			#region Disposable stuff
#if DEBUG
			/// <summary/>
			~ManifestHelperImpl()
			{
				Dispose(false);
			}
#endif

			/// <summary/>
			public bool IsDisposed { get; private set; }

			/// <summary/>
			public void Dispose()
			{
				Dispose(true);
				GC.SuppressFinalize(this);
			}

			/// <summary/>
			private void Dispose(bool fDisposing)
			{
				Debug.WriteLineIf(!fDisposing, "****** Missing Dispose() call for " + GetType() + ". *******");
				if (fDisposing && !IsDisposed)
				{
					// dispose managed and unmanaged objects
					m_Count = 0;
					DestroyActivationContext();
				}
				IsDisposed = true;
			}
			#endregion

			/// <summary>
			/// Gets (and creates) the activation context
			/// </summary>
			private IntPtr ActivationContext
			{
				get
				{
					if (m_ActivationContext == IntPtr.Zero)
					{
						// Specifying a full path to the Tests.manifest file like this allows our unit tests to work even with a
						// test runner like Resharper 8 which does not set the current directory to the one containing the DLLs.
						// Note that we have to use CodeBase here because NUnit runs the tests from a shadow copy directory
						// that doesn't contain the manifest file.
						var uri = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
						var location = Path.GetDirectoryName(uri.AbsolutePath);
						var context = new ActCtx
							{
								cbSize = Marshal.SizeOf(typeof(ActCtx)),
								lpSource = Path.Combine(location, "FieldWorks.Tests.manifest")
							};

						var handle = CreateActCtx(ref context);
						if (handle == (IntPtr)(-1))
							throw new Win32Exception(Marshal.GetLastWin32Error(), "Error creating activation context");
						m_ActivationContext = handle;
					}
					return m_ActivationContext;
				}
			}

			/// <summary>
			/// Creates and activates an activation context on the current thread
			/// </summary>
			public void CreateContext()
			{
				if (m_Cookie == IntPtr.Zero)
				{
					if (!ActivateActCtx(ActivationContext, out m_Cookie))
						throw new Win32Exception(Marshal.GetLastWin32Error(), "Error activating context");
				}
				m_Count++;
			}

			/// <summary>
			/// Releases the current activation context
			/// </summary>
			public void DestroyContext()
			{
				m_Count--;
				if (m_Count <= 0)
				{
					if (m_Cookie != IntPtr.Zero)
						DeactivateActCtx(0, m_Cookie);
					m_Cookie = IntPtr.Zero;

					if (m_ActivationContext != IntPtr.Zero)
						ReleaseActCtx(m_ActivationContext);
					m_ActivationContext = IntPtr.Zero;
				}
			}
		}
#endif

		/// <summary>
		/// Creates and activates an activation context on the current thread
		/// </summary>
		public static void CreateActivationContext()
		{
#if !__MonoCS__
			SingletonsContainer.Get<ManifestHelperImpl>().CreateContext();
#endif
		}

		/// <summary>
		/// Releases the current activation context
		/// </summary>
		public static void DestroyActivationContext()
		{
#if !__MonoCS__
			SingletonsContainer.Get<ManifestHelperImpl>().DestroyContext();
#endif
		}
	}
}