using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012AD")]
	public struct ClickBrushArgs
	{
		[Token(Token = "0x40064C8")]
		[FieldOffset(Offset = "0x0")]
		public float brushSize;

		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x189FF2C", Offset = "0x189FF2C", VA = "0x189FF2C")]
		public ClickBrushArgs(float brushSize)
		{
		}
	}
}
