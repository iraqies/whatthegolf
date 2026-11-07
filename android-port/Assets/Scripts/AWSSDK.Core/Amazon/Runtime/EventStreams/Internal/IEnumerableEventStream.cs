using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x2000120")]
	public interface IEnumerableEventStream<T, TE> : IEventStream<T, TE>, IDisposable, IEnumerable<T>, IEnumerable where T : IEventStreamEvent where TE : EventStreamException, new()
	{
	}
}
