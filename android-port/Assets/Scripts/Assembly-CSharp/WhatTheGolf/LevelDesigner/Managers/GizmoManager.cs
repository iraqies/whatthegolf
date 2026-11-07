using System.Collections.Generic;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public sealed class GizmoManager : BaseManager, IRequireEvents<GameStateEvent>, IRequireEvents, IRequireRender
	{
		private const float kPlaneScale = 0.1f;

		[SerializeField]
		private GizmoMaterial[] m_Materials;

		private bool m_IsActive;

		private bool m_Initialized;

		private Mesh m_Mesh;

		private Dictionary<GizmoType, Material> m_MaterialInstances;

		private Stack<GizmoData> m_GizmoStack;

		public override void Init()
		{
		}

		private void InitMaterialInstances()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		public void QueueDraws(bool isScreenshot)
		{
		}

		private void TrySetProperty<T>(Material material, string name, T value)
		{
		}

		public void QueueCircleGizmo(Vector3 position, Quaternion rotation, float scale, Color32 color)
		{
		}

		public void QueueCrossGizmo(Vector3 position, Quaternion rotation, float scale, Color32 color)
		{
		}

		public void QueueRotationGizmo(Vector3 position, Quaternion rotation, float scale, Color32 color)
		{
		}

		public void QueueDirectionIndicatorGizmo(Vector3 position, Quaternion rotation, float scale, float offset, Color32 color)
		{
		}

		private float GetSignedAngle(Quaternion A, Quaternion B, Vector3 axis)
		{
			return 0f;
		}
	}
}
