using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.Scripting;

namespace Apple.Core.Runtime
{
	[Preserve]
	public static class InteropTasks
	{
		private static readonly Dictionary<string, object> _taskCompletionSources;

		private static readonly object _taskLock;

		public static TaskCompletionSource<TResult> Create<TResult>(out string guid)
		{
			guid = null;
			return null;
		}

		public static bool TrySetResultAndRemove<TResult>(string guid, TResult result)
		{
			return false;
		}

		public static bool TrySetExceptionAndRemove<TResult>(string guid, Exception exception)
		{
			return false;
		}
	}
}
