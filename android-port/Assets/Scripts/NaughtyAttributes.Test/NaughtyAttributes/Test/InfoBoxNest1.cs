using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000018")]
	public class InfoBoxNest1
	{
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x10")]
		public int warning;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x18")]
		public InfoBoxNest2 nest2;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x22AB794", Offset = "0x22AB794", VA = "0x22AB794")]
		public InfoBoxNest1()
		{
		}
	}
}
