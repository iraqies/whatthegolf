using System;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	public sealed class MeshParameters : ScriptableObject
	{
		[SerializeField]
		private float m_BevelWidth;

		[SerializeField]
		private float m_BevelAngle;

		[SerializeField]
		private float m_SkirtExtent;

		[SerializeField]
		private float m_SkirtAngle;

		public float bevelWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float bevelAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float skirtExtent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float skirtAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
