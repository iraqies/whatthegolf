using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000021")]
	public class MinMaxSliderNest1
	{
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 minMaxSlider1;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x18")]
		public MinMaxSliderNest2 nest2;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x22AB84C", Offset = "0x22AB84C", VA = "0x22AB84C")]
		public MinMaxSliderNest1()
		{
		}
	}
}
