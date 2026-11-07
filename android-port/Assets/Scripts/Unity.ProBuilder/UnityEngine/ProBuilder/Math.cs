using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	public static class Math
	{
		internal static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			return default;
		}

		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			return default;
		}

		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default;
		}

		public static Vector3 Normal(ProBuilderMesh mesh, Face face)
		{
			return default;
		}

		internal static Vector2 SmallestVector2(Vector2[] v, IList<int> indexes)
		{
			return default;
		}

		internal static Vector2 LargestVector2(Vector2[] v, IList<int> indexes)
		{
			return default;
		}

		internal static bool Approx2(this Vector2 a, Vector2 b, float delta = 0.0001f)
		{
			return false;
		}

		internal static bool Approx3(this Vector3 a, Vector3 b, float delta = 0.0001f)
		{
			return false;
		}

		internal static bool Approx4(this Vector4 a, Vector4 b, float delta = 0.0001f)
		{
			return false;
		}

		internal static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			return false;
		}

		internal static bool Approx(this float a, float b, float delta = 0.0001f)
		{
			return false;
		}

		public static int Clamp(int value, int lowerBound, int upperBound)
		{
			return 0;
		}

		internal static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}
	}
}
