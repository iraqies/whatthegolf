using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	internal struct GizmoData
	{
		public readonly GizmoType gizmoType;

		public readonly Vector3 position;

		public readonly Quaternion rotation;

		public readonly float scale;

		public readonly float circleThickness;

		public readonly float crossThickness;

		public readonly Color32 color;

		public GizmoData(GizmoType gizmoType, Vector3 position, Quaternion rotation, float scale, float circleThickness, float crossThickness, Color32 color)
		{
			this.gizmoType = GizmoType.Circle;
			this.position = default;
			this.rotation = default;
			this.scale = 0f;
			this.circleThickness = 0f;
			this.crossThickness = 0f;
			this.color = default;
		}
	}
}
