using System;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012AF")]
	public struct CallbackArgs
	{
		[Token(Token = "0x40064CC")]
		[FieldOffset(Offset = "0x0")]
		public Action continueAction;

		[Token(Token = "0x40064CD")]
		[FieldOffset(Offset = "0x8")]
		public Action cancelAction;

		[Token(Token = "0x60056C4")]
		[Address(RVA = "0x17E42CC", Offset = "0x17E42CC", VA = "0x17E42CC")]
		public CallbackArgs(Action continueAction, Action cancelAction)
		{
		}
	}
}
