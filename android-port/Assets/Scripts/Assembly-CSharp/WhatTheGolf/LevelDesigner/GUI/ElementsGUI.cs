using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class ElementsGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[SerializeField]
		private List<GUIElementTabContent> tabContentData;

		[SerializeField]
		private ElementsTabGUI elementsTabGUIPrefab;

		[SerializeField]
		private LayoutGroup tabLayoutGroup;

		[SerializeField]
		private LayoutGroup tabContentLayoutGroup;

		[SerializeField]
		private ScrollRect scroll;

		[SerializeField]
		private TextMeshProUGUI tabTitleRenderer;

		[SerializeField]
		private TextMeshProUGUI panelPaintTitleRenderer;

		[SerializeField]
		private TextMeshProUGUI panelSelectTitleRenderer;

		private List<ElementsTabGUI> elementTabs;

		private int m_SelectedTabIndex;

		private bool m_IsVisible;

		private bool m_IsSelectMode;

		public override bool isActiveOnOpen => false;

		public override void Init()
		{
		}

		private void TabGUI_OnElementSelected(ElementDefinition element)
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		private void ShowForSelect(int elementId)
		{
		}

		private void ShowForPaint()
		{
		}

		private void Hide()
		{
		}

		private void DisableCanvas()
		{
		}

		public void SetSelectedTab(ElementsTabGUI tabGui)
		{
		}

		public int GetSelectedTabElementIndex(ElementsTabGUI tab, int currentSelection)
		{
			return 0;
		}

		private List<ElementDefinition> GetElementsOfGUIElementType(GUIElementType value)
		{
			return null;
		}
	}
}
