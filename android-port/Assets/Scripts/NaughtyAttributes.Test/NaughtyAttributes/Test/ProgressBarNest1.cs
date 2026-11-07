using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200002A")]
	public class ProgressBarNest1
	{
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x10")]
		public float mana;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x18")]
		public ProgressBarNest2 nest2;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22ABC10", Offset = "0x22ABC10", VA = "0x22ABC10")]
		public ProgressBarNest1()
		{
		}
	}
}
