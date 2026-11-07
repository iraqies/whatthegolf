using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000035")]
	public class ResizableTextAreaNest1
	{
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		public string text1;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x18")]
		public ResizableTextAreaNest2 nest2;

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x22ABC84", Offset = "0x22ABC84", VA = "0x22ABC84")]
		public ResizableTextAreaNest1()
		{
		}
	}
}
