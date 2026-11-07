using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000043")]
	public class TagNest1
	{
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x10")]
		public string tag1;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x18")]
		public TagNest2 nest2;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x22ABD88", Offset = "0x22ABD88", VA = "0x22ABD88")]
		public TagNest1()
		{
		}
	}
}
