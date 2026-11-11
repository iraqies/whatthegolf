using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[ExecuteAlways]
public class CreateRunningTrack : MonoBehaviour
{
	public bool CreateTrackFromPath = true;

	public float Width = 5f;

	public Color BaseColor = new Color(0.6313726f, 0.3019608f, 0.33333334f, 1f);

	public bool UseCustomLineColor;

	public Color LineColor = Color.white;

	public float LeftLineIndent = 0.07f;

	public float LeftLineWidth = 0.05f;

	public float RightLineIndent = 0.07f;

	public float RightLineWidth = 0.05f;

	public float Tracks = 2f;

	public float MiddleLineWidth = 0.01f;

	public float HorizontalLineWidth = 0.001f;

	public float HorizontalLineInterval = 0.1f;

	public bool UseGab;

	public float LineGabWidth = 0.05f;

	public float LineGabInterval = 0.08f;

	public bool AddNoise;

	public float NoiseCutoff = 0.133f;

	public float NoiseScale = 0.4f;

	public Color NoiseColor;

	public Vector2 NoiseOffset;

	public float NoiseCutoff2 = 0.084f;

	public float NoiseScale2 = 0.4f;

	public Color NoiseColor2;

	public Vector2 NoiseOffset2;

	private MeshFilter meshFilter;

	private CinemachineSmoothPath path;

	private MeshRenderer renderer;

	private MaterialPropertyBlock propBlock;

	public MeshRenderer start;

	public MeshRenderer end;

	public bool CurvedEnds;

	public float pathResolution = 1f;

	private bool isFirstFrame = true;

	private void Awake()
	{
		Initialize();
		SetProperties(renderer);
		SetProperties(start);
		SetProperties(end);
		CreateMesh();
	}

	private void Update()
	{
		if (Application.isPlaying)
		{
			return;
		}
		Initialize();
		SetProperties(renderer);
		SetProperties(start);
		SetProperties(end);
	}

	private void CreateMesh()
	{
		if (!CreateTrackFromPath || meshFilter == null || path == null || path.m_Waypoints == null || path.m_Waypoints.Length < 2)
		{
			return;
		}
		if (isFirstFrame)
		{
			meshFilter.sharedMesh = new Mesh();
			meshFilter.sharedMesh.MarkDynamic();
			isFirstFrame = false;
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
		float resScale = pathResolution;
		int resolution = path.m_Resolution;
		int wpCount = path.m_Waypoints.Length;

		if (CurvedEnds && !path.Looped && end != null && start != null)
		{
			end.transform.localScale = new Vector3(Width * 2f, Width, 1f);
			start.transform.localScale = new Vector3(Width * 2f, Width, 1f);

			Quaternion endRot = path.EvaluateOrientationAtUnit(1f, CinemachinePathBase.PositionUnits.Normalized) * Quaternion.Euler(90f, 0f, 0f);
			end.transform.rotation = endRot;
			Vector3 endPos = path.EvaluatePositionAtUnit(1f, CinemachinePathBase.PositionUnits.Normalized);
			end.transform.position = endPos + end.transform.up * end.transform.lossyScale.y * 0.5f;

			Quaternion startRot = path.EvaluateOrientationAtUnit(0f, CinemachinePathBase.PositionUnits.Normalized) * Quaternion.Euler(90f, 180f, 0f);
			start.transform.rotation = startRot;
			Vector3 startPos = path.EvaluatePositionAtUnit(0f, CinemachinePathBase.PositionUnits.Normalized);
			start.transform.position = startPos + start.transform.up * start.transform.lossyScale.y * 0.5f;
		}

		Quaternion invRot = Quaternion.Inverse(transform.rotation);
		Quaternion rot0 = invRot * path.EvaluateOrientationAtUnit(0f, CinemachinePathBase.PositionUnits.Distance);
		Vector3 side0 = (rot0 * Vector3.right) * Width;
		Vector3 pos0 = transform.InverseTransformPoint(path.EvaluatePositionAtUnit(0f, CinemachinePathBase.PositionUnits.Distance));

		vertices.Add(pos0 + side0);
		vertices.Add(pos0 - side0);
		uvs.Add(new Vector2(1f, 0f));
		uvs.Add(new Vector2(0f, 0f));
		normals.Add(transform.up);
		normals.Add(transform.up);

		float step = pathLen / Mathf.Max(1f, resScale * (resolution + wpCount));
		float dist = 0f;
		while (dist < path.PathLength)
		{
			dist += step;
			Vector3 p = transform.InverseTransformPoint(path.EvaluatePositionAtUnit(dist, CinemachinePathBase.PositionUnits.Distance));
			Quaternion r = Quaternion.Inverse(transform.rotation) * path.EvaluateOrientationAtUnit(dist, CinemachinePathBase.PositionUnits.Distance);
			Vector3 side = (r * Vector3.right) * Width;

			vertices.Add(p + side);
			vertices.Add(p - side);

			int vc = vertices.Count;
			triangles.Add(vc - 4);
			triangles.Add(vc - 3);
			triangles.Add(vc - 2);
			triangles.Add(vc - 3);
			triangles.Add(vc - 1);
			triangles.Add(vc - 2);

			float vLen = UseGab ? 1f : 0.5f;
			float vCoord = path.PathLength > 0f ? Mathf.PingPong(dist / path.PathLength, vLen) : 0f;
			uvs.Add(new Vector2(1f, vCoord));
			uvs.Add(new Vector2(0f, vCoord));

			normals.Add(transform.up);
			normals.Add(transform.up);
		}

		mesh.vertices = vertices.ToArray();
		mesh.triangles = triangles.ToArray();
		mesh.uv = uvs.ToArray();
		mesh.normals = normals.ToArray();
		meshFilter.sharedMesh = mesh;
	}

	private void SetProperties(Renderer r)
	{
		if (r == null || propBlock == null) return;
		r.GetPropertyBlock(propBlock);
		propBlock.SetFloat("_Tracks", Tracks);
		propBlock.SetFloat("_MidLineSize", MiddleLineWidth);
		propBlock.SetFloat("_LeftIndent", LeftLineIndent);
		propBlock.SetFloat("_LeftSize", LeftLineWidth);
		propBlock.SetFloat("_RightIndent", RightLineIndent);
		propBlock.SetFloat("_RightSize", RightLineWidth);
		if (HorizontalLineInterval > 0f)
		{
			propBlock.SetFloat("_zLineInterval", HorizontalLineInterval);
			propBlock.SetFloat("_zLineSize", HorizontalLineWidth);
		}
		else
		{
			propBlock.SetFloat("_zLineInterval", 1f);
			propBlock.SetFloat("_zLineSize", 0f);
		}
		propBlock.SetColor("_BaseColor", BaseColor);
		Color lc = LineColor;
		if (!UseCustomLineColor && ColorUtility.TryParseHtmlString("#D5997F", out Color parsed))
		{
			lc = parsed;
		}
		propBlock.SetColor("_LineColor", lc);
		propBlock.SetFloat("_GabSize", UseGab ? LineGabWidth : 1f);
		propBlock.SetFloat("_GabInterval", UseGab ? LineGabInterval : 100f);
		propBlock.SetFloat("_NoiseScale", AddNoise ? NoiseScale : 0f);
		propBlock.SetFloat("_NoiseCutoff", NoiseCutoff);
		propBlock.SetColor("_NoiseColor", NoiseColor);
		propBlock.SetVector("_NoiseOffset", NoiseOffset);
		propBlock.SetFloat("_NoiseScale2", AddNoise ? NoiseScale2 : 0f);
		propBlock.SetFloat("_NoiseCutoff2", NoiseCutoff2);
		propBlock.SetColor("_NoiseColor2", NoiseColor2);
		propBlock.SetVector("_NoiseOffset2", NoiseOffset2);
		r.SetPropertyBlock(propBlock);
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
	}
}
