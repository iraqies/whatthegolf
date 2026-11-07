using System;
using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Runtime.EventStreams
{
	public class EventStreamEventReceivedArgs<T> : EventArgs where T : IEventStreamEvent
	{
		public T EventStreamEvent { get; }

		public EventStreamEventReceivedArgs(T eventStreamEvent)
		{
		}
	}
}
