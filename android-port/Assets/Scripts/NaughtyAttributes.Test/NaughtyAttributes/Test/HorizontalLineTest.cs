using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000014")]
	public class HorizontalLineTest : MonoBehaviour
	{
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x18")]
		public int line0;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x20")]
		public HorizontalLineNest1 nest1;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x22AB78C", Offset = "0x22AB78C", VA = "0x22AB78C")]
		public HorizontalLineTest()
		{
		}
	}
}
