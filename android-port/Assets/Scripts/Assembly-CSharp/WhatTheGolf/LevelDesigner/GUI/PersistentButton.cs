using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class PersistentButton : Selectable
	{
		[Serializable]
		private class GraphicToolButtonColorsPair
		{
			public Graphic graphic;

			public ToolButtonColors colors;
		}

		[SerializeField]
		private new ToolButtonColors colors;

		[SerializeField]
		private ButtonGroupType buttonGroup;

		[SerializeField]
		private List<GraphicToolButtonColorsPair> additionalGraphics;

		[CompilerGenerated]
		private Action<PersistentButton> m_OnSelected;

		[CompilerGenerated]
		private Action<PersistentButton> m_OnDeselected;

		public ToolButtonColors Colors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsSelected { get; set; }

		public bool IsHovering { get; set; }

		public ButtonGroupType ButtonGroup => ButtonGroupType.Tools;

		public event Action<PersistentButton> OnSelected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PersistentButton> OnDeselected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Start()
		{
		}

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public override void OnDeselect(BaseEventData eventData)
		{
		}

		public override void OnPointerEnter(PointerEventData eventData)
		{
		}

		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		public void ManualDeselect()
		{
		}

		public void ManualSelect()
		{
		}

		private void SetColorFromState()
		{
		}
	}
}
