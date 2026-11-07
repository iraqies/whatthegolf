using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public static class AsyncRunner
	{
		public static Task Run(Action action, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Task<T> Run<T>(Func<T> action, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
