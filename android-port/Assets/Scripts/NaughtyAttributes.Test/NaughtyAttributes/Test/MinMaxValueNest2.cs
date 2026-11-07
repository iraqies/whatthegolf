using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000025")]
	public class MinMaxValueNest2
	{
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x10")]
		public int min0;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x14")]
		public int max0;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x18")]
		public float range01;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x22AB890", Offset = "0x22AB890", VA = "0x22AB890")]
		public MinMaxValueNest2()
		{
		}
	}
}
