using System;
using System.Collections.Generic;
using UnityEngine;

internal static class tASbVocwrkZfBjDhttUGkjNilJQyA
{
	public delegate void EventFunction<T, TArgs>(T handler, TArgs value) where T : class;

	public class HierarchyEventHelper<THandler, TValue> where THandler : class
	{
		[Flags]
		public enum tUVxnnoWaOoWRrIfaQfqqnUXZiZg
		{
			None = 0,
			Self = 1,
			Children = 4,
			Parents = 8,
			All = -1
		}

		private readonly EventFunction<THandler, TValue> wpDPnRBsMlRCLZUTKduKGqYTSbrK;

		private readonly List<THandler> WoCLbEzLWrgMuhGIpMCrRygSjAUIA;

		private readonly tUVxnnoWaOoWRrIfaQfqqnUXZiZg AjyrMtyiDIVZNpVsmEyeHDtmhWAE;

		public HierarchyEventHelper(EventFunction<THandler, TValue> P_0)
		{
		}

		public HierarchyEventHelper(EventFunction<THandler, TValue> P_0, tUVxnnoWaOoWRrIfaQfqqnUXZiZg P_1)
		{
		}

		public void ExecuteOnAll(TValue value)
		{
		}

		public void GetHandlers(Transform transform)
		{
		}
	}

	public static void FZEUasFaGBqNtwBgjbrVhxYtMpJEA<_0001, _0002>(IList<_0001> P_0, _0002 P_1, EventFunction<_0001, _0002> P_2, bool P_3) where _0001 : class
	{
	}
}
