using System;
using System.Collections;
using System.Collections.Generic;

namespace Amazon.Runtime.EventStreams.Internal
{
	public interface IEnumerableEventStream<T, TE> : IEventStream<T, TE>, IDisposable, IEnumerable<T>, IEnumerable where T : IEventStreamEvent where TE : EventStreamException, new()
	{
	}
}
