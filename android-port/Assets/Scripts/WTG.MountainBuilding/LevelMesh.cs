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
		if (m == null || !m.isReadable || m.subMeshCount < 2)
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
			List<int> list = new List<int>(tris);
			if (s == 0)
			{
				for (int i = 0; i + 2 < list.Count; i += 3)
				{
					int i0 = list[i];
					int i1 = list[i + 1];
					int i2 = list[i + 2];
					if (norms[i0].y < -0.5f && norms[i1].y < -0.5f && norms[i2].y < -0.5f)
					{
						list[i + 1] = i2;
						list[i + 2] = i1;
						norms[i0] = -norms[i0];
						norms[i1] = -norms[i1];
						norms[i2] = -norms[i2];
						modified = true;
					}
				}
			}
			else
			{
				for (int i = 0; i + 5 < list.Count; i += 6)
				{
					int a0 = list[i];
					int b0 = list[i + 3];
					int b1 = list[i + 4];
					int b2 = list[i + 5];
					if (Vector3.Dot(norms[a0], norms[b0]) < -0.2f)
					{
						list[i + 4] = b2;
						list[i + 5] = b1;
						norms[b0] = -norms[b0];
						norms[b1] = -norms[b1];
						norms[b2] = -norms[b2];
						modified = true;
					}
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
			if (mc != null && mc.sharedMesh == m)
			{
				mc.sharedMesh = null;
				mc.sharedMesh = m;
			}
		}
	}
}
