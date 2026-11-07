using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x200011D")]
	public sealed class EventStreamValidationException : Exception
	{
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1205FFC", Offset = "0x1205FFC", VA = "0x1205FFC")]
		public EventStreamValidationException()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1206078", Offset = "0x1206078", VA = "0x1206078")]
		public EventStreamValidationException(string message)
		{
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1206104", Offset = "0x1206104", VA = "0x1206104")]
		public EventStreamValidationException(string message, Exception innerException)
		{
		}
	}
}
