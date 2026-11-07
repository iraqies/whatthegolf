using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class FileGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents
	{
		private SerializableLevelData[] levelDatas;

		[SerializeField]
		private LevelFileGUI levelFileGUIPrefab;

		[SerializeField]
		private LayoutGroup contentLayoutGroup;

		[SerializeField]
		private ScrollRect scroll;

		[SerializeField]
		private Sprite newLevelActionIcon;

		[SerializeField]
		private Sprite editLevelActionIcon;

		[SerializeField]
		private Button closeButton;

		private List<LevelFileGUI> levelFileGUIButtons;

		[SerializeField]
		private LevelFileGUI newLevelFileGUI;

		[SerializeField]
		private ButtonStateColors currentLevelHoverColors;

		[SerializeField]
		private ButtonStateColors defaultHoverColors;

		private bool m_IsVisible;

		private SerializableLevelData cachedLevel;

		public override bool isActiveOnOpen => false;

		public override void Init()
		{
		}

		private void CloseButton_OnSelected()
		{
		}

		private void LevelFileGUI_OnViewSelected(SerializableLevelData levelData)
		{
		}

		private void LevelFileGUI_OnActionSelected(SerializableLevelData levelData)
		{
		}

		private void LoadCachedLevel()
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void ClearAndDisable()
		{
		}
	}
}
