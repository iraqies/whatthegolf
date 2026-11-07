using UnityEngine;

namespace Triband.GolfTerrainTool
{
	public sealed class Brush : ScriptableObject
	{
		[SerializeField]
		private BrushShape m_Shape;

		[SerializeField]
		private float m_Size;

		[SerializeField]
		private float m_Round;

		[SerializeField]
		private float m_AspectRatio;

		[SerializeField]
		private float m_Rotation;

		public BrushShape shape
		{
			get
			{
				return BrushShape.Ellipse;
			}
			set
			{
			}
		}

		public float size
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float round
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float aspectRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotation
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
