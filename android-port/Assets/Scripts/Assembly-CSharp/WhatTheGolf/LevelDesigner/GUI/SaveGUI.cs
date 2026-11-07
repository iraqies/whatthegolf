using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class SaveGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents
	{
		[SerializeField]
		private LevelCoverButtonGUI levelCoverButtonGUI;

		[SerializeField]
		private Button saveButton;

		[SerializeField]
		private GameObject publishedLabel;

		[SerializeField]
		private Button saveAsButton;

		[SerializeField]
		private Button closeButton;

		[SerializeField]
		private Button optionsButton;

		[SerializeField]
		private Sprite actionIcon;

		[SerializeField]
		private TextMeshProUGUI levelName;

		[SerializeField]
		private TextMeshProUGUI description;

		private SerializableLevelData levelData;

		private bool m_IsVisible;

		public override bool isActiveOnOpen => false;

		public override void Init()
		{
		}

		private void CloseButton_OnSelected()
		{
		}

		private void LevelCoverButtonGUI_OnSelected(SerializableLevelData obj)
		{
		}

		private void Save()
		{
		}

		private void SaveNew()
		{
		}

		private void SaveAs()
		{
		}

		private void OpenLevelOptions()
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

		private void Disable()
		{
		}
	}
}
