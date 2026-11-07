using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x200012C")]
	public abstract class EventStreamException : Exception
	{
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x1203C40", Offset = "0x1203C40", VA = "0x1203C40")]
		protected EventStreamException()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x1203BB4", Offset = "0x1203BB4", VA = "0x1203BB4")]
		protected EventStreamException(string message)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x1203CBC", Offset = "0x1203CBC", VA = "0x1203CBC")]
		protected EventStreamException(string message, Exception innerException)
		{
		}
	}
}
