using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x20012A0")]
	public class PersistentButton : Selectable
	{
		[Serializable]
		[Token(Token = "0x20012A1")]
		private class GraphicToolButtonColorsPair
		{
			[Token(Token = "0x4006493")]
			[FieldOffset(Offset = "0x10")]
			public Graphic graphic;

			[Token(Token = "0x4006494")]
			[FieldOffset(Offset = "0x18")]
			public ToolButtonColors colors;

			[Token(Token = "0x600568C")]
			[Address(RVA = "0x1823A44", Offset = "0x1823A44", VA = "0x1823A44")]
			public GraphicToolButtonColorsPair()
			{
			}
		}

		[Token(Token = "0x400648C")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private new ToolButtonColors colors;

		[Token(Token = "0x400648D")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private ButtonGroupType buttonGroup;

		[Token(Token = "0x400648E")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<GraphicToolButtonColorsPair> additionalGraphics;

		[Token(Token = "0x400648F")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5965C", Offset = "0x5965C")]
		private bool IsSelected__BackingField;

		[Token(Token = "0x4006490")]
		[FieldOffset(Offset = "0x111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5966C", Offset = "0x5966C")]
		private bool IsHovering__BackingField;

		[Token(Token = "0x4006491")]
		[FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5967C", Offset = "0x5967C")]
		private Action<PersistentButton> m_OnSelected;

		[Token(Token = "0x4006492")]
		[FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5968C", Offset = "0x5968C")]
		private Action<PersistentButton> m_OnDeselected;

		[Token(Token = "0x170009D9")]
		public ToolButtonColors Colors
		{
			[Token(Token = "0x6005678")]
			[Address(RVA = "0x15DECEC", Offset = "0x15DECEC", VA = "0x15DECEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005679")]
			[Address(RVA = "0x15DECF4", Offset = "0x15DECF4", VA = "0x15DECF4")]
			set
			{
			}
		}

		[Token(Token = "0x170009DA")]
		public bool IsSelected
		{
			[Token(Token = "0x600567A")]
			[Address(RVA = "0x15DECFC", Offset = "0x15DECFC", VA = "0x15DECFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71A30", Offset = "0x71A30")]
			get
			{
				return default;
			}
			[Token(Token = "0x600567B")]
			[Address(RVA = "0x15DED04", Offset = "0x15DED04", VA = "0x15DED04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71A40", Offset = "0x71A40")]
			set
			{
			}
		}

		[Token(Token = "0x170009DB")]
		public bool IsHovering
		{
			[Token(Token = "0x600567C")]
			[Address(RVA = "0x15DED0C", Offset = "0x15DED0C", VA = "0x15DED0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71A50", Offset = "0x71A50")]
			get
			{
				return default;
			}
			[Token(Token = "0x600567D")]
			[Address(RVA = "0x15DED14", Offset = "0x15DED14", VA = "0x15DED14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71A60", Offset = "0x71A60")]
			set
			{
			}
		}

		[Token(Token = "0x170009DC")]
		public ButtonGroupType ButtonGroup
		{
			[Token(Token = "0x600567E")]
			[Address(RVA = "0x15DED1C", Offset = "0x15DED1C", VA = "0x15DED1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000096")]
		public event Action<PersistentButton> OnSelected
		{
			[Token(Token = "0x600567F")]
			[Address(RVA = "0x15DED24", Offset = "0x15DED24", VA = "0x15DED24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71A70", Offset = "0x71A70")]
			add
			{
			}
			[Token(Token = "0x6005680")]
			[Address(RVA = "0x15DEDC8", Offset = "0x15DEDC8", VA = "0x15DEDC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71A80", Offset = "0x71A80")]
			remove
			{
			}
		}

		[Token(Token = "0x14000097")]
		public event Action<PersistentButton> OnDeselected
		{
			[Token(Token = "0x6005681")]
			[Address(RVA = "0x15DEE6C", Offset = "0x15DEE6C", VA = "0x15DEE6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71A90", Offset = "0x71A90")]
			add
			{
			}
			[Token(Token = "0x6005682")]
			[Address(RVA = "0x15DEF10", Offset = "0x15DEF10", VA = "0x15DEF10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71AA0", Offset = "0x71AA0")]
			remove
			{
			}
		}

		[Token(Token = "0x6005683")]
		[Address(RVA = "0x15DEFB4", Offset = "0x15DEFB4", VA = "0x15DEFB4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6005684")]
		[Address(RVA = "0x15DF358", Offset = "0x15DF358", VA = "0x15DF358", Slot = "36")]
		public override void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6005685")]
		[Address(RVA = "0x15DF3D8", Offset = "0x15DF3D8", VA = "0x15DF3D8", Slot = "37")]
		public override void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6005686")]
		[Address(RVA = "0x15DF3DC", Offset = "0x15DF3DC", VA = "0x15DF3DC", Slot = "34")]
		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005687")]
		[Address(RVA = "0x15DF468", Offset = "0x15DF468", VA = "0x15DF468", Slot = "35")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005688")]
		[Address(RVA = "0x15DF470", Offset = "0x15DF470", VA = "0x15DF470")]
		public void ManualDeselect()
		{
		}

		[Token(Token = "0x6005689")]
		[Address(RVA = "0x15DF4DC", Offset = "0x15DF4DC", VA = "0x15DF4DC")]
		public void ManualSelect()
		{
		}

		[Token(Token = "0x600568A")]
		[Address(RVA = "0x15DEFF8", Offset = "0x15DEFF8", VA = "0x15DEFF8")]
		private void SetColorFromState()
		{
		}

		[Token(Token = "0x600568B")]
		[Address(RVA = "0x15DF540", Offset = "0x15DF540", VA = "0x15DF540")]
		public PersistentButton()
		{
		}
	}
}
