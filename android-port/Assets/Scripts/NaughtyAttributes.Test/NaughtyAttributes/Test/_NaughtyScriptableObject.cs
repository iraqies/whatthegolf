using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000049")]
	public class _NaughtyScriptableObject : ScriptableObject
	{
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x18")]
		public int myInt;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x22ABE44", Offset = "0x22ABE44", VA = "0x22ABE44")]
		private void IncrementMyInt()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x22ABE54", Offset = "0x22ABE54", VA = "0x22ABE54")]
		private void DecrementMyInt()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x22ABE64", Offset = "0x22ABE64", VA = "0x22ABE64")]
		public _NaughtyScriptableObject()
		{
		}
	}
}
