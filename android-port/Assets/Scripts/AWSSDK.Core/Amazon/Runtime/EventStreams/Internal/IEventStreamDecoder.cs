using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x2000128")]
	public interface IEventStreamDecoder : IDisposable
	{
		[Token(Token = "0x1400000D")]
		event EventHandler<EventStreamMessageReceivedEventArgs> MessageReceived;

		[Token(Token = "0x600098A")]
		void ProcessData(byte[] data, int offset, int length);
	}
}
