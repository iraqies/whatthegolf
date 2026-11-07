using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000019")]
	public struct iOSNotificationTimeIntervalTrigger : iOSNotificationTrigger
	{
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x0")]
		internal int timeInterval;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5038", Offset = "0x1B5038")]
		private bool Repeats__BackingField;

		[Token(Token = "0x17000023")]
		public iOSNotificationTriggerType Type
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2A442CC", Offset = "0x2A442CC", VA = "0x2A442CC", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000024")]
		public TimeSpan TimeInterval
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2A442D4", Offset = "0x2A442D4", VA = "0x2A442D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public bool Repeats
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2A44370", Offset = "0x2A44370", VA = "0x2A44370")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5208", Offset = "0x1B5208")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2A44378", Offset = "0x2A44378", VA = "0x2A44378")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B5218", Offset = "0x1B5218")]
			set
			{
			}
		}
	}
}
