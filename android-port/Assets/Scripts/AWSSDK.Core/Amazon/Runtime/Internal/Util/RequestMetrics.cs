using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Amazon.Runtime.Internal.Util
{
	public class RequestMetrics : IRequestMetrics
	{
		private object metricsLock;

		private Stopwatch stopWatch;

		private Dictionary<Metric, Timing> inFlightTimings;

		private List<MetricError> errors;

		private long CurrentTime => 0L;

		public Dictionary<Metric, List<object>> Properties { get; set; }

		public Dictionary<Metric, List<IMetricsTiming>> Timings { get; set; }

		public Dictionary<Metric, long> Counters { get; set; }

		public bool IsEnabled { get; internal set; }

		private void LogError_Locked(Metric metric, string messageFormat, params object[] args)
		{
		}

		private static void Log(StringBuilder builder, Metric metric, object metricValue)
		{
		}

		private static void Log(StringBuilder builder, Metric metric, List<object> metricValues)
		{
		}

		private static void LogHelper(StringBuilder builder, Metric metric, params object[] metricValues)
		{
		}

		private static string ObjectToString(object data)
		{
			return null;
		}

		public TimingEvent StartEvent(Metric metric)
		{
			return null;
		}

		public Timing StopEvent(Metric metric)
		{
			return null;
		}

		public void AddProperty(Metric metric, object property)
		{
		}

		public void SetCounter(Metric metric, long value)
		{
		}

		public void IncrementCounter(Metric metric)
		{
		}

		public string GetErrors()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToJSON()
		{
			return null;
		}
	}
}
