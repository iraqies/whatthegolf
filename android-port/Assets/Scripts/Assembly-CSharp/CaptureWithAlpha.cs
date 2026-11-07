using System;
using UnityEngine;

public class CaptureWithAlpha : MonoBehaviour
{
	private Camera m_Camera;

	public int UpScale;

	public bool AlphaBackground;

	public Camera camera => null;

	public RenderTextureDescriptor descriptor => default;

	private Texture2D Screenshot(bool useAlpha = true, RenderTexture customDepthTexture = null)
	{
		return null;
	}

	public string SaveScreenshot(string scene, string layer, DateTime time, bool useClearAlpha = true, RenderTexture customDepthTexture = null)
	{
		return null;
	}
}
