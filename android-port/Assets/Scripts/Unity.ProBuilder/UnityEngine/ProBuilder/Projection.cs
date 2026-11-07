using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	public static class Projection
	{
		internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings)
		{
		}

		internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection = default(Vector3))
		{
		}

		internal static Vector3 GetTangentToAxis(ProjectionAxis axis)
		{
			return default;
		}

		internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction)
		{
			return ProjectionAxis.X;
		}

		public static Plane FindBestPlane(IList<Vector3> points, IList<int> indexes = null)
		{
			return default;
		}
	}
}
