using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000036")]
	public class ResizableTextAreaNest2
	{
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x10")]
		public string text2;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x22ABC8C", Offset = "0x22ABC8C", VA = "0x22ABC8C")]
		public ResizableTextAreaNest2()
		{
		}
	}
}
