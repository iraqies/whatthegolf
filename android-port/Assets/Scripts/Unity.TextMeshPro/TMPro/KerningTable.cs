using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000027")]
	public class KerningTable
	{
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x10")]
		public List<KerningPair> kerningPairs;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2A7A988", Offset = "0x2A7A988", VA = "0x2A7A988")]
		public KerningTable()
		{
		}
	}
}
