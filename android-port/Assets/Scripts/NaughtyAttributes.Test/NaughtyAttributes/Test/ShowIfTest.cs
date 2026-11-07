using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200003D")]
	public class ShowIfTest : MonoBehaviour
	{
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x18")]
		public bool show1;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x19")]
		public bool show2;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x20")]
		public int[] showIfAll;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x28")]
		public int[] showIfAny;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x30")]
		public ShowIfNest1 nest1;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x22ABCE4", Offset = "0x22ABCE4", VA = "0x22ABCE4")]
		public ShowIfTest()
		{
		}
	}
}
