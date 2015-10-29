// Copyright (c) 2015 SIL International
// This software is licensed under the LGPL, version 2.1 or later
// (http://www.gnu.org/licenses/lgpl-2.1.html)

using System.Collections.Generic;
using SIL.CoreImpl;

namespace LanguageExplorer
{
	/// <summary>
	/// Interface for the tool repository.
	/// </summary>
	internal interface IToolRepository : IFlexComponent
	{
		/// <summary>
		/// Get the most recently persisted tool, or the default tool if
		/// the persisted one is no longer available.
		/// </summary>
		/// <returns>The last persisted tool or the default tool for the given area.</returns>
		ITool GetPersistedOrDefaultToolForArea(IArea area);

		/// <summary>
		/// Get the ITool that has the machine friendly "Name" for <paramref name="machineName"/>.
		/// </summary>
		/// <returns>The ITool for the given Name, or null if not in the system.</returns>
		ITool GetTool(string machineName);

		/// <summary>
		/// Return all tools in the standard order (if installed) for the given area.
		/// </summary>
		/// <returns></returns>
		IList<ITool> AllToolsForAreaInOrder(IList<string> expectedToolsInOrder, string areaMachineName);
	}
}