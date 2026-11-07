using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001283")]
	public class ButtonStateColors : ScriptableObject
	{
		[Token(Token = "0x4006380")]
		[FieldOffset(Offset = "0x18")]
		public Color disabledColor;

		[Token(Token = "0x4006381")]
		[FieldOffset(Offset = "0x28")]
		public Color highlightedColor;

		[Token(Token = "0x4006382")]
		[FieldOffset(Offset = "0x38")]
		public Color normalColor;

		[Token(Token = "0x4006383")]
		[FieldOffset(Offset = "0x48")]
		public Color pressedColor;

		[Token(Token = "0x4006384")]
		[FieldOffset(Offset = "0x58")]
		public Color selectedColor;

		[Token(Token = "0x6005599")]
		[Address(RVA = "0x17DA1AC", Offset = "0x17DA1AC", VA = "0x17DA1AC")]
		public ButtonStateColors()
		{
		}
	}
}
