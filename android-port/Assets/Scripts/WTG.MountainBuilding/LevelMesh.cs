using System.Collections.Generic;
using UnityEngine;

public class LevelMesh : MonoBehaviour
{
	private void Awake()
	{
		FixInvertedMeshTriangles();
	}

	private void FixInvertedMeshTriangles()
	{
		MeshFilter mf = GetComponent<MeshFilter>();
		MeshCollider mc = GetComponent<MeshCollider>();
		Mesh m = mf != null ? mf.sharedMesh : (mc != null ? mc.sharedMesh : null);
		if (m == null || !m.isReadable || m.subMeshCount < 1)
		{
			return;
		}
		Vector3[] verts = m.vertices;
		Vector3[] norms = m.normals;
		if (verts == null || norms == null || verts.Length != norms.Length || verts.Length == 0)
		{
			return;
		}
		bool modified = false;
		List<List<int>> subMeshTris = new List<List<int>>(m.subMeshCount);
		for (int s = 0; s < m.subMeshCount; s++)
		{
			int[] tris = m.GetTriangles(s);
			List<int> list = new List<int>(tris.Length);
			if (s == 0)
			{
				for (int i = 0; i + 2 < tris.Length; i += 3)
				{
					int i0 = tris[i];
					int i1 = tris[i + 1];
					int i2 = tris[i + 2];
					Vector3 v0 = verts[i0];
					Vector3 v1 = verts[i1];
					Vector3 v2 = verts[i2];
					if (v0.y < -100f && v1.y < -100f && v2.y < -100f)
					{
						modified = true;
						continue;
					}
					Vector3 cross = Vector3.Cross(v1 - v0, v2 - v0);
					if (cross.sqrMagnitude < 1e-6f)
					{
						modified = true;
						continue;
					}
					if (cross.y < 0f || (norms[i0].y < -0.5f && norms[i1].y < -0.5f && norms[i2].y < -0.5f))
					{
						int tmp = i1;
						i1 = i2;
						i2 = tmp;
						norms[i0] = Vector3.up;
						norms[i1] = Vector3.up;
						norms[i2] = Vector3.up;
						modified = true;
					}
					list.Add(i0);
					list.Add(i1);
					list.Add(i2);
				}
			}
			else
			{
				Vector3 center = Vector3.zero;
				int topCount = 0;
				for (int v = 0; v < verts.Length; v++)
				{
					if (verts[v].y > -5f)
					{
						center += verts[v];
						topCount++;
					}
				}
				if (topCount > 0)
				{
					center /= topCount;
				}
				for (int i = 0; i + 2 < tris.Length; i += 3)
				{
					int i0 = tris[i];
					int i1 = tris[i + 1];
					int i2 = tris[i + 2];
					Vector3 v0 = verts[i0];
					Vector3 v1 = verts[i1];
					Vector3 v2 = verts[i2];
					Vector3 cross = Vector3.Cross(v1 - v0, v2 - v0);
					if (cross.sqrMagnitude < 1e-6f)
					{
						modified = true;
						continue;
					}
					Vector3 geomNormal = cross.normalized;
					Vector3 triMid = (v0 + v1 + v2) / 3f;
					Vector3 outward = new Vector3(triMid.x - center.x, 0.25f, triMid.z - center.z);
					bool flip = false;
					if (geomNormal.y < -0.1f)
					{
						flip = true;
					}
					else if (outward.sqrMagnitude > 1f && Vector3.Dot(new Vector3(geomNormal.x, 0f, geomNormal.z), new Vector3(outward.x, 0f, outward.z)) < -0.1f)
					{
						flip = true;
					}
					if (flip)
					{
						int tmp = i1;
						i1 = i2;
						i2 = tmp;
						norms[i0] = -geomNormal;
						norms[i1] = -geomNormal;
						norms[i2] = -geomNormal;
						modified = true;
					}
					list.Add(i0);
					list.Add(i1);
					list.Add(i2);
				}
			}
			subMeshTris.Add(list);
		}
		if (modified)
		{
			m.normals = norms;
			for (int s = 0; s < subMeshTris.Count; s++)
			{
				m.SetTriangles(subMeshTris[s], s);
			}
			m.RecalculateBounds();
			if (mc != null)
			{
				mc.sharedMesh = null;
				mc.sharedMesh = m;
			}
		}
	}
}
