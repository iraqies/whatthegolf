using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001288")]
	public class ElementsTabGUI : MonoBehaviour
	{
		[Token(Token = "0x400639E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PersistentButton tabButton;

		[Token(Token = "0x400639F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ElementButtonGUI elementButtonGUIPrefab;

		[Token(Token = "0x40063A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SVGImage iconRenderer;

		[Token(Token = "0x40063A1")]
		[FieldOffset(Offset = "0x30")]
		private ElementsGUI m_Owner;

		[Token(Token = "0x40063A2")]
		[FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI titleRenderer;

		[Token(Token = "0x40063A3")]
		[FieldOffset(Offset = "0x40")]
		private ScrollRect scroll;

		[Token(Token = "0x40063A4")]
		[FieldOffset(Offset = "0x48")]
		private GUIElementTabContent tabContent;

		[Token(Token = "0x40063A5")]
		[FieldOffset(Offset = "0x50")]
		private List<ElementButtonGUI> buttons;

		[Token(Token = "0x40063A6")]
		[FieldOffset(Offset = "0x58")]
		private LayoutGroup layoutGroup;

		[Token(Token = "0x40063A7")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58D1C", Offset = "0x58D1C")]
		private Action<ElementDefinition> m_OnElementSelected;

		[Token(Token = "0x40063A8")]
		[FieldOffset(Offset = "0x68")]
		private bool isSelected;

		[Token(Token = "0x40063A9")]
		[FieldOffset(Offset = "0x6C")]
		private int m_SelectedButtonIndex;

		[Token(Token = "0x14000092")]
		public event Action<ElementDefinition> OnElementSelected
		{
			[Token(Token = "0x60055B5")]
			[Address(RVA = "0x143D948", Offset = "0x143D948", VA = "0x143D948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71900", Offset = "0x71900")]
			add
			{
			}
			[Token(Token = "0x60055B6")]
			[Address(RVA = "0x143E964", Offset = "0x143E964", VA = "0x143E964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71910", Offset = "0x71910")]
			remove
			{
			}
		}

		[Token(Token = "0x60055B7")]
		[Address(RVA = "0x143D808", Offset = "0x143D808", VA = "0x143D808")]
		public void Init(ElementsGUI owner, GUIElementTabContent tabContent, LayoutGroup layoutGroup, ScrollRect scroll, TextMeshProUGUI tabTitleRenderer)
		{
		}

		[Token(Token = "0x60055B8")]
		[Address(RVA = "0x143EA08", Offset = "0x143EA08", VA = "0x143EA08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60055B9")]
		[Address(RVA = "0x143EB00", Offset = "0x143EB00", VA = "0x143EB00")]
		private void TabButton_OnSelected(PersistentButton button)
		{
		}

		[Token(Token = "0x60055BA")]
		[Address(RVA = "0x143F0F8", Offset = "0x143F0F8", VA = "0x143F0F8")]
		private void TabButton_OnDeselected(PersistentButton button)
		{
		}

		[Token(Token = "0x60055BB")]
		[Address(RVA = "0x143F3F4", Offset = "0x143F3F4", VA = "0x143F3F4")]
		private void ElementButton_OnSelected(ElementDefinition element, ElementButtonGUI buttonGui)
		{
		}

		[Token(Token = "0x60055BC")]
		[Address(RVA = "0x143E5FC", Offset = "0x143E5FC", VA = "0x143E5FC")]
		public void ManualSelect(int selectedIndex = -1)
		{
		}

		[Token(Token = "0x60055BD")]
		[Address(RVA = "0x143E62C", Offset = "0x143E62C", VA = "0x143E62C")]
		public void ManualSelect()
		{
		}

		[Token(Token = "0x60055BE")]
		[Address(RVA = "0x143E5CC", Offset = "0x143E5CC", VA = "0x143E5CC")]
		public void ManualDeselect()
		{
		}

		[Token(Token = "0x60055BF")]
		[Address(RVA = "0x143EB08", Offset = "0x143EB08", VA = "0x143EB08")]
		private void Select(int selectedIndex = -1)
		{
		}

		[Token(Token = "0x60055C0")]
		[Address(RVA = "0x143F0FC", Offset = "0x143F0FC", VA = "0x143F0FC")]
		private void Deselect()
		{
		}

		[Token(Token = "0x60055C1")]
		[Address(RVA = "0x143F464", Offset = "0x143F464", VA = "0x143F464")]
		public void SetSelectedItem(ElementButtonGUI buttonGui)
		{
		}

		[Token(Token = "0x60055C2")]
		[Address(RVA = "0x143F530", Offset = "0x143F530", VA = "0x143F530")]
		public ElementsTabGUI()
		{
		}
	}
}
