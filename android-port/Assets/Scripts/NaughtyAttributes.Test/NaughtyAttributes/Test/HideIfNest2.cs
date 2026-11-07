using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000013")]
	public class HideIfNest2
	{
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x10")]
		public bool hide1;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x11")]
		public bool hide2;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 hideIfAll;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 hideIfAny;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x22AB75C", Offset = "0x22AB75C", VA = "0x22AB75C")]
		public HideIfNest2()
		{
		}
	}
}
