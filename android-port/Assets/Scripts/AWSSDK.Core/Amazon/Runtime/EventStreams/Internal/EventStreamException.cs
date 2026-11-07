using System;

namespace Amazon.Runtime.EventStreams.Internal
{
	public abstract class EventStreamException : Exception
	{
		protected EventStreamException()
		{
		}

		protected EventStreamException(string message)
		{
		}

		protected EventStreamException(string message, Exception innerException)
		{
		}
	}
}
