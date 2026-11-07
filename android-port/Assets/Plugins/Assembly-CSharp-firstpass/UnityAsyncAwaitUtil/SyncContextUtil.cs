using System.Threading;
using UnityEngine;

namespace UnityAsyncAwaitUtil
{
	public static class SyncContextUtil
	{
		public static int UnityThreadId { get; private set; }

		public static SynchronizationContext UnitySynchronizationContext { get; private set; }

		[RuntimeInitializeOnLoadMethod]
		private static void Install()
		{
		}
	}
}
