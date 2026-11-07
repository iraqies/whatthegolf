using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200000F")]
	public class EnumFlagsNest1
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		public TestEnum flags1;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x18")]
		public EnumFlagsNest2 nest2;

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x22AB73C", Offset = "0x22AB73C", VA = "0x22AB73C")]
		public EnumFlagsNest1()
		{
		}
	}
}
