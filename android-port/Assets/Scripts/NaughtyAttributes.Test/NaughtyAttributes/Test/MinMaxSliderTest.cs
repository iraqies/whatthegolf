using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000020")]
	public class MinMaxSliderTest : MonoBehaviour
	{
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 minMaxSlider0;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x20")]
		public MinMaxSliderNest1 nest1;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x22AB874", Offset = "0x22AB874", VA = "0x22AB874")]
		public MinMaxSliderTest()
		{
		}
	}
}
