using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000046")]
	public class ValidateInputNest1
	{
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x10")]
		public int int1;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x18")]
		public ValidateInputNest2 nest2;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x22ABE10", Offset = "0x22ABE10", VA = "0x22ABE10")]
		public ValidateInputNest1()
		{
		}
	}
}
