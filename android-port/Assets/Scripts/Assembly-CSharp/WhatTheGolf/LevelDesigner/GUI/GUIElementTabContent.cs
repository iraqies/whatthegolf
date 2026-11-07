using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001284")]
	public class GUIElementTabContent : ScriptableObject
	{
		[Token(Token = "0x4006385")]
		[FieldOffset(Offset = "0x18")]
		public GUIElementType type;

		[NonSerialized]
		[Token(Token = "0x4006386")]
		[FieldOffset(Offset = "0x20")]
		private List<ElementDefinition> elements;

		[Token(Token = "0x4006387")]
		[FieldOffset(Offset = "0x28")]
		public Sprite icon;

		[Token(Token = "0x4006388")]
		[FieldOffset(Offset = "0x30")]
		public string title;

		[Token(Token = "0x600559A")]
		[Address(RVA = "0x1475EC8", Offset = "0x1475EC8", VA = "0x1475EC8")]
		public void SetContent(List<ElementDefinition> content)
		{
		}

		[Token(Token = "0x600559B")]
		[Address(RVA = "0x1475F98", Offset = "0x1475F98", VA = "0x1475F98")]
		public List<ElementDefinition> GetContent()
		{
			return null;
		}

		[Token(Token = "0x600559C")]
		[Address(RVA = "0x1475FA0", Offset = "0x1475FA0", VA = "0x1475FA0")]
		public GUIElementTabContent()
		{
		}
	}
}
