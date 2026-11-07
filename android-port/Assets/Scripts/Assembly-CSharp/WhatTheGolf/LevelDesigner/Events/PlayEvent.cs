using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012BC")]
	public class PlayEvent : BaseEvent<PlayEvent.PlayEventType>
	{
		[Token(Token = "0x20012BD")]
		public enum PlayEventType
		{
			[Token(Token = "0x40064F7")]
			Empty = 0,
			[Token(Token = "0x40064F8")]
			Reset = 1,
			[Token(Token = "0x40064F9")]
			HitFlag = 2
		}

		[Token(Token = "0x60056D0")]
		[Address(RVA = "0x15E9DF8", Offset = "0x15E9DF8", VA = "0x15E9DF8")]
		public PlayEvent(PlayEventType eventType, [Optional] object data)
		{
		}
	}
}
