using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000047")]
	public class ValidateInputNest2
	{
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x10")]
		public int int2;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x22ABE18", Offset = "0x22ABE18", VA = "0x22ABE18")]
		public ValidateInputNest2()
		{
		}
	}
}
