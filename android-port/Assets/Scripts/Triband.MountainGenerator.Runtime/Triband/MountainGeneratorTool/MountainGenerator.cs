using System.Collections.Generic;
using System.Linq;
using Triband.Core.GeometryUtils;
using UnityEngine;

namespace Triband.MountainGeneratorTool
{
	[ExecuteAlways]
	public sealed class MountainGenerator : MonoBehaviour
	{
		public MountainSettings Settings;

		public bool LockHeight = true;

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

		internal MeshFilter filter => m_Filter != null ? m_Filter : (m_Filter = GetComponent<MeshFilter>());

		internal MeshRenderer renderer => m_Renderer != null ? m_Renderer : (m_Renderer = GetComponent<MeshRenderer>());

		internal MeshCollider collider => m_Collider != null ? m_Collider : (m_Collider = GetComponent<MeshCollider>());

		private void Awake()
		{
			if (filter != null && filter.sharedMesh == null)
				BuildMountain();
		}

		private void Start()
		{
			if (filter != null && filter.sharedMesh == null)
				BuildMountain();
		}

		private void Update()
		{
			if (!Application.isPlaying && Points != null && filter != null && filter.sharedMesh == null)
				BuildMountain();
		}

		private static Vector3 Bezier(Vector3 start, Vector3 control, Vector3 end, float t)
		{
			float inv = 1f - t;
			return inv * inv * start + 2f * t * inv * control + t * t * end;
		}

		public void BuildMountain()
		{
			if (Points == null || Points.Count == 0)
			{
				pointTransforms = new List<Transform>();
				Points = new List<Vector3>();
				InsertPoint(Points.Count, new Vector3(5f, 0f, 5f), false);
				InsertPoint(Points.Count, new Vector3(5f, 0f, 50f), false);
				InsertPoint(Points.Count, new Vector3(50f, 0f, 50f), false);
				InsertPoint(Points.Count, new Vector3(50f, 0f, 5f), false);
			}

			var vertices = new List<Vector3>();
			var normals = new List<Vector3>();
			var triangles = new List<List<int>>();

			CheckTransformList();

			var poly = new List<Vector3>();
			if (Settings != null && Settings.RoundCorners && Points.Count >= 3 && Settings.Roundness > 0f)
			{
				int count = Points.Count;
				for (int i = 0; i < count; i++)
				{
					int prevIdx = (i == 0 ? count : i) - 1;
					int nextIdx = (i + 1) % count;
					Vector3 curr = Points[i];
					Vector3 prev = Points[prevIdx];
					Vector3 next = Points[nextIdx];
					Vector3 start = curr + (prev - curr) * Settings.CornerSize;
					Vector3 end = curr + (next - curr) * Settings.CornerSize;
					int steps = Mathf.Max(1, Mathf.RoundToInt(Settings.Roundness));
					for (int s = 0; s < steps; s++)
					{
						float t = (float)s / Settings.Roundness;
						poly.Add(Bezier(start, curr, end, t));
					}
				}
			}
			else
			{
				poly = Points;
			}

			Vector3 up = transform.up;
			for (int i = 0; i < poly.Count; i++)
			{
				vertices.Add(poly[i]);
				normals.Add(up);
			}

			Vector2[] poly2D = poly.Select(v => new Vector2(v.x, v.z)).ToArray();
			int[] topTris = TriangulationUtil.TriangulateSimple(poly2D);
			triangles.Add(new List<int>(topTris));

			if (Settings != null)
			{
				AddBevels(vertices, normals, triangles);

				if (materials == null || materials.Length != 3)
					materials = new Material[3];
				materials[0] = Settings.TopMaterial;
				materials[1] = Settings.CornerMaterial != null ? Settings.CornerMaterial : Settings.TopMaterial;
				materials[2] = Settings.SidesMaterial != null ? Settings.SidesMaterial : Settings.TopMaterial;
				if (renderer != null)
					renderer.sharedMaterials = materials;
			}

			if (mesh == null)
			{
				mesh = new Mesh();
				mesh.MarkDynamic();
			}
			else
			{
				mesh.Clear(false);
			}

			mesh.SetVertices(vertices);
			mesh.SetNormals(normals);
			mesh.subMeshCount = triangles.Count;
			for (int i = 0; i < triangles.Count; i++)
			{
				mesh.SetTriangles(triangles[i], i);
			}
			mesh.RecalculateBounds();

			if (filter != null)
				filter.sharedMesh = mesh;
			if (collider != null)
				collider.sharedMesh = mesh;
		}

		public void AddPoint(Vector3 pos, bool rebuild = true)
		{
			if (Points == null) Points = new List<Vector3>();
			InsertPoint(Points.Count, pos, rebuild);
		}

		public void InsertPoint(int index, Vector3 pos, bool rebuild = true)
		{
			if (Points == null) Points = new List<Vector3>();
			index = Mathf.Clamp(index, 0, Points.Count);
			Points.Insert(index, pos);
			if (rebuild) BuildMountain();
		}

		public void RemovePoint(int index, bool rebuild = true)
		{
			if (Points != null && index >= 0 && index < Points.Count)
			{
				Points.RemoveAt(index);
				if (rebuild) BuildMountain();
			}
		}

		public void MovePoint(int index, Vector3 pos)
		{
			if (Points != null && index >= 0 && index < Points.Count)
			{
				Points[index] = pos;
				BuildMountain();
			}
		}

		private void CheckTransformList()
		{
			if (pointTransforms == null)
				pointTransforms = new List<Transform>();
		}

		private Transform CreatePointTransform(Vector3 pos)
		{
			return null;
		}

		private void AddBevels(List<Vector3> vertices, List<Vector3> normals, List<List<int>> triangles)
		{
			if (Settings == null) return;
			var topPoly = new List<Vector3>(vertices);
			float slope1 = CalculateSlope(Settings.TopBevelHeight, Settings.TopBevelSize);
			float slope2 = CalculateSlope(Settings.BottomBevelHeight, Settings.BottomBevelSize);
			List<Vector3> normals1 = CalculateNormals(topPoly, slope1);
			List<Vector3> normals2 = CalculateNormals(topPoly, slope2);
			List<Vector3> midPoly = CreateSideVertices(topPoly, Settings.TopBevelHeight, Settings.TopBevelSize);
			List<Vector3> botPoly = CreateSideVertices(midPoly, Settings.BottomBevelHeight, Settings.BottomBevelSize);

			AddSide(topPoly, midPoly, vertices, triangles);
			normals.AddRange(normals1);
			normals.AddRange(normals1);

			AddSide(midPoly, botPoly, vertices, triangles);
			normals.AddRange(normals2);
			normals.AddRange(normals2);
		}

		private static float CalculateSlope(float height, float size)
		{
			float len = Mathf.Sqrt(height * height + size * size);
			if (len <= 1e-5f) return 90f;
			return Mathf.Asin(height / len) * 57.29578f + 90f;
		}

		private static void AddSide(IReadOnlyList<Vector3> top, IReadOnlyList<Vector3> bottom, List<Vector3> vertices, List<List<int>> triangles)
		{
			if (vertices == null || top == null || bottom == null || triangles == null) return;
			int startOffset = vertices.Count;
			int pointCount = top.Count;
			vertices.AddRange(top);
			vertices.AddRange(bottom);
			triangles.Add(CreateTriangles(startOffset, pointCount));
		}

		private static List<int> CreateTriangles(int startOffset, int pointCount)
		{
			var tris = new List<int>(pointCount * 6);
			for (int i = 0; i < pointCount; i++)
			{
				int curr = startOffset + i;
				int next = startOffset + ((i + 1) % pointCount);
				tris.Add(curr);
				tris.Add(curr + pointCount);
				tris.Add(next);
				tris.Add(next);
				tris.Add(curr + pointCount);
				tris.Add(next + pointCount);
			}
			return tris;
		}

		private static List<Vector3> CalculateNormals(IReadOnlyList<Vector3> vertices, float slope)
		{
			var list = new List<Vector3>();
			if (vertices == null || vertices.Count == 0) return list;
			int count = vertices.Count;
			for (int i = 0; i < count; i++)
			{
				int prevIdx = (i == 0 ? count : i) - 1;
				int nextIdx = (i == count - 1) ? 0 : (i + 1);
				Vector3 curr = vertices[i];
				Vector3 prev = vertices[prevIdx];
				Vector3 next = vertices[nextIdx];
				Vector3 dir1 = (curr - prev).normalized;
				Vector3 dir2 = (next - curr).normalized;
				float d1 = Vector3.Distance(curr, prev);
				float d2 = Vector3.Distance(curr, next);
				float t = d2 > 1e-5f ? (d1 / d2) : 0.5f;
				Vector3 tangent = Vector3.Slerp(dir1, dir2, t);
				Vector3 n1 = new Vector3(dir1.z, 0f, -dir1.x);
				Vector3 n2 = new Vector3(dir2.z, 0f, -dir2.x);
				Vector3 normal = Vector3.Slerp(n1, n2, t);
				list.Add(Quaternion.AngleAxis(slope, tangent) * normal);
			}
			return list;
		}

		private static List<Vector3> CreateSideVertices(IReadOnlyList<Vector3> fromPolygon, float height, float size)
		{
			var result = new List<Vector3>();
			if (fromPolygon == null || fromPolygon.Count == 0) return result;
			int count = fromPolygon.Count;
			var poly2D = new Vector2[count];
			for (int i = 0; i < count; i++)
				poly2D[i] = new Vector2(fromPolygon[i].x, fromPolygon[i].z);

			for (int i = 0; i < count; i++)
			{
				int prevIdx = (i == 0 ? count : i) - 1;
				int nextIdx = (i + 1 == count) ? 0 : (i + 1);
				Vector2 dPrev = (poly2D[prevIdx] - poly2D[i]).normalized;
				Vector2 dNext = (poly2D[nextIdx] - poly2D[i]).normalized;
				Vector2 bisector = (-dPrev - dNext).normalized;
				Vector3 curr = fromPolygon[i];
				float y = curr.y - height;
				Vector2 testPt = poly2D[i] + bisector * 0.1f;
				if (ContainsPoint(poly2D, testPt))
					result.Add(new Vector3(curr.x - size * bisector.x, y, curr.z - size * bisector.y));
				else
					result.Add(new Vector3(curr.x + size * bisector.x, y, curr.z + size * bisector.y));
			}
			return result;
		}

		private static bool ContainsPoint(IReadOnlyList<Vector2> polyPoints, Vector2 p)
		{
			if (polyPoints == null || polyPoints.Count < 3) return false;
			bool inside = false;
			int count = polyPoints.Count;
			int j = count - 1;
			for (int i = 0; i < count; j = i++)
			{
				Vector2 pi = polyPoints[i];
				Vector2 pj = polyPoints[j];
				if (((pi.y <= p.y && p.y < pj.y) || (pj.y <= p.y && p.y < pi.y)) &&
				    (p.x < (pj.x - pi.x) * (p.y - pi.y) / (pj.y - pi.y) + pi.x))
				{
					inside = !inside;
				}
			}
			return inside;
		}
	}
}
