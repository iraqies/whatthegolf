using System.Threading;
using UnityEngine;

namespace UnityAsyncAwaitUtil
{
	public static class SyncContextUtil
	{
		public static int UnityThreadId { get; private set; }

		public static SynchronizationContext UnitySynchronizationContext { get; private set; }

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void Install()
		{
			UnitySynchronizationContext = SynchronizationContext.Current;
			UnityThreadId = Thread.CurrentThread.ManagedThreadId;
		}
	}
}
