using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001293")]
	public class MultiGraphicButton : Button
	{
		[Serializable]
		[Token(Token = "0x2001294")]
		private class GraphicToolButtonColorsPair
		{
			[Token(Token = "0x40063FC")]
			[FieldOffset(Offset = "0x10")]
			public Graphic graphic;

			[Token(Token = "0x40063FD")]
			[FieldOffset(Offset = "0x18")]
			public ButtonStateColors colors;

			[Token(Token = "0x6005600")]
			[Address(RVA = "0x17FC0B4", Offset = "0x17FC0B4", VA = "0x17FC0B4")]
			public GraphicToolButtonColorsPair()
			{
			}
		}

		[Token(Token = "0x40063FB")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GraphicToolButtonColorsPair[] graphicsColorPairs;

		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x1579D50", Offset = "0x1579D50", VA = "0x1579D50", Slot = "26")]
		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x1579E8C", Offset = "0x1579E8C", VA = "0x1579E8C")]
		public void SetStateColor(ButtonStateColors colors, int index)
		{
		}

		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x1579ED8", Offset = "0x1579ED8", VA = "0x1579ED8")]
		public MultiGraphicButton()
		{
		}
	}
}
