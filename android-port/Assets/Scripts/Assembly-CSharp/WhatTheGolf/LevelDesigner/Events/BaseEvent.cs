using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012AA")]
	public abstract class BaseEvent<T> : IEvent where T : Enum
	{
		[Token(Token = "0x40064C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597BC", Offset = "0x597BC")]
		private readonly T EventType__BackingField;

		[Token(Token = "0x40064C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x597CC", Offset = "0x597CC")]
		private object Data__BackingField;

		[Token(Token = "0x170009E4")]
		public T EventType
		{
			[Token(Token = "0x60056BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71B44", Offset = "0x71B44")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x170009E5")]
		public virtual object Data
		{
			[Token(Token = "0x60056BD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71B54", Offset = "0x71B54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056BE")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71B64", Offset = "0x71B64")]
			set
			{
			}
		}

		[Token(Token = "0x170009E6")]
		private Enum WhatTheGolf_002ELevelDesigner_002EEvents_002EIEvent_002EEventType
		{
			[Token(Token = "0x60056BF")]
			get
			{
				return WhatTheGolf_002ELevelDesigner_002EEvents_002EIEvent_002Eget_EventType();
			}
		}

		[Token(Token = "0x60056BF")]
		private Enum WhatTheGolf_002ELevelDesigner_002EEvents_002EIEvent_002Eget_EventType()
		{
			return null;
		}

		[Token(Token = "0x60056C0")]
		public BaseEvent(T eventType, [Optional] object data)
		{
		}
	}
}
