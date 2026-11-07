using System;

namespace Amazon.Runtime.Internal.Util
{
	public class MetricError
	{
		public Metric Metric { get; private set; }

		public string Message { get; private set; }

		public Exception Exception { get; private set; }

		public DateTime Time { get; private set; }

		public MetricError(Metric metric, string messageFormat, params object[] args)
		{
		}

		public MetricError(Metric metric, Exception exception, string messageFormat, params object[] args)
		{
		}
	}
}
