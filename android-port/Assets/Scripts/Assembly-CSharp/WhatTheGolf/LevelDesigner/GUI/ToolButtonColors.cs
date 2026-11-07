using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001285")]
	public class ToolButtonColors : ScriptableObject
	{
		[Token(Token = "0x4006389")]
		[FieldOffset(Offset = "0x18")]
		public Color normalColor;

		[Token(Token = "0x400638A")]
		[FieldOffset(Offset = "0x28")]
		public Color hoverColor;

		[Token(Token = "0x400638B")]
		[FieldOffset(Offset = "0x38")]
		public Color activeColor;

		[Token(Token = "0x600559D")]
		[Address(RVA = "0x171DC40", Offset = "0x171DC40", VA = "0x171DC40")]
		public ToolButtonColors()
		{
		}
	}
}
