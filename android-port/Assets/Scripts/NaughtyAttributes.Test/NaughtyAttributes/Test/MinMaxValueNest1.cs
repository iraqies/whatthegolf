using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public class MinMaxValueNest1
	{
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x10")]
		public int min0;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x14")]
		public int max0;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x18")]
		public float range01;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		public MinMaxValueNest2 nest2;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x22AB888", Offset = "0x22AB888", VA = "0x22AB888")]
		public MinMaxValueNest1()
		{
		}
	}
}
