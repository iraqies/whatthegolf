using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000003")]
	public class ButtonTest : MonoBehaviour
	{
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		public int myInt;

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x22AB614", Offset = "0x22AB614", VA = "0x22AB614")]
		private void IncrementMyInt()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x22AB624", Offset = "0x22AB624", VA = "0x22AB624")]
		private void DecrementMyInt()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x22AB634", Offset = "0x22AB634", VA = "0x22AB634")]
		public ButtonTest()
		{
		}
	}
}
