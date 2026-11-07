using System;

namespace Amazon.Runtime.Internal.Util
{
	public class LogMessage : ILogMessage
	{
		public object[] Args { get; private set; }

		public IFormatProvider Provider { get; private set; }

		public string Format { get; private set; }

		public LogMessage(string message)
		{
		}

		public LogMessage(string format, params object[] args)
		{
		}

		public LogMessage(IFormatProvider provider, string format, params object[] args)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
