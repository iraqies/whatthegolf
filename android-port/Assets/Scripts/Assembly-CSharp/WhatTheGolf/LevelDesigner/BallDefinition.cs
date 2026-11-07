using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public sealed class BallDefinition : SelectableDefinition
	{
		[SerializeField]
		private BaseCameraController m_OverrideCameraPrefab;

		public BaseCameraController overrideCameraPrefab => null;
	}
}
