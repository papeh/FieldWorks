// Copyright (c) 2015-2019 SIL International
// This software is licensed under the LGPL, version 2.1 or later
// (http://www.gnu.org/licenses/lgpl-2.1.html)

using System;
using System.IO;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace SIL.FieldWorks.Build.Tasks
{
	public class CatenateFiles : Task
	{
		[Required]
		public ITaskItem[] SourceFiles { get; set; }

		[Required]
		public string TargetFile { get; set; }

		public bool UseUnixNewlines { get; set; }

		public override bool Execute()
		{
			using (var writer = new StreamWriter(TargetFile))
			{
				foreach (var item in SourceFiles)
				{
					using (var reader = new StreamReader(item.ItemSpec))
					{
						while (!reader.EndOfStream)
						{
							var line = reader.ReadLine();
							if (!UseUnixNewlines || Environment.OSVersion.Platform == PlatformID.Unix)
								writer.WriteLine(line);
							else
								writer.Write(line + "\n");
						}
						reader.Close();
					}
					writer.Flush();
				}
				writer.Close();
			}
			return true;
		}
	}
}
