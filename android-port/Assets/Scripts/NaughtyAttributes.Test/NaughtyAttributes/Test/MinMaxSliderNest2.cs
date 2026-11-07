using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000022")]
	public class MinMaxSliderNest2
	{
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 minMaxSlider2;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x22AB860", Offset = "0x22AB860", VA = "0x22AB860")]
		public MinMaxSliderNest2()
		{
		}
	}
}
