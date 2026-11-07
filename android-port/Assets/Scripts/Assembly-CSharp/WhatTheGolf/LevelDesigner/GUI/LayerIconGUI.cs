using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x20012A4")]
	public class LayerIconGUI : MonoBehaviour
	{
		[Token(Token = "0x40064A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color m_ActiveColor;

		[Token(Token = "0x40064A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color m_InactiveColor;

		[Token(Token = "0x40064A2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SVGImage m_OuterImage;

		[Token(Token = "0x40064A3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SVGImage m_InnerImage;

		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x151F010", Offset = "0x151F010", VA = "0x151F010")]
		public void SetColor(bool active)
		{
		}

		[Token(Token = "0x60056A2")]
		[Address(RVA = "0x151F07C", Offset = "0x151F07C", VA = "0x151F07C")]
		public LayerIconGUI()
		{
		}
	}
}
