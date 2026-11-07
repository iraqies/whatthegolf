using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000007")]
	public class DropdownTest : MonoBehaviour
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		public int intValue;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		private int[] intValues;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		public DropdownNest1 nest1;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x22AB680", Offset = "0x22AB680", VA = "0x22AB680")]
		public DropdownTest()
		{
		}
	}
}
