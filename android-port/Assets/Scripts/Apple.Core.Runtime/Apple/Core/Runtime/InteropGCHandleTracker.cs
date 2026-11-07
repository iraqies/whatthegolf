using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace Apple.Core.Runtime
{
	[Preserve]
	public static class InteropGCHandleTracker
	{
		private static readonly Dictionary<string, GCHandle> _arrays;

		private static readonly object _arraysLock;

		public static void UntrackAndFree(string guid)
		{
		}
	}
}
