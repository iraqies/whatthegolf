using System;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	public struct AutoUnwrapSettings
	{
		public enum Anchor
		{
			UpperLeft = 0,
			UpperCenter = 1,
			UpperRight = 2,
			MiddleLeft = 3,
			MiddleCenter = 4,
			MiddleRight = 5,
			LowerLeft = 6,
			LowerCenter = 7,
			LowerRight = 8,
			None = 9
		}

		public enum Fill
		{
			Fit = 0,
			Tile = 1,
			Stretch = 2
		}

		[SerializeField]
		private bool m_UseWorldSpace;

		[SerializeField]
		private bool m_FlipU;

		[SerializeField]
		private bool m_FlipV;

		[SerializeField]
		private bool m_SwapUV;

		[SerializeField]
		private Fill m_Fill;

		[SerializeField]
		private Vector2 m_Scale;

		[SerializeField]
		private Vector2 m_Offset;

		[SerializeField]
		private float m_Rotation;

		[SerializeField]
		private Anchor m_Anchor;

		public bool useWorldSpace => false;

		public bool flipU => false;

		public bool flipV => false;

		public bool swapUV => false;

		public Fill fill => Fill.Fit;

		public Vector2 scale => default;

		public Vector2 offset => default;

		public float rotation => 0f;

		public Anchor anchor => Anchor.UpperLeft;

		public static AutoUnwrapSettings tile => default;

		public AutoUnwrapSettings(AutoUnwrapSettings unwrapSettings)
		{
			m_UseWorldSpace = false;
			m_FlipU = false;
			m_FlipV = false;
			m_SwapUV = false;
			m_Fill = Fill.Fit;
			m_Scale = default;
			m_Offset = default;
			m_Rotation = 0f;
			m_Anchor = Anchor.UpperLeft;
		}

		public void Reset()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
