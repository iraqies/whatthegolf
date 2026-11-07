using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x2000124")]
	public interface IEventStream<T, TE> : IDisposable where T : IEventStreamEvent where TE : EventStreamException, new()
	{
		[Token(Token = "0x17000277")]
		int BufferSize
		{
			[Token(Token = "0x6000962")]
			get;
			[Token(Token = "0x6000963")]
			set;
		}

		[Token(Token = "0x14000009")]
		event EventHandler<EventStreamEventReceivedArgs<T>> EventReceived;

		[Token(Token = "0x1400000A")]
		event EventHandler<EventStreamExceptionReceivedArgs<TE>> ExceptionReceived;

		[Token(Token = "0x6000968")]
		void StartProcessing();
	}
}
