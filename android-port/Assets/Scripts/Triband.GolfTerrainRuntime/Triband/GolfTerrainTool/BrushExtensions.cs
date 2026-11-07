using UnityEngine;

namespace Triband.GolfTerrainTool
{
	public static class BrushExtensions
	{
		public static Vector3 GetScaleWS(this Brush brush)
		{
			return default;
		}

		public static Bounds GetBounds(this Brush brush, Matrix4x4 scalingMatrix)
		{
			return default;
		}

		public static float GetDistance(this Brush brush, Vector3 sourcePosition)
		{
			return 0f;
		}

		private static float GetCircleDistance(this Brush brush, Vector3 sourcePosition)
		{
			return 0f;
		}

		private static float GetRectangleDistance(this Brush brush, Vector3 sourcePosition)
		{
			return 0f;
		}
	}
}
