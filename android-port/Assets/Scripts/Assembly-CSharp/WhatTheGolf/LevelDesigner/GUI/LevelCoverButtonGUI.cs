using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001296")]
	public class LevelCoverButtonGUI : MonoBehaviour
	{
		[Token(Token = "0x400640B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SerializableLevelData levelData;

		[Token(Token = "0x400640C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MultiGraphicButton button;

		[Token(Token = "0x400640D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RawImage thumbnailRenderer;

		[Token(Token = "0x400640E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SVGImage actionIconRenderer;

		[Token(Token = "0x400640F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject ballIconRendererContainer;

		[Token(Token = "0x4006410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SVGImage ballIconRenderer;

		[Token(Token = "0x4006411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ButtonStateColors thumbnailHoverColors;

		[Token(Token = "0x4006412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject publishedLabel;

		[Token(Token = "0x4006413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5905C", Offset = "0x5905C")]
		private Action<SerializableLevelData> m_OnSelected;

		[Token(Token = "0x4006414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool subscribed;

		[Token(Token = "0x14000093")]
		public event Action<SerializableLevelData> OnSelected
		{
			[Token(Token = "0x600560C")]
			[Address(RVA = "0x15275CC", Offset = "0x15275CC", VA = "0x15275CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71930", Offset = "0x71930")]
			add
			{
			}
			[Token(Token = "0x600560D")]
			[Address(RVA = "0x1527670", Offset = "0x1527670", VA = "0x1527670")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71940", Offset = "0x71940")]
			remove
			{
			}
		}

		[Token(Token = "0x600560E")]
		[Address(RVA = "0x1527714", Offset = "0x1527714", VA = "0x1527714")]
		public void Init([Optional] Sprite actionIcon, [Optional] ButtonStateColors overrideHoverColors)
		{
		}

		[Token(Token = "0x600560F")]
		[Address(RVA = "0x1527964", Offset = "0x1527964", VA = "0x1527964")]
		public void Init(SerializableLevelData levelData, [Optional] Sprite actionIcon, [Optional] ButtonStateColors overrideHoverColors, bool showPublishedStatus = false)
		{
		}

		[Token(Token = "0x6005610")]
		[Address(RVA = "0x15279CC", Offset = "0x15279CC", VA = "0x15279CC")]
		public void Init(SerializableLevelData levelData, Sprite actionIcon, Texture levelThumbnail, [Optional] ButtonStateColors overrideHoverColors, bool showPublishedStatus = false)
		{
		}

		[Token(Token = "0x6005611")]
		[Address(RVA = "0x1527CB0", Offset = "0x1527CB0", VA = "0x1527CB0")]
		public void SetButtonInteractable(bool interactable)
		{
		}

		[Token(Token = "0x6005612")]
		[Address(RVA = "0x1527CCC", Offset = "0x1527CCC", VA = "0x1527CCC")]
		private void Button_OnSelected()
		{
		}

		[Token(Token = "0x6005613")]
		[Address(RVA = "0x1527D2C", Offset = "0x1527D2C", VA = "0x1527D2C")]
		public LevelCoverButtonGUI()
		{
		}
	}
}
