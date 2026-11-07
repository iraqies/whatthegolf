using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012B7")]
	public class InputEvent : BaseEvent<InputEvent.InputEventType>
	{
		[Token(Token = "0x20012B8")]
		public enum InputEventType
		{
			[Token(Token = "0x40064F4")]
			Empty = 0,
			[Token(Token = "0x40064F5")]
			CtrlHotkey = 1
		}

		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x14ED830", Offset = "0x14ED830", VA = "0x14ED830")]
		public InputEvent(InputEventType eventType, [Optional] object data)
		{
		}
	}
}
