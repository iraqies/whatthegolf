using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200000A")]
	public class EnableIfTest : MonoBehaviour
	{
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x18")]
		public bool enable1;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x19")]
		public bool enable2;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x20")]
		public int[] enableIfAll;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x28")]
		public int[] enableIfAny;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x30")]
		public EnableIfNest1 nest1;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x22AB734", Offset = "0x22AB734", VA = "0x22AB734")]
		public EnableIfTest()
		{
		}
	}
}
