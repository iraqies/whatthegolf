using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000010")]
	public class TMP_ColorGradient : ScriptableObject
	{
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x18")]
		public ColorMode colorMode;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x1C")]
		public Color topLeft;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x2C")]
		public Color topRight;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x3C")]
		public Color bottomLeft;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x4C")]
		public Color bottomRight;

		[Token(Token = "0x400005B")]
		private const ColorMode k_DefaultColorMode = ColorMode.FourCornersGradient;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color k_DefaultColor;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2A7D980", Offset = "0x2A7D980", VA = "0x2A7D980")]
		public TMP_ColorGradient()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2A7DA24", Offset = "0x2A7DA24", VA = "0x2A7DA24")]
		public TMP_ColorGradient(Color color)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2A7DA94", Offset = "0x2A7DA94", VA = "0x2A7DA94")]
		public TMP_ColorGradient(Color color0, Color color1, Color color2, Color color3)
		{
		}
	}
}
