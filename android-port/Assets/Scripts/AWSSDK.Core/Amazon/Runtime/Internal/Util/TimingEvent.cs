using System;

namespace Amazon.Runtime.Internal.Util
{
	public class TimingEvent : IDisposable
	{
		private Metric metric;

		private RequestMetrics metrics;

		private bool disposed;

		internal TimingEvent(RequestMetrics metrics, Metric metric)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		~TimingEvent()
		{
		}
	}
}
