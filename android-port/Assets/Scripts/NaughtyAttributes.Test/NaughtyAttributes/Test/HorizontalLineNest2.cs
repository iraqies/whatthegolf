using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000016")]
	public class HorizontalLineNest2
	{
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		public int line2;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x22AB784", Offset = "0x22AB784", VA = "0x22AB784")]
		public HorizontalLineNest2()
		{
		}
	}
}
