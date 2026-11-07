using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;

namespace WhatTheGolf.LevelDesigner.Tools
{
	public class PaintSelectableTool : BaseTool, IRequireEvents<GUIEvent>, IRequireEvents
	{
		private SelectableManager m_SelectableManager;

		private CameraManager m_CameraManager;

		private GizmoManager m_GizmoManager;

		private float m_BrushSize;

		private SelectableDefinition m_Element;

		private float m_IntervalTimer;

		private float m_PaintStartTime;

		private float m_LastEraseObjectAudioTime;

		private bool m_IsPainting;

		private bool m_IsEraser;

		private Vector3 m_LastPosition;

		private Color32 m_Color;

		private SelectableManager selectableManager => null;

		private CameraManager cameraManager => null;

		private GizmoManager gizmoManager => null;

		public override void Init()
		{
		}

		public override void Update(bool guiHasFocus)
		{
		}

		public override void Dispose()
		{
		}

		private void DeleleteSelectablesWithinBrushArea(Vector3 center, float radius)
		{
		}

		private float PlacementInterval(float paintStartElapsed, float initialPlacementInterval, float minPlacementInterval)
		{
			return 0f;
		}

		public void OnEvent(GUIEvent evt)
		{
		}
	}
}
