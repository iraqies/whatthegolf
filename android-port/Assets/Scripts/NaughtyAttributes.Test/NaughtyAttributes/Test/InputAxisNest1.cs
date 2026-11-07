using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200001B")]
	public class InputAxisNest1
	{
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x10")]
		public string inputAxis1;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x18")]
		public InputAxisNest2 nest2;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x22AB7AC", Offset = "0x22AB7AC", VA = "0x22AB7AC")]
		public InputAxisNest1()
		{
		}
	}
}
