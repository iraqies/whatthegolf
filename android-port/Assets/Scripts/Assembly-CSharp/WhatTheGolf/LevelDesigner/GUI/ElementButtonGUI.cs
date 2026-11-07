using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class ElementButtonGUI : MonoBehaviour
	{
		private ElementDefinition element;

		[SerializeField]
		private PersistentButton button;

		[SerializeField]
		private SVGImage iconRenderer;

		[CompilerGenerated]
		private Action<ElementDefinition, ElementButtonGUI> m_OnSelected;

		[CompilerGenerated]
		private Action<ElementDefinition> m_OnDeselected;

		private bool subscribed;

		public event Action<ElementDefinition, ElementButtonGUI> OnSelected
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

		public event Action<ElementDefinition> OnDeselected
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

		public void Init(ElementDefinition element)
		{
		}

		public void ManualSelect()
		{
		}

		public void ManualDeselect()
		{
		}

		private void Button_OnSelected(PersistentButton button)
		{
		}

		private void Button_OnDeselected(PersistentButton obj)
		{
		}
	}
}
