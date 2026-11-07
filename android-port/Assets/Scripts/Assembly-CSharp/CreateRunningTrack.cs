using Cinemachine;
using UnityEngine;

[ExecuteAlways]
public class CreateRunningTrack : MonoBehaviour
{
	public bool CreateTrackFromPath;

	public float Width;

	public Color BaseColor;

	public bool UseCustomLineColor;

	public Color LineColor;

	public float LeftLineIndent;

	public float LeftLineWidth;

	public float RightLineIndent;

	public float RightLineWidth;

	public float Tracks;

	public float MiddleLineWidth;

	public float HorizontalLineWidth;

	public float HorizontalLineInterval;

	public bool UseGab;

	public float LineGabWidth;

	public float LineGabInterval;

	public bool AddNoise;

	public float NoiseCutoff;

	public float NoiseScale;

	public Color NoiseColor;

	public Vector2 NoiseOffset;

	public float NoiseCutoff2;

	public float NoiseScale2;

	public Color NoiseColor2;

	public Vector2 NoiseOffset2;

	private MeshFilter meshFilter;

	private CinemachineSmoothPath path;

	private MeshRenderer renderer;

	private MaterialPropertyBlock propBlock;

	public MeshRenderer start;

	public MeshRenderer end;

	public bool CurvedEnds;

	public float pathResolution;

	private bool isFirstFrame;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void CreateMesh()
	{
	}

	private void SetProperties(Renderer r)
	{
	}

	private void Initialize()
	{
	}
}
