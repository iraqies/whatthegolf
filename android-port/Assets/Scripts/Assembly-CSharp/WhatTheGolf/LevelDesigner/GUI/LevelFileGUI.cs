using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x200129B")]
	public class LevelFileGUI : MonoBehaviour
	{
		[Token(Token = "0x4006465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SerializableLevelData levelData;

		[Token(Token = "0x4006466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LevelCoverButtonGUI levelCoverButtonGUI;

		[Token(Token = "0x4006467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button viewButton;

		[Token(Token = "0x4006468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI levelNameRenderer;

		[Token(Token = "0x4006469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string defaultText;

		[Token(Token = "0x400646A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5949C", Offset = "0x5949C")]
		private Action<SerializableLevelData> m_OnActionSelected;

		[Token(Token = "0x400646B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x594AC", Offset = "0x594AC")]
		private Action<SerializableLevelData> m_OnViewSelected;

		[Token(Token = "0x400646C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool subscribed;

		[Token(Token = "0x14000094")]
		public event Action<SerializableLevelData> OnActionSelected
		{
			[Token(Token = "0x600564A")]
			[Address(RVA = "0x152D530", Offset = "0x152D530", VA = "0x152D530")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x719A0", Offset = "0x719A0")]
			add
			{
			}
			[Token(Token = "0x600564B")]
			[Address(RVA = "0x152D5D4", Offset = "0x152D5D4", VA = "0x152D5D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x719B0", Offset = "0x719B0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000095")]
		public event Action<SerializableLevelData> OnViewSelected
		{
			[Token(Token = "0x600564C")]
			[Address(RVA = "0x152D678", Offset = "0x152D678", VA = "0x152D678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x719C0", Offset = "0x719C0")]
			add
			{
			}
			[Token(Token = "0x600564D")]
			[Address(RVA = "0x152D71C", Offset = "0x152D71C", VA = "0x152D71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x719D0", Offset = "0x719D0")]
			remove
			{
			}
		}

		[Token(Token = "0x600564E")]
		[Address(RVA = "0x152D7C0", Offset = "0x152D7C0", VA = "0x152D7C0")]
		public void Init(SerializableLevelData levelData, Sprite actionButtonIcon, [Optional] ButtonStateColors overrideHoverColors)
		{
		}

		[Token(Token = "0x600564F")]
		[Address(RVA = "0x152DA10", Offset = "0x152DA10", VA = "0x152DA10")]
		private void CoverButton_OnSelected(SerializableLevelData levelData)
		{
		}

		[Token(Token = "0x6005650")]
		[Address(RVA = "0x152DA80", Offset = "0x152DA80", VA = "0x152DA80")]
		private void ViewButton_OnSelected()
		{
		}

		[Token(Token = "0x6005651")]
		[Address(RVA = "0x152DAE0", Offset = "0x152DAE0", VA = "0x152DAE0")]
		public LevelFileGUI()
		{
		}
	}
}
