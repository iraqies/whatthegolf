using System;
using Il2CppDummyDll;
using Triband.GolfTerrainTool;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x20012A3")]
	public class BrushToolGUI : MonoBehaviour
	{
		[Token(Token = "0x4006497")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PersistentButton m_Button;

		[Token(Token = "0x4006498")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BrushSlider m_Slider;

		[Token(Token = "0x4006499")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform m_CircleContainer;

		[Token(Token = "0x400649A")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596EC", Offset = "0x596EC")]
		private Brush Brush__BackingField;

		[Token(Token = "0x400649B")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596FC", Offset = "0x596FC")]
		private Action m_OnBrushSelectedOrChanged;

		[Token(Token = "0x400649C")]
		private const float kMinBrushSize = 2f;

		[Token(Token = "0x400649D")]
		private const float kMaxBrushSize = 10f;

		[Token(Token = "0x400649E")]
		private const float kMinCircleScale = 0.5f;

		[Token(Token = "0x400649F")]
		private const float kMaxCircleScale = 1f;

		[Token(Token = "0x170009DF")]
		public Brush Brush
		{
			[Token(Token = "0x6005695")]
			[Address(RVA = "0x17097E4", Offset = "0x17097E4", VA = "0x17097E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71AF0", Offset = "0x71AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005696")]
			[Address(RVA = "0x17097EC", Offset = "0x17097EC", VA = "0x17097EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71B00", Offset = "0x71B00")]
			private set
			{
			}
		}

		[Token(Token = "0x170009E0")]
		public BrushSlider BrushSlider
		{
			[Token(Token = "0x6005697")]
			[Address(RVA = "0x17097F4", Offset = "0x17097F4", VA = "0x17097F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000098")]
		public event Action OnBrushSelectedOrChanged
		{
			[Token(Token = "0x6005698")]
			[Address(RVA = "0x17097FC", Offset = "0x17097FC", VA = "0x17097FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71B10", Offset = "0x71B10")]
			add
			{
			}
			[Token(Token = "0x6005699")]
			[Address(RVA = "0x17098A0", Offset = "0x17098A0", VA = "0x17098A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71B20", Offset = "0x71B20")]
			remove
			{
			}
		}

		[Token(Token = "0x600569A")]
		[Address(RVA = "0x1709944", Offset = "0x1709944", VA = "0x1709944")]
		private void Awake()
		{
		}

		[Token(Token = "0x600569B")]
		[Address(RVA = "0x1709C0C", Offset = "0x1709C0C", VA = "0x1709C0C")]
		private void ResetSlider()
		{
		}

		[Token(Token = "0x600569C")]
		[Address(RVA = "0x1709D90", Offset = "0x1709D90", VA = "0x1709D90")]
		private void OnSliderSelected(BaseEventData obj)
		{
		}

		[Token(Token = "0x600569D")]
		[Address(RVA = "0x1709E88", Offset = "0x1709E88", VA = "0x1709E88")]
		private void OnButtonClick(PersistentButton _button)
		{
		}

		[Token(Token = "0x600569E")]
		[Address(RVA = "0x1709C64", Offset = "0x1709C64", VA = "0x1709C64")]
		private void OnSliderChanged(float t)
		{
		}

		[Token(Token = "0x600569F")]
		[Address(RVA = "0x1709E18", Offset = "0x1709E18", VA = "0x1709E18")]
		private void SendSetBrushEvent()
		{
		}

		[Token(Token = "0x60056A0")]
		[Address(RVA = "0x1709EF8", Offset = "0x1709EF8", VA = "0x1709EF8")]
		public BrushToolGUI()
		{
		}
	}
}
