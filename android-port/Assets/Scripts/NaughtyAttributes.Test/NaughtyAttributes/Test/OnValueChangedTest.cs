using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000026")]
	public class OnValueChangedTest : MonoBehaviour
	{
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		public int int0;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x20")]
		public OnValueChangedNest1 nest1;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x22AB8B0", Offset = "0x22AB8B0", VA = "0x22AB8B0")]
		private void OnValueChangedMethod1(int oldValue, int newValue)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x22ABA5C", Offset = "0x22ABA5C", VA = "0x22ABA5C")]
		private void OnValueChangedMethod2(int oldValue, int newValue)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x22ABC08", Offset = "0x22ABC08", VA = "0x22ABC08")]
		public OnValueChangedTest()
		{
		}
	}
}
