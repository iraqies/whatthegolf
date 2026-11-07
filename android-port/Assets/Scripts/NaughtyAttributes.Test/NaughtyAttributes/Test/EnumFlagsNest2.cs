using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000010")]
	public class EnumFlagsNest2
	{
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		public TestEnum flags2;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x22AB744", Offset = "0x22AB744", VA = "0x22AB744")]
		public EnumFlagsNest2()
		{
		}
	}
}
