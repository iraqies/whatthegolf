using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Serializable]
	public struct GizmoMaterial
	{
		[SerializeField]
		public GizmoType gizmoType;

		[SerializeField]
		public Material material;
	}
}
