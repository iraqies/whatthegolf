using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public sealed class SkyManager : BaseManager, IRequireRender
	{
		[SerializeField]
		private Material m_Material;

		[SerializeField]
		private GameObject cloudPrefab;

		private bool m_Initialized;

		private Mesh m_Mesh;

		private Matrix4x4 m_Matrix;

		public override void Init()
		{
		}

		public void QueueDraws(bool isScreenshot)
		{
		}
	}
}
