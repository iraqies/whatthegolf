using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Runtime.EventStreams
{
	public sealed class EventStreamErrorCodeException : EventStreamException
	{
		public int ErrorCode
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public EventStreamErrorCodeException(int errorCode)
		{
		}

		public EventStreamErrorCodeException(int errorCode, string message)
		{
		}
	}
}
