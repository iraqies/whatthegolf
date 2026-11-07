using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class ToolGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[SerializeField]
		private PersistentButton m_SelectionToolButton;

		[SerializeField]
		private BrushToolGUI m_PaintToolButton;

		[SerializeField]
		private BrushToolGUI m_EraseToolButton;

		[SerializeField]
		private Button m_UndoButton;

		[SerializeField]
		private Button m_RedoButton;

		public override bool isActiveOnOpen => false;

		public override bool hasFocus => false;

		private bool isDraggingSlider => false;

		public override void Init()
		{
		}

		private void Update()
		{
		}

		private void OnSelectionToolSelected(PersistentButton obj)
		{
		}

		private void OnPaintToolChanged()
		{
		}

		private void OnEraseToolChanged()
		{
		}

		private void OnUndoClicked()
		{
		}

		private void OnRedoClicked()
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

		public void OnEvent(GameStateEvent evt)
		{
		}
	}
}
