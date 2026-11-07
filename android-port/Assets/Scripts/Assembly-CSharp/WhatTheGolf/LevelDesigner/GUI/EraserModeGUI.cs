using TMPro;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class EraserModeGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[SerializeField]
		private PersistentButton terrainButton;

		[SerializeField]
		private PersistentButton selectablesButton;

		[SerializeField]
		private TextMeshProUGUI terrainText;

		[SerializeField]
		private TextMeshProUGUI selectablesText;

		private bool m_IsVisible;

		private bool isTerrainMode;

		public override bool isActiveOnOpen => false;

		public override void Init()
		{
		}

		private void TerrainButton_OnSelected(PersistentButton obj)
		{
		}

		private void SelectablesButton_OnSelected(PersistentButton obj)
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		private void Show()
		{
		}

		private void Hide()
		{
		}

		private void DisableCanvas()
		{
		}
	}
}
