using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[ExecuteAlways]
public class CreateSmoothBarrier : MonoBehaviour
{
	public bool CreateTrackFromPath = true;

	public float Width = 5f;

	public float Height = 5f;

	public float TilingMod = 1f;

	private MeshFilter meshFilter;

	private CinemachineSmoothPath path;

	private MeshRenderer renderer;

	private MaterialPropertyBlock propBlock;

	private MeshCollider meshCollider;

	private void Awake()
	{
		Initialize();
		SetProperties();
		CreateMesh();
	}

	private void Update()
	{
		if (Application.isPlaying)
		{
			return;
		}
		Initialize();
		SetProperties();
	}

	private void CreateMesh()
	{
		if (!CreateTrackFromPath || meshFilter == null || path == null || path.m_Waypoints == null || path.m_Waypoints.Length < 2)
		{
			return;
		}
		Mesh mesh;
		if (meshFilter.sharedMesh != null)
		{
			meshFilter.sharedMesh.Clear();
			mesh = meshFilter.sharedMesh;
		}
		else
		{
			mesh = new Mesh();
			mesh.MarkDynamic();
		}

		var vertices = new List<Vector3>();
		var triangles = new List<int>();
		var uvs = new List<Vector2>();
		var normals = new List<Vector3>();

		float pathLen = path.PathLength;
		int resolution = path.m_Resolution;
		int wpCount = path.m_Waypoints.Length;
		Quaternion rot0 = path.EvaluateOrientationAtUnit(0f, CinemachinePathBase.PositionUnits.Distance);
		Vector3 side0 = (rot0 * Vector3.right) * Width;
		Vector3 pos0 = transform.InverseTransformPoint(path.EvaluatePositionAtUnit(0f, CinemachinePathBase.PositionUnits.Distance));
		Vector3 upOffset = transform.up * Height;

		vertices.Add(pos0 + side0);
		vertices.Add(pos0 - side0);
		vertices.Add(pos0 + side0 + upOffset);
		vertices.Add(pos0 - side0 + upOffset);

		uvs.Add(new Vector2(0f, 1f));
		uvs.Add(new Vector2(0f, 1f));
		uvs.Add(new Vector2(0f, 0f));
		uvs.Add(new Vector2(0f, 0f));

		triangles.Add(0);
		triangles.Add(1);
		triangles.Add(2);
		triangles.Add(1);
		triangles.Add(3);
		triangles.Add(2);

		Vector3 side0Norm = side0.normalized;
		normals.Add(side0Norm);
		normals.Add(-side0Norm);
		normals.Add(transform.up);
		normals.Add(transform.up);

		float step = pathLen / Mathf.Max(1, resolution + wpCount);
		float dist = 0f;
		while (dist < pathLen)
		{
			dist += step;
			Vector3 p = transform.InverseTransformPoint(path.EvaluatePositionAtUnit(dist, CinemachinePathBase.PositionUnits.Distance));
			Quaternion r = path.EvaluateOrientationAtUnit(dist, CinemachinePathBase.PositionUnits.Distance);
			Vector3 side = transform.InverseTransformDirection(r * Vector3.right) * Width;
			Vector3 pRight = p + side;
			Vector3 pLeft = p - side;
			Vector3 up = transform.up * Height;

			vertices.Add(pRight);
			vertices.Add(pLeft);
			vertices.Add(pRight + up);
			vertices.Add(pLeft + up);

			int vc = vertices.Count;
			int i0 = vc - 8;
			int i1 = vc - 7;
			int i2 = vc - 6;
			int i3 = vc - 5;
			int i4 = vc - 4;
			int i5 = vc - 3;
			int i6 = vc - 2;
			int i7 = vc - 1;

			triangles.Add(i6);
			triangles.Add(i4);
			triangles.Add(i2);
			triangles.Add(i0);
			triangles.Add(i2);
			triangles.Add(i4);

			triangles.Add(i5);
			triangles.Add(i3);
			triangles.Add(i1);
			triangles.Add(i5);
			triangles.Add(i7);
			triangles.Add(i3);

			triangles.Add(i2);
			triangles.Add(i3);
			triangles.Add(i6);
			triangles.Add(i6);
			triangles.Add(i3);
			triangles.Add(i7);

			triangles.Add(i4);
			triangles.Add(i1);
			triangles.Add(i0);
			triangles.Add(i1);
			triangles.Add(i4);
			triangles.Add(i5);

			float u = path.PathLength > 0f ? (dist / path.PathLength) : 0f;
			uvs.Add(new Vector2(u, 1f));
			uvs.Add(new Vector2(u, 1f));
			uvs.Add(new Vector2(u, 0f));
			uvs.Add(new Vector2(u, 0f));

			Vector3 sNorm = side.normalized;
			normals.Add(sNorm);
			normals.Add(-sNorm);
			normals.Add(transform.up);
			normals.Add(transform.up);
		}

		int endCount = vertices.Count;
		triangles.Add(endCount - 4);
		triangles.Add(endCount - 2);
		triangles.Add(endCount - 3);
		triangles.Add(endCount - 3);
		triangles.Add(endCount - 2);
		triangles.Add(endCount - 1);

		mesh.vertices = vertices.ToArray();
		mesh.triangles = triangles.ToArray();
		mesh.uv = uvs.ToArray();
		mesh.normals = normals.ToArray();
		meshFilter.sharedMesh = mesh;
		if (meshCollider != null && meshCollider.sharedMesh == null)
		{
			meshCollider.sharedMesh = mesh;
		}
	}

	private void Initialize()
	{
		if (meshFilter == null)
			meshFilter = GetComponent<MeshFilter>();
		if (path == null)
			path = GetComponent<CinemachineSmoothPath>();
		if (renderer == null)
			renderer = GetComponent<MeshRenderer>();
		if (propBlock == null)
			propBlock = new MaterialPropertyBlock();
		if (meshCollider == null)
			meshCollider = GetComponent<MeshCollider>();
	}

	private void SetProperties()
	{
		if (renderer == null || path == null || propBlock == null) return;
		renderer.GetPropertyBlock(propBlock);
		propBlock.SetFloat("_Tiling", path.PathLength * 0.25f * TilingMod);
		renderer.SetPropertyBlock(propBlock);
	}
}
