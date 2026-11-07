using System;
using UnityEngine;

public class Skidmarks : MonoBehaviour
{
	private class MarkSection
	{
		public Vector3 Pos;

		public Vector3 Normal;

		public Vector4 Tangent;

		public Vector3 Posl;

		public Vector3 Posr;

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
	}

	protected void LateUpdate()
	{
	}

	public int AddSkidMark(Vector3 pos, Vector3 normal, float intensity, int lastIndex)
	{
		return 0;
	}

	private void UpdateSkidmarksMesh()
	{
	}
}
