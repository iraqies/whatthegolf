using System;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012AE")]
	public struct CallbackAndGuidArgs
	{
		[Token(Token = "0x40064C9")]
		[FieldOffset(Offset = "0x0")]
		public Action continueAction;

		[Token(Token = "0x40064CA")]
		[FieldOffset(Offset = "0x8")]
		public Action cancelAction;

		[Token(Token = "0x40064CB")]
		[FieldOffset(Offset = "0x10")]
		public Guid guid;

		[Token(Token = "0x60056C3")]
		[Address(RVA = "0x17E42C0", Offset = "0x17E42C0", VA = "0x17E42C0")]
		public CallbackAndGuidArgs(Action continueAction, Action cancelAction, Guid guid)
		{
		}
	}
}
