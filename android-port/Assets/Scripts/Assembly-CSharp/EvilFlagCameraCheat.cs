using System.Collections.Generic;
using UnityEngine;

public class EvilFlagCameraCheat : MonoBehaviour
{
	public Material ScreenMaterial;

	public Camera NewCam;

	public List<MeshFilter> Quads;

	public Vector3 Forward = Vector3.forward;

	private void Start()
	{
		if (NewCam == null)
		{
			return;
		}
		NewCam.targetTexture = RenderTexture.GetTemporary(Screen.width, Screen.height);
		if (Camera.main != null)
		{
			NewCam.transform.SetParent(Camera.main.transform);
		}
		NewCam.transform.localPosition = Vector3.zero;
		NewCam.transform.localRotation = Quaternion.identity;
		if (ScreenMaterial != null)
		{
			ScreenMaterial.mainTexture = NewCam.targetTexture;
		}
	}

	private void Update()
	{
		if (NewCam == null || !NewCam.enabled || Quads == null || Camera.main == null)
		{
			return;
		}
		foreach (MeshFilter quad in Quads)
		{
			if (quad == null || quad.sharedMesh == null)
			{
				continue;
			}
			Mesh mesh = quad.sharedMesh;
			Vector3[] verts = mesh.vertices;
			Vector3[] norms = mesh.normals;
			Vector2[] uvs = new Vector2[mesh.vertexCount];
			for (int i = 0; i < verts.Length && i < norms.Length; i++)
			{
				Vector3 worldNormal = quad.transform.TransformDirection(norms[i]);
				if (-worldNormal.x * Forward.x - worldNormal.y * Forward.y > worldNormal.z * Forward.z)
				{
					Vector3 vp = Camera.main.WorldToViewportPoint(quad.transform.TransformPoint(verts[i]));
					uvs[i] = new Vector2(vp.x, vp.y);
				}
			}
			mesh.uv = uvs;
		}
	}
}
