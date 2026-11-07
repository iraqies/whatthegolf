using System;
using UnityEngine;

public class CreateRenderTexForPainter : MonoBehaviour
{
	public Camera camera;

	public Camera poseCamera;

	public Camera bgCamera;

	public Material Mat;

	public Vector2Int TexSize;

	public GiraffePainterController controller;

	public MeshRenderer CanvasRenderer;

	public Action<RenderTexture> OnTextureCreated;

	private RenderTexture tex;

	private RenderTexture texResult;

	private RenderTexture texBackground;

	private Material paintingMat;

	private void Start()
	{
	}

	private void ControllerOnOnClear()
	{
	}

	private void OnDestroy()
	{
	}
}
