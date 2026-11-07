using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000027")]
	public class OnValueChangedNest1
	{
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		public int int1;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		public OnValueChangedNest2 nest2;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x22AB8A0", Offset = "0x22AB8A0", VA = "0x22AB8A0")]
		public OnValueChangedNest1()
		{
		}
	}
}
