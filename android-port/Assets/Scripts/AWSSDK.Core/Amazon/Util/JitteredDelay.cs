using System;

namespace Amazon.Util
{
	public class JitteredDelay
	{
		private TimeSpan _maxDelay;

		private TimeSpan _variance;

		private TimeSpan _baseIncrement;

		private Random _rand;

		private int _count;

		public JitteredDelay(TimeSpan baseIncrement, TimeSpan variance)
		{
		}

		public JitteredDelay(TimeSpan baseIncrement, TimeSpan variance, TimeSpan maxDelay)
		{
		}

		public TimeSpan GetRetryDelay(int attemptCount)
		{
			return default;
		}

		public TimeSpan Next()
		{
			return default;
		}

		public void Reset()
		{
		}
	}
}
