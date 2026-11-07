using System.Collections.Generic;
using UnityEngine;

namespace Triband.MountainGeneratorTool
{
	[ExecuteAlways]
	public sealed class MountainGenerator : MonoBehaviour
	{
		public MountainSettings Settings;

		public bool LockHeight;

		public List<Vector3> Points;

		[SerializeField]
		private List<Transform> pointTransforms;

		private Mesh mesh;

		private Material[] materials;

		private Material pointMaterial;

		private MeshFilter m_Filter;

		private MeshRenderer m_Renderer;

		private MeshCollider m_Collider;

		private const string kPointName = "point";

		private const string kPointShaderName = "PointShader";

		internal MeshFilter filter => null;

		internal MeshRenderer renderer => null;

		internal MeshCollider collider => null;

		private void Update()
		{
		}

		private static Vector3 Bezier(Vector3 start, Vector3 control, Vector3 end, float t)
		{
			return default;
		}

		public void BuildMountain()
		{
		}

		public void AddPoint(Vector3 pos, bool rebuild = true)
		{
		}

		public void InsertPoint(int index, Vector3 pos, bool rebuild = true)
		{
		}

		public void RemovePoint(int index, bool rebuild = true)
		{
		}

		public void MovePoint(int index, Vector3 pos)
		{
		}

		private void CheckTransformList()
		{
		}

		private Transform CreatePointTransform(Vector3 pos)
		{
			return null;
		}

		private void AddBevels(List<Vector3> vertices, List<Vector3> normals, List<List<int>> triangles)
		{
		}

		private static float CalculateSlope(float height, float size)
		{
			return 0f;
		}

		private static void AddSide(IReadOnlyList<Vector3> top, IReadOnlyList<Vector3> bottom, List<Vector3> vertices, List<List<int>> triangles)
		{
		}

		private static List<int> CreateTriangles(int startOffset, int pointCount)
		{
			return null;
		}

		private static List<Vector3> CalculateNormals(IReadOnlyList<Vector3> vertices, float slope)
		{
			return null;
		}

		private static List<Vector3> CreateSideVertices(IReadOnlyList<Vector3> fromPolygon, float height, float size)
		{
			return null;
		}

		private static bool ContainsPoint(IReadOnlyList<Vector2> polyPoints, Vector2 p)
		{
			return false;
		}
	}
}
