using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x2000126")]
	public class EventStreamMessageReceivedEventArgs : EventArgs
	{
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E58", Offset = "0x26E58")]
		private EventStreamMessage Message__BackingField;

		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E68", Offset = "0x26E68")]
		private object Context__BackingField;

		[Token(Token = "0x1700027E")]
		public EventStreamMessage Message
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1205F64", Offset = "0x1205F64", VA = "0x1205F64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A5C", Offset = "0x29A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x1205F6C", Offset = "0x1205F6C", VA = "0x1205F6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A6C", Offset = "0x29A6C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700027F")]
		public object Context
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x1205F74", Offset = "0x1205F74", VA = "0x1205F74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A7C", Offset = "0x29A7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x1205F7C", Offset = "0x1205F7C", VA = "0x1205F7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A8C", Offset = "0x29A8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x1205F84", Offset = "0x1205F84", VA = "0x1205F84")]
		public EventStreamMessageReceivedEventArgs(EventStreamMessage message)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1203598", Offset = "0x1203598", VA = "0x1203598")]
		public EventStreamMessageReceivedEventArgs(EventStreamMessage message, object context)
		{
		}
	}
}
