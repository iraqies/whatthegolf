using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	public static class AsyncHelpers
	{
		private class ExclusiveSynchronizationContext : SynchronizationContext
		{
			private bool done;

			private readonly AutoResetEvent pendingObjects;

			private readonly Queue<Tuple<SendOrPostCallback, object>> objects;

			public Exception ObjectException { get; set; }

			public override void Send(SendOrPostCallback d, object state)
			{
			}

			public override void Post(SendOrPostCallback d, object state)
			{
			}

			public void EndMessageLoop()
			{
			}

			public void BeginMessageLoop()
			{
			}

			public override SynchronizationContext CreateCopy()
			{
				return null;
			}
		}

		public static void RunSync(Func<Task> workItem)
		{
		}

		public static T RunSync<T>(Func<Task<T>> workItem)
		{
			return default;
		}
	}
}
