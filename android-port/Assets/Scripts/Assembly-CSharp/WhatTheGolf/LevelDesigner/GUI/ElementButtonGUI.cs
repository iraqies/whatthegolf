using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001286")]
	public class ElementButtonGUI : MonoBehaviour
	{
		[Token(Token = "0x400638C")]
		[FieldOffset(Offset = "0x18")]
		private ElementDefinition element;

		[Token(Token = "0x400638D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PersistentButton button;

		[Token(Token = "0x400638E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SVGImage iconRenderer;

		[Token(Token = "0x400638F")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C4C", Offset = "0x58C4C")]
		private Action<ElementDefinition, ElementButtonGUI> m_OnSelected;

		[Token(Token = "0x4006390")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58C5C", Offset = "0x58C5C")]
		private Action<ElementDefinition> m_OnDeselected;

		[Token(Token = "0x4006391")]
		[FieldOffset(Offset = "0x40")]
		private bool subscribed;

		[Token(Token = "0x14000090")]
		public event Action<ElementDefinition, ElementButtonGUI> OnSelected
		{
			[Token(Token = "0x600559E")]
			[Address(RVA = "0x143C960", Offset = "0x143C960", VA = "0x143C960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x718C0", Offset = "0x718C0")]
			add
			{
			}
			[Token(Token = "0x600559F")]
			[Address(RVA = "0x143CA04", Offset = "0x143CA04", VA = "0x143CA04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x718D0", Offset = "0x718D0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000091")]
		public event Action<ElementDefinition> OnDeselected
		{
			[Token(Token = "0x60055A0")]
			[Address(RVA = "0x143CAA8", Offset = "0x143CAA8", VA = "0x143CAA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x718E0", Offset = "0x718E0")]
			add
			{
			}
			[Token(Token = "0x60055A1")]
			[Address(RVA = "0x143CB4C", Offset = "0x143CB4C", VA = "0x143CB4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x718F0", Offset = "0x718F0")]
			remove
			{
			}
		}

		[Token(Token = "0x60055A2")]
		[Address(RVA = "0x143CBF0", Offset = "0x143CBF0", VA = "0x143CBF0")]
		public void Init(ElementDefinition element)
		{
		}

		[Token(Token = "0x60055A3")]
		[Address(RVA = "0x143CD68", Offset = "0x143CD68", VA = "0x143CD68")]
		public void ManualSelect()
		{
		}

		[Token(Token = "0x60055A4")]
		[Address(RVA = "0x143CD84", Offset = "0x143CD84", VA = "0x143CD84")]
		public void ManualDeselect()
		{
		}

		[Token(Token = "0x60055A5")]
		[Address(RVA = "0x143CDA0", Offset = "0x143CDA0", VA = "0x143CDA0")]
		private void Button_OnSelected(PersistentButton button)
		{
		}

		[Token(Token = "0x60055A6")]
		[Address(RVA = "0x143CE04", Offset = "0x143CE04", VA = "0x143CE04")]
		private void Button_OnDeselected(PersistentButton obj)
		{
		}

		[Token(Token = "0x60055A7")]
		[Address(RVA = "0x143CE64", Offset = "0x143CE64", VA = "0x143CE64")]
		public ElementButtonGUI()
		{
		}
	}
}
