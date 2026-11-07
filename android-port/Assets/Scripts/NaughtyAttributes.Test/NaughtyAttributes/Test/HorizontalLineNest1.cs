using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000015")]
	public class HorizontalLineNest1
	{
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		public int line1;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x18")]
		public HorizontalLineNest2 nest2;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x22AB77C", Offset = "0x22AB77C", VA = "0x22AB77C")]
		public HorizontalLineNest1()
		{
		}
	}
}
