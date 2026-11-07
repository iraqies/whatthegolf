using System;
using System.Diagnostics;

namespace Amazon.Runtime.Internal.Util
{
	internal class InternalSystemDiagnosticsLogger : InternalLogger
	{
		private int eventId;

		private TraceSource trace;

		public override bool IsDebugEnabled => false;

		public override bool IsErrorEnabled => false;

		public override bool IsInfoEnabled => false;

		public InternalSystemDiagnosticsLogger(Type declaringType)
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

		public override void DebugFormat(string messageFormat, params object[] args)
		{
		}

		public override void InfoFormat(string message, params object[] arguments)
		{
		}
	}
}
