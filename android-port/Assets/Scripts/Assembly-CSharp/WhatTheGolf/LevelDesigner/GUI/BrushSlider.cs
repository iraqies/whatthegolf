using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x20012A2")]
	public class BrushSlider : Slider
	{
		[Token(Token = "0x4006495")]
		[FieldOffset(Offset = "0x160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5969C", Offset = "0x5969C")]
		private Action<BaseEventData> onSliderSelected__BackingField;

		[Token(Token = "0x4006496")]
		[FieldOffset(Offset = "0x168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x596AC", Offset = "0x596AC")]
		private bool IsDragging__BackingField;

		[Token(Token = "0x170009DD")]
		public Action<BaseEventData> onSliderSelected
		{
			[Token(Token = "0x600568D")]
			[Address(RVA = "0x1709730", Offset = "0x1709730", VA = "0x1709730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71AB0", Offset = "0x71AB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600568E")]
			[Address(RVA = "0x1709738", Offset = "0x1709738", VA = "0x1709738")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71AC0", Offset = "0x71AC0")]
			set
			{
			}
		}

		[Token(Token = "0x170009DE")]
		public bool IsDragging
		{
			[Token(Token = "0x600568F")]
			[Address(RVA = "0x1709740", Offset = "0x1709740", VA = "0x1709740")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71AD0", Offset = "0x71AD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005690")]
			[Address(RVA = "0x1709748", Offset = "0x1709748", VA = "0x1709748")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71AE0", Offset = "0x71AE0")]
			private set
			{
			}
		}

		[Token(Token = "0x6005691")]
		[Address(RVA = "0x1709750", Offset = "0x1709750", VA = "0x1709750", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6005692")]
		[Address(RVA = "0x17097C0", Offset = "0x17097C0", VA = "0x17097C0", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005693")]
		[Address(RVA = "0x17097D0", Offset = "0x17097D0", VA = "0x17097D0", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005694")]
		[Address(RVA = "0x17097DC", Offset = "0x17097DC", VA = "0x17097DC")]
		public BrushSlider()
		{
		}
	}
}
