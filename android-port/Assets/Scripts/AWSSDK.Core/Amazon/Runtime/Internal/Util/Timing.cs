using System;

namespace Amazon.Runtime.Internal.Util
{
	public class Timing : IMetricsTiming
	{
		private long startTime;

		private long endTime;

		public bool IsFinished { get; private set; }

		public long ElapsedTicks => 0L;

		public TimeSpan ElapsedTime => default;

		public Timing()
		{
		}

		public Timing(long currentTime)
		{
		}

		public void Stop(long currentTime)
		{
		}
	}
}
