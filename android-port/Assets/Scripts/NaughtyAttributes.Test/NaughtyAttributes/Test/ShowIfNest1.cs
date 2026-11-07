using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200003E")]
	public class ShowIfNest1
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		public bool show1;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x11")]
		public bool show2;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x14")]
		public int showIfAll;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		public int showIfAny;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		public ShowIfNest2 nest2;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x22ABCC4", Offset = "0x22ABCC4", VA = "0x22ABCC4")]
		public ShowIfNest1()
		{
		}
	}
}
