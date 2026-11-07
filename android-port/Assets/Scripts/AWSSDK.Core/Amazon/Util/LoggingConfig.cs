using Amazon.Runtime;

namespace Amazon.Util
{
	public class LoggingConfig
	{
		public static readonly int DefaultLogResponsesSizeLimit;

		private LoggingOptions _logTo;

		public LoggingOptions LogTo
		{
			get
			{
				return LoggingOptions.None;
			}
			set
			{
			}
		}

		public ResponseLoggingOption LogResponses { get; set; }

		public int LogResponsesSizeLimit { get; set; }

		public bool LogMetrics { get; set; }

		public LogMetricsFormatOption LogMetricsFormat { get; set; }

		public IMetricsFormatter LogMetricsCustomFormatter { get; set; }

		internal LoggingConfig()
		{
		}
	}
}
