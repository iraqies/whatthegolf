using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200016F")]
	internal class StreamReadTracker
	{
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x10")]
		private object sender;

		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x18")]
		private EventHandler<StreamTransferProgressArgs> callback;

		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x20")]
		private long contentLength;

		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x28")]
		private long totalBytesRead;

		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x30")]
		private long totalIncrementTransferred;

		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x38")]
		private long progressUpdateInterval;

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x127BF60", Offset = "0x127BF60", VA = "0x127BF60")]
		internal StreamReadTracker(object sender, EventHandler<StreamTransferProgressArgs> callback, long contentLength, long progressUpdateInterval)
		{
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x127BFB0", Offset = "0x127BFB0", VA = "0x127BFB0")]
		public void ReadProgress(int bytesRead)
		{
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x127C19C", Offset = "0x127C19C", VA = "0x127C19C")]
		public void UpdateProgress(float progress)
		{
		}
	}
}
