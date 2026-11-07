using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012B1")]
	public struct KeyCodeArgs
	{
		[Token(Token = "0x40064CF")]
		[FieldOffset(Offset = "0x0")]
		public KeyCode key;

		[Token(Token = "0x60056C6")]
		[Address(RVA = "0x14FE5DC", Offset = "0x14FE5DC", VA = "0x14FE5DC")]
		public KeyCodeArgs(KeyCode key)
		{
		}
	}
}
