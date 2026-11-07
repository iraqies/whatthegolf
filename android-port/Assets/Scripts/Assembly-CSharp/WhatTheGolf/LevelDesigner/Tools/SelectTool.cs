using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;
using WhatTheGolf.LevelDesigner.Selectables;

namespace WhatTheGolf.LevelDesigner.Tools
{
	public sealed class SelectTool : BaseTool, IRequireEvents<GUIEvent>, IRequireEvents
	{
		private SelectableManager m_SelectableManager;

		private GizmoManager m_GizmoManager;

		private Bounds m_SelectGizmoBounds;

		private Bounds m_RotateGizmoBounds;

		private Vector2 m_SelectionOffset;

		private Vector2 m_RotateSelectionOffset;

		private bool m_TranslationGizmoSelected;

		private bool m_RotationGizmoSelected;

		private bool m_LastHoverRotateGizmoState;

		private Selectable m_LastSelectableHit;

		private Color32 m_SelectedColor;

		private Color32 m_HighlightColor;

		private SelectableManager selectableManager => null;

		private GizmoManager gizmoManager => null;

		public override void Init()
		{
		}

		public override void Update(bool guiHasFocus)
		{
		}

		private void DrawGizmos(Selectable selectable, bool hitTranslateGizmo, bool hitRotateGizmo)
		{
		}

		public override void Dispose()
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		private bool TestSelection(out Selectable selectable)
		{
			selectable = null;
			return false;
		}

		private bool TestSelectRotate()
		{
			return false;
		}

		private void RotateSelection()
		{
		}

		private void MoveSelection()
		{
		}

		private void QueueCircleGizmoForSelectable(Selectable selectable, Color32 color)
		{
		}

		private void QueueCrossGizmoForSelectable(Selectable selectable, Color32 color)
		{
		}

		private void QueueRotationGizmoForSelectable(Selectable selectable, Color32 color)
		{
		}
	}
}
