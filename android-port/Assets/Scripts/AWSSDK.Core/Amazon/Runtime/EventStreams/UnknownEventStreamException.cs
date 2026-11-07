using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Runtime.EventStreams
{
	public sealed class UnknownEventStreamException : EventStreamException
	{
		public string ExceptionType
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public UnknownEventStreamException(string exceptionType)
		{
		}
	}
}
