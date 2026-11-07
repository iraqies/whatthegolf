using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public struct MathPlane
	{
		private Vector3 normal;

		private Vector3 origin;

		private float distance;

		public Vector3 Normal => default;

		public Vector3 Origin => default;

		public MathPlane(Vector3 inNormal, Vector3 inPoint)
		{
			normal = default;
			origin = default;
			distance = 0f;
		}

		public float StretchFactor(Ray ray)
		{
			return 0f;
		}

		internal static bool FloatEquals(float a, float b)
		{
			return false;
		}
	}
}
