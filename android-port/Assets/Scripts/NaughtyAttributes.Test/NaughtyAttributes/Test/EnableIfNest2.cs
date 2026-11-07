using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200000C")]
	public class EnableIfNest2
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		public bool enable1;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x11")]
		public bool enable2;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 enableIfAll;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 enableIfAny;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x22AB71C", Offset = "0x22AB71C", VA = "0x22AB71C")]
		public EnableIfNest2()
		{
		}
	}
}
