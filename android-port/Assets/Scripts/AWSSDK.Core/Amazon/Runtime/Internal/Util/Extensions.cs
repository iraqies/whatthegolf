using System.Diagnostics;

namespace Amazon.Runtime.Internal.Util
{
	public static class Extensions
	{
		private static readonly long TicksPerSecond;

		private static readonly double TickFrequency;

		public static long GetElapsedDateTimeTicks(this Stopwatch self)
		{
			return 0L;
		}

		public static bool HasRequestData(this IRequest request)
		{
			return false;
		}
	}
}
