using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000045")]
	public class ValidateInputTest : MonoBehaviour
	{
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x18")]
		public int int0;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x20")]
		public ValidateInputNest1 nest1;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x22ABE20", Offset = "0x22ABE20", VA = "0x22ABE20")]
		private bool NotZero0(int value)
		{
			return default;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x22ABE2C", Offset = "0x22ABE2C", VA = "0x22ABE2C")]
		public ValidateInputTest()
		{
		}
	}
}
