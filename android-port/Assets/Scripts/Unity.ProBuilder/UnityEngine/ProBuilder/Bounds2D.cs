using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	internal sealed class Bounds2D
	{
		public Vector2 center;

		[SerializeField]
		private Vector2 m_Size;

		[SerializeField]
		private Vector2 m_Extents;

		public Vector2 size => default;

		public void SetWithPoints(IList<Vector2> points, IList<int> indexes)
		{
		}

		public static Vector2 Center(IList<Vector2> points, IList<int> indexes)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
