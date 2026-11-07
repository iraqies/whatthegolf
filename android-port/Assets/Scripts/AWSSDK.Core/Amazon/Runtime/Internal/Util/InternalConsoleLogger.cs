using System;

namespace Amazon.Runtime.Internal.Util
{
	internal class InternalConsoleLogger : InternalLogger
	{
		private enum LogLevel
		{
			Verbose = 2,
			Debug = 3,
			Info = 4,
			Warn = 5,
			Error = 6,
			Assert = 7
		}

		public static long _sequanceId;

		public InternalConsoleLogger(Type declaringType)
			: base(null)
		{
		}

		public override void Flush()
		{
		}

		public override void Error(Exception exception, string messageFormat, params object[] args)
		{
		}

		public override void Debug(Exception exception, string messageFormat, params object[] args)
		{
		}

		public override void DebugFormat(string message, params object[] arguments)
		{
		}

		public override void InfoFormat(string message, params object[] arguments)
		{
		}

		private void Log(LogLevel logLevel, string message, Exception ex)
		{
		}
	}
}
