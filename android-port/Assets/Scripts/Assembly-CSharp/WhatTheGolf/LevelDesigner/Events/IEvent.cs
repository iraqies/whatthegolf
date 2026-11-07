using System;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012B9")]
	public interface IEvent
	{
		[Token(Token = "0x170009E7")]
		object Data
		{
			[Token(Token = "0x60056CD")]
			get;
		}

		[Token(Token = "0x170009E8")]
		Enum EventType
		{
			[Token(Token = "0x60056CE")]
			get;
		}
	}
}
