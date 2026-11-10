using System;
using UnityEngine;
using UnityEngine.Rendering;

public class Skidmarks : MonoBehaviour
{
	private class MarkSection
	{
		public Vector3 Pos = Vector3.zero;

		public Vector3 Normal = Vector3.zero;

		public Vector4 Tangent = Vector4.zero;

		public Vector3 Posl = Vector3.zero;

		public Vector3 Posr = Vector3.zero;

		public byte Intensity;

		public int LastIndex;
	}

	[SerializeField]
	private Material skidmarksMaterial;

	private const int MAX_MARKS = 2048;

	private const float MARK_WIDTH = 0.6f;

	private const float GROUND_OFFSET = 0.02f;

	private const float MIN_DISTANCE = 1f;

	private const float MIN_SQR_DISTANCE = 1f;

	private int markIndex;

	private MarkSection[] skidmarks;

	private Mesh marksMesh;

	private MeshRenderer mr;

	private MeshFilter mf;

	private Vector3[] vertices;

	private Vector3[] normals;

	private Vector4[] tangents;

	private Color32[] colors;

	private Vector2[] uvs;

	private int[] triangles;

	private bool meshUpdated;

	private bool haveSetBounds;

	private bool initialized;

	public Action<float> OnCreateSkidmark;

	protected void Start()
	{
		UnityEngine.SceneManagement.Scene origScene = base.gameObject.scene;
		base.transform.SetParent(null);
		if (origScene.IsValid() && base.gameObject.scene != origScene)
		{
			UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(base.gameObject, origScene);
		}
		base.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
		base.transform.localScale = Vector3.one;
		skidmarks = new MarkSection[MAX_MARKS];
		for (int i = 0; i < MAX_MARKS; i++)
		{
			skidmarks[i] = new MarkSection();
		}
		mf = GetComponent<MeshFilter>();
		mr = GetComponent<MeshRenderer>();
		if (mr == null)
		{
			mr = base.gameObject.AddComponent<MeshRenderer>();
		}
		marksMesh = new Mesh();
		marksMesh.MarkDynamic();
		if (mf == null)
		{
			mf = base.gameObject.AddComponent<MeshFilter>();
		}
		mf.sharedMesh = marksMesh;
		vertices = new Vector3[MAX_MARKS * 4];
		normals = new Vector3[MAX_MARKS * 4];
		tangents = new Vector4[MAX_MARKS * 4];
		colors = new Color32[MAX_MARKS * 4];
		uvs = new Vector2[MAX_MARKS * 4];
		triangles = new int[MAX_MARKS * 6];
		mr.shadowCastingMode = ShadowCastingMode.Off;
		mr.receiveShadows = false;
		mr.material = skidmarksMaterial;
		mr.lightProbeUsage = LightProbeUsage.Off;
		initialized = true;
	}

	protected void LateUpdate()
	{
		if (meshUpdated)
		{
			meshUpdated = false;
			marksMesh.vertices = vertices;
			marksMesh.normals = normals;
			marksMesh.tangents = tangents;
			marksMesh.triangles = triangles;
			marksMesh.colors32 = colors;
			marksMesh.uv = uvs;
			if (!haveSetBounds)
			{
				marksMesh.bounds = new Bounds(Vector3.zero, new Vector3(10000f, 10000f, 10000f));
				haveSetBounds = true;
			}
			mf.sharedMesh = marksMesh;
		}
	}

	public int AddSkidMark(Vector3 pos, Vector3 normal, float intensity, int lastIndex)
	{
		if (!initialized)
		{
			return -1;
		}
		if (intensity > 1f)
		{
			intensity = 1f;
		}
		else if (intensity < 0f)
		{
			return -1;
		}
		OnCreateSkidmark?.Invoke(intensity);
		if (lastIndex > 0)
		{
			if ((pos - skidmarks[lastIndex].Pos).sqrMagnitude < MIN_SQR_DISTANCE)
			{
				return lastIndex;
			}
		}
		MarkSection curSection = skidmarks[markIndex];
		curSection.Pos = pos + normal * GROUND_OFFSET;
		curSection.Normal = normal;
		curSection.Intensity = (byte)(intensity * 255f);
		curSection.LastIndex = lastIndex;
		if (lastIndex != -1)
		{
			MarkSection lastSection = skidmarks[lastIndex];
			Vector3 dir = curSection.Pos - lastSection.Pos;
			Vector3 xDir = Vector3.Cross(dir, normal).normalized;
			Vector3 halfWidth = xDir * MARK_WIDTH * 0.5f;
			curSection.Posl = curSection.Pos + halfWidth;
			curSection.Posr = curSection.Pos - halfWidth;
			curSection.Tangent = new Vector4(xDir.x, xDir.y, xDir.z, 1f);
			if (lastSection.LastIndex == -1)
			{
				lastSection.Tangent = curSection.Tangent;
				lastSection.Posl = curSection.Pos + halfWidth;
				lastSection.Posr = curSection.Pos - halfWidth;
			}
		}
		UpdateSkidmarksMesh();
		int curIndex = markIndex;
		markIndex = (markIndex + 1) % MAX_MARKS;
		return curIndex;
	}

	private void UpdateSkidmarksMesh()
	{
		MarkSection curr = skidmarks[markIndex];
		if (curr.LastIndex == -1)
		{
			return;
		}
		MarkSection last = skidmarks[curr.LastIndex];
		int vIdx = markIndex * 4;
		vertices[vIdx] = last.Posl;
		vertices[vIdx + 1] = last.Posr;
		vertices[vIdx + 2] = curr.Posl;
		vertices[vIdx + 3] = curr.Posr;
		normals[vIdx] = last.Normal;
		normals[vIdx + 1] = last.Normal;
		normals[vIdx + 2] = curr.Normal;
		normals[vIdx + 3] = curr.Normal;
		tangents[vIdx] = last.Tangent;
		tangents[vIdx + 1] = last.Tangent;
		tangents[vIdx + 2] = curr.Tangent;
		tangents[vIdx + 3] = curr.Tangent;
		colors[vIdx] = new Color32(0, 0, 0, last.Intensity);
		colors[vIdx + 1] = new Color32(0, 0, 0, last.Intensity);
		colors[vIdx + 2] = new Color32(0, 0, 0, curr.Intensity);
		colors[vIdx + 3] = new Color32(0, 0, 0, curr.Intensity);
		uvs[vIdx] = new Vector2(0f, 0f);
		uvs[vIdx + 1] = new Vector2(1f, 0f);
		uvs[vIdx + 2] = new Vector2(0f, 1f);
		uvs[vIdx + 3] = new Vector2(1f, 1f);
		int tIdx = markIndex * 6;
		triangles[tIdx] = vIdx;
		triangles[tIdx + 2] = vIdx + 1;
		triangles[tIdx + 1] = vIdx + 2;
		triangles[tIdx + 3] = vIdx + 2;
		triangles[tIdx + 5] = vIdx + 1;
		triangles[tIdx + 4] = vIdx + 3;
		meshUpdated = true;
	}
}
