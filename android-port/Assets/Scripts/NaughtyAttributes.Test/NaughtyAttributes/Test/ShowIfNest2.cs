using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200003F")]
	public class ShowIfNest2
	{
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		public bool show1;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x11")]
		public bool show2;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 showIfAll;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 showIfAny;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x22ABCCC", Offset = "0x22ABCCC", VA = "0x22ABCCC")]
		public ShowIfNest2()
		{
		}
	}
}
