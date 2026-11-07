using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public sealed class GridManager : BaseManager, IRequireEvents<GameStateEvent>, IRequireEvents, IRequireRender
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		private struct ShaderID
		{
			public static readonly int GridColor;
		}

		private const float kPlaneScale = 0.1f;

		[SerializeField]
		private Material m_Material;

		[SerializeField]
		private float m_GridSize;

		private bool m_Initialized;

		private bool m_GridState;

		private Mesh m_Mesh;

		private Matrix4x4 m_Matrix;

		private Material m_MaterialInstance;

		private Color m_GridColor;

		private Color m_FadeColor;

		public override void Init()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		public void QueueDraws(bool isScreenshot)
		{
		}

		private IEnumerator TransitionGrid(bool state, float transitionTime)
		{
			return null;
		}

		private void SetGridColor(bool target, float t)
		{
		}
	}
}
