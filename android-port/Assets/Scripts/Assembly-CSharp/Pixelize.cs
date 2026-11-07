using UnityEngine;

[ExecuteInEditMode]
public class Pixelize : MonoBehaviour
{
	private Shader _screenAndMaskShader;

	private Material _screenAndMaskMaterial;

	private RenderTexture _temporaryRenderTexture;

	private Shader _combineLayersShader;

	private Material _combineLayersMaterial;

	private Shader ScreenAndMaskShader => null;

	private Material ScreenAndMaskMaterial => null;

	private RenderTexture TemporaryRenderTarget => null;

	private Shader CombineLayersShader => null;

	private Material CombineLayersMaterial => null;

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}

	private void CreateTemporaryRenderTarget()
	{
	}

	private void CheckTemporaryRenderTarget()
	{
	}

	private void ReleaseTemporaryRenderTarget()
	{
	}
}
