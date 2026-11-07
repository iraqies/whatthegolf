using System;
using Amazon.Runtime.EventStreams.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x2000114")]
	public class EventStreamEventReceivedArgs<T> : EventArgs where T : IEventStreamEvent
	{
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26D88", Offset = "0x26D88")]
		private readonly T EventStreamEvent__BackingField;

		[Token(Token = "0x17000268")]
		public T EventStreamEvent
		{
			[Token(Token = "0x6000907")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2986C", Offset = "0x2986C")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000908")]
		public EventStreamEventReceivedArgs(T eventStreamEvent)
		{
		}
	}
}
