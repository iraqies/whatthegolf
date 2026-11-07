using Amazon.Runtime.EventStreams.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x2000113")]
	public sealed class EventStreamErrorCodeException : EventStreamException
	{
		[Token(Token = "0x17000267")]
		public int ErrorCode
		{
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x120385C", Offset = "0x120385C", VA = "0x120385C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x120397C", Offset = "0x120397C", VA = "0x120397C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1203AA8", Offset = "0x1203AA8", VA = "0x1203AA8")]
		public EventStreamErrorCodeException(int errorCode)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1203B28", Offset = "0x1203B28", VA = "0x1203B28")]
		public EventStreamErrorCodeException(int errorCode, string message)
		{
		}
	}
}
