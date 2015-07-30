// Copyright (c) 2002-2013 SIL International
// This software is licensed under the LGPL, version 2.1 or later
// (http://www.gnu.org/licenses/lgpl-2.1.html)
//
// File: IFwMainWnd.cs
// Responsibility: FW Team
// Last reviewed:
// --------------------------------------------------------------------------------------------
using System.Drawing;
using SIL.CoreImpl;
using SIL.FieldWorks.Common.RootSites;
using SIL.FieldWorks.FDO;
using SIL.Utils;

namespace SIL.FieldWorks.Common.Framework
{
	/// ------------------------------------------------------------------------------------
	/// <summary>
	/// Interface for FW main windows to avoid all kinds of exciting circular dependencies
	/// and to allow different apps to implement their main windows totally differently.
	/// </summary>
	/// ------------------------------------------------------------------------------------
	public interface IFwMainWnd : IFWDisposable, IPropertyTableProvider, IPublisherProvider, ISubscriberProvider
	{
		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Gets the active view of the window
		/// </summary>
		/// ------------------------------------------------------------------------------------
		IRootSite ActiveView { get; }

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Gets the data object cache.
		/// </summary>
		/// ------------------------------------------------------------------------------------
		FdoCache Cache { get; }

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Create the client windows and add corresponding stuff to the sidebar, View menu,  etc.
		/// </summary>
		/// ------------------------------------------------------------------------------------
		void InitAndShowClient();

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Gets a Rectangle representing the position and size of the window in its
		/// normal (non-minimized, non-maximized) state.
		/// </summary>
		/// ------------------------------------------------------------------------------------
		Rectangle NormalStateDesktopBounds
		{
			get;
		}

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Called just before a window syncronizes it's views with DB changes (e.g. when an
		/// undo or redo command is issued).
		/// </summary>
		/// <param name="sync">syncronization message</param>
		/// ------------------------------------------------------------------------------------
		void PreSynchronize(SyncMsg sync);

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Called when a window syncronizes it's views with DB changes (e.g. when an undo or
		/// redo command is issued).
		/// </summary>
		/// <param name="sync">syncronization message</param>
		/// <returns>true if successful; false results in RefreshAllWindows.</returns>
		/// ------------------------------------------------------------------------------------
		bool Synchronize(SyncMsg sync);

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Called when a window is finished being created and completely initialized.
		/// </summary>
		/// <returns>True if successful; false otherwise.  False should keep the main window
		/// from being shown/initialized (maybe even close the window if false is returned)
		/// </returns>
		/// ------------------------------------------------------------------------------------
		bool OnFinishedInit();

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Handle the Find menu command.
		/// </summary>
		/// <param name="args">Arguments</param>
		/// <returns><c>true</c> if message handled, otherwise <c>false</c>.</returns>
		/// ------------------------------------------------------------------------------------
		bool OnEditFind(object args);

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Prepare to refresh the main window and its IAreas and ITools.
		/// </summary>
		/// ------------------------------------------------------------------------------------
		void PrepareToRefresh();

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Finish refreshing the main window and its IAreas and ITools.
		/// </summary>
		/// <remarks>
		/// This should call Refresh on real window implementations,
		/// after everything else is done.</remarks>
		/// ------------------------------------------------------------------------------------
		void FinishRefresh();

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Refreshes all the views that belong to this main window
		/// </summary>
		/// ------------------------------------------------------------------------------------
		void RefreshAllViews();

		/// ------------------------------------------------------------------------------------
		/// <summary>
		/// Closes this instance.
		/// </summary>
		/// ------------------------------------------------------------------------------------
		void Close();
	}
}