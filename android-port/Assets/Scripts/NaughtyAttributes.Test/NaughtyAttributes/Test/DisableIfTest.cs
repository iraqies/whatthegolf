using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000004")]
	public class DisableIfTest : MonoBehaviour
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		public bool disable1;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x19")]
		public bool disable2;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		public int[] disableIfAll;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x28")]
		public int[] disableIfAny;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x30")]
		public DisableIfNest1 nest1;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x22AB668", Offset = "0x22AB668", VA = "0x22AB668")]
		public DisableIfTest()
		{
		}
	}
}
