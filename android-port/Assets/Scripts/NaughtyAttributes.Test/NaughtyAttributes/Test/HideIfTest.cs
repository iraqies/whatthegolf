using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000011")]
	public class HideIfTest : MonoBehaviour
	{
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		public bool hide1;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x19")]
		public bool hide2;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x20")]
		public int[] hideIfAll;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x28")]
		public int[] hideIfAny;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x30")]
		public HideIfNest1 nest1;

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x22AB774", Offset = "0x22AB774", VA = "0x22AB774")]
		public HideIfTest()
		{
		}
	}
}
