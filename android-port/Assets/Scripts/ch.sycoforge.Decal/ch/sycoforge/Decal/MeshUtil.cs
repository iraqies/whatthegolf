using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public static class MeshUtil
	{
		private static List<Vector4> tangentsTemp;

		private static Mesh cubeMesh24;

		private static Vector3[] cubeVertices24;

		private static Vector3[] cubeNormals24;

		private static int[] cubeTriangles24;

		public static List<int> AdjacentIndices(IList<Vector3> vertices, IList<int> triangles, int index)
		{
			return null;
		}

		internal static IList<Vector4> CalculateTangents(IList<Vector3> vertices, IList<Vector3> normals, IList<Vector2> uv, IList<int> triangles)
		{
			return null;
		}

		internal static void CalculateNormals(IList<Vector3> normals, IList<Vector3> vertices, IList<int> triangles, float factor = 1f)
		{
		}

		internal static void SmoothVertexNormals(IList<Vector3> normals, Vector3 inverseProjectionDir, float factor, float threshold)
		{
		}

		internal static float FaceFactor(Vector3 normal, Vector3 inverseProjectionDir)
		{
			return 0f;
		}

		internal static Mesh MeshFromBoxCollider24(BoxCollider collider)
		{
			return null;
		}
	}
}
