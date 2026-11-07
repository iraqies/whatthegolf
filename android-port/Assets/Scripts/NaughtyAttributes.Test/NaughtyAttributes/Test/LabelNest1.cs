using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200001E")]
	public class LabelNest1
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x10")]
		public int int1;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x18")]
		public LabelNest2 nest2;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x22AB834", Offset = "0x22AB834", VA = "0x22AB834")]
		public LabelNest1()
		{
		}
	}
}
