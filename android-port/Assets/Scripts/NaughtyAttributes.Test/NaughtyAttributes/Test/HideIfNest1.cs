using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000012")]
	public class HideIfNest1
	{
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x10")]
		public bool hide1;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x11")]
		public bool hide2;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x14")]
		public int hideIfAll;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x18")]
		public int hideIfAny;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x20")]
		public HideIfNest2 nest2;

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x22AB754", Offset = "0x22AB754", VA = "0x22AB754")]
		public HideIfNest1()
		{
		}
	}
}
