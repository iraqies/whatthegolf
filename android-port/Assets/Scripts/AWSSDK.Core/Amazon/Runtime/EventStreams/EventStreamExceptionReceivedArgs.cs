using System;
using Amazon.Runtime.EventStreams.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x2000115")]
	public class EventStreamExceptionReceivedArgs<T> : EventArgs where T : EventStreamException
	{
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D98", Offset = "0x26D98")]
		private readonly T EventStreamException__BackingField;

		[Token(Token = "0x17000269")]
		public T EventStreamException
		{
			[Token(Token = "0x6000909")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2987C", Offset = "0x2987C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090A")]
		public EventStreamExceptionReceivedArgs(T eventStreamException)
		{
		}
	}
}
