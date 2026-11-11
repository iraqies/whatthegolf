using System;
using UnityEngine;

public class CreateRenderTexForPainter : MonoBehaviour
{
	public Camera camera;

	public Camera poseCamera;

	public Camera bgCamera;

	public Material Mat;

	public Vector2Int TexSize = new Vector2Int(512, 512);

	public GiraffePainterController controller;

	public MeshRenderer CanvasRenderer;

	public Action<RenderTexture> OnTextureCreated;

	private RenderTexture tex;

	private RenderTexture texResult;

	private RenderTexture texBackground;

	private Material paintingMat;

	private void Start()
	{
		paintingMat = UnityEngine.Object.Instantiate(Mat);
		CanvasRenderer.material = paintingMat;
		tex = RenderTexture.GetTemporary(TexSize.x, TexSize.y, 1);
		texResult = RenderTexture.GetTemporary(TexSize.x, TexSize.y, 1);
		texBackground = RenderTexture.GetTemporary(TexSize.x, TexSize.y, 1);
		tex.useMipMap = false;
		texResult.useMipMap = false;
		texBackground.useMipMap = false;
		camera.targetTexture = tex;
		poseCamera.targetTexture = texResult;
		bgCamera.targetTexture = texBackground;
		paintingMat.SetTexture("_Tex1", texResult);
		paintingMat.SetTexture("_BlendTex", tex);
		paintingMat.SetTexture("_BackgroundTex", texBackground);
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = tex;
		GL.Clear(true, true, Color.white);
		RenderTexture.active = texBackground;
		GL.Clear(true, true, Color.white);
		RenderTexture.active = active;
		poseCamera.gameObject.SetActive(true);
		camera.gameObject.SetActive(true);
		bgCamera.gameObject.SetActive(true);
		controller.PaintingMat = paintingMat;
		OnTextureCreated?.Invoke(tex);
		controller.OnClear += ControllerOnOnClear;
	}

	private void ControllerOnOnClear()
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = tex;
		GL.Clear(true, true, Color.white);
		RenderTexture.active = texBackground;
		GL.Clear(true, true, Color.white);
		RenderTexture.active = active;
	}

	private void OnDestroy()
	{
		RenderTexture.ReleaseTemporary(tex);
		RenderTexture.ReleaseTemporary(texResult);
		RenderTexture.ReleaseTemporary(texBackground);
	}
}
