using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000028")]
	public class OnValueChangedNest2
	{
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x10")]
		public int int2;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x22AB8A8", Offset = "0x22AB8A8", VA = "0x22AB8A8")]
		public OnValueChangedNest2()
		{
		}
	}
}
