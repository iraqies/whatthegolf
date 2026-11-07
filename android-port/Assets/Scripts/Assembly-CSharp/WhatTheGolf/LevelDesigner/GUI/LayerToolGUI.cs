using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x20012A5")]
	public class LayerToolGUI : MonoBehaviour
	{
		[Token(Token = "0x40064A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerIconGUI[] m_LayerIcons;

		[Token(Token = "0x40064A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider m_Slider;

		[Token(Token = "0x60056A3")]
		[Address(RVA = "0x151F084", Offset = "0x151F084", VA = "0x151F084")]
		private void Awake()
		{
		}

		[Token(Token = "0x60056A4")]
		[Address(RVA = "0x151F258", Offset = "0x151F258", VA = "0x151F258")]
		private void OnSliderChanged(float f)
		{
		}

		[Token(Token = "0x60056A5")]
		[Address(RVA = "0x151F178", Offset = "0x151F178", VA = "0x151F178")]
		private void SetLayerGraphics(int layer)
		{
		}

		[Token(Token = "0x60056A6")]
		[Address(RVA = "0x151F284", Offset = "0x151F284", VA = "0x151F284")]
		public LayerToolGUI()
		{
		}
	}
}
