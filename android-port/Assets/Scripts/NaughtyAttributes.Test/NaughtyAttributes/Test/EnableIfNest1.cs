using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200000B")]
	public class EnableIfNest1
	{
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		public bool enable1;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x11")]
		public bool enable2;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x14")]
		public int enableIfAll;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		public int enableIfAny;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		public EnableIfNest2 nest2;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x22AB708", Offset = "0x22AB708", VA = "0x22AB708")]
		public EnableIfNest1()
		{
		}
	}
}
