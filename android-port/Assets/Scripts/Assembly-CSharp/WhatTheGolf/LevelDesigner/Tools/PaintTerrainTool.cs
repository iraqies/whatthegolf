using System.Collections;
using Triband.GolfTerrainTool;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;
using WhatTheGolf.LevelDesigner.Managers;

namespace WhatTheGolf.LevelDesigner.Tools
{
	public class PaintTerrainTool : BaseTool, IRequireEvents<GUIEvent>, IRequireEvents
	{
		private TerrainManager m_TerrainManager;

		private CameraManager m_CameraManager;

		private GizmoManager m_GizmoManager;

		private Brush m_Brush;

		private int m_LayerIndex;

		private bool m_IsEraser;

		private bool m_IsPainting;

		private Vector3 m_LastPosition;

		private IEnumerator m_StartupCoroutine;

		private float m_BrushStartupTime;

		private float m_BrushStartupTimer;

		private Color32 m_Color;

		private TerrainManager terrainManager => null;

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

		private IEnumerator BrushStartupProcess()
		{
			return null;
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		private bool HasPaintInput()
		{
			return false;
		}
	}
}
