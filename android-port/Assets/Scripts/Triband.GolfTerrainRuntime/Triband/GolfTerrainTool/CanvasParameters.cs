using System;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	public sealed class CanvasParameters : ScriptableObject
	{
		[SerializeField]
		private int m_Width;

		[SerializeField]
		private int m_Height;

		[SerializeField]
		private int m_Density;

		[SerializeField]
		private bool m_DensityChanged;

		[SerializeField]
		private int m_TempDensity;

		public int width
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int height
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int density
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool densityChanged
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int tempDensity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float scaleX => 0f;

		public float scaleY => 0f;

		public float invScaleX => 0f;

		public float invScaleY => 0f;

		public int pointCount => 0;

		public Matrix4x4 fieldToLocalMatrix => default;

		public Matrix4x4 localToFieldMatrix => default;
	}
}
