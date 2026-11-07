using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200002B")]
	public class ProgressBarNest2
	{
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x10")]
		public float mana;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x22ABC20", Offset = "0x22ABC20", VA = "0x22ABC20")]
		public ProgressBarNest2()
		{
		}
	}
}
