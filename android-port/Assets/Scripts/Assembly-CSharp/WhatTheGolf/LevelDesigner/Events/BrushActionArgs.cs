using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Events
{
	[Token(Token = "0x20012AB")]
	public struct BrushActionArgs
	{
		[Token(Token = "0x20012AC")]
		public enum BrushType
		{
			[Token(Token = "0x40064C5")]
			PaintTerrain = 0,
			[Token(Token = "0x40064C6")]
			PaintObject = 1,
			[Token(Token = "0x40064C7")]
			Eraser = 2
		}

		[Token(Token = "0x40064C2")]
		[FieldOffset(Offset = "0x0")]
		public BrushType brushType;

		[Token(Token = "0x40064C3")]
		[FieldOffset(Offset = "0x4")]
		public float delta;

		[Token(Token = "0x60056C1")]
		[Address(RVA = "0x1709724", Offset = "0x1709724", VA = "0x1709724")]
		public BrushActionArgs(BrushType brushType, float delta)
		{
		}
	}
}
