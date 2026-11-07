using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class ElementsTabGUI : MonoBehaviour
	{
		[SerializeField]
		private PersistentButton tabButton;

		[SerializeField]
		private ElementButtonGUI elementButtonGUIPrefab;

		[SerializeField]
		private SVGImage iconRenderer;

		private ElementsGUI m_Owner;

		private TextMeshProUGUI titleRenderer;

		private ScrollRect scroll;

		private GUIElementTabContent tabContent;

		private List<ElementButtonGUI> buttons;

		private LayoutGroup layoutGroup;

		[CompilerGenerated]
		private Action<ElementDefinition> m_OnElementSelected;

		private bool isSelected;

		private int m_SelectedButtonIndex;

		public event Action<ElementDefinition> OnElementSelected
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

		public void Init(ElementsGUI owner, GUIElementTabContent tabContent, LayoutGroup layoutGroup, ScrollRect scroll, TextMeshProUGUI tabTitleRenderer)
		{
		}

		private void OnDestroy()
		{
		}

		private void TabButton_OnSelected(PersistentButton button)
		{
		}

		private void TabButton_OnDeselected(PersistentButton button)
		{
		}

		private void ElementButton_OnSelected(ElementDefinition element, ElementButtonGUI buttonGui)
		{
		}

		public void ManualSelect(int selectedIndex = -1)
		{
		}

		public void ManualSelect()
		{
		}

		public void ManualDeselect()
		{
		}

		private void Select(int selectedIndex = -1)
		{
		}

		private void Deselect()
		{
		}

		public void SetSelectedItem(ElementButtonGUI buttonGui)
		{
		}
	}
}
