using UnityEngine;

[ExecuteInEditMode]
public class Pixelize : MonoBehaviour
{
	private Shader _screenAndMaskShader;

	private Material _screenAndMaskMaterial;

	private RenderTexture _temporaryRenderTexture;

	private Shader _combineLayersShader;

	private Material _combineLayersMaterial;

	private Shader ScreenAndMaskShader
	{
		get
		{
			if (_screenAndMaskShader == null)
			{
				_screenAndMaskShader = Shader.Find("Hidden/PostProcess/Pixelize/ScreenAndMask");
			}
			return _screenAndMaskShader;
		}
	}

	private Material ScreenAndMaskMaterial
	{
		get
		{
			if (_screenAndMaskMaterial == null && ScreenAndMaskShader != null)
			{
				_screenAndMaskMaterial = new Material(ScreenAndMaskShader);
			}
			return _screenAndMaskMaterial;
		}
	}

	private RenderTexture TemporaryRenderTarget
	{
		get
		{
			if (_temporaryRenderTexture == null)
			{
				CreateTemporaryRenderTarget();
			}
			return _temporaryRenderTexture;
		}
	}

	private Shader CombineLayersShader
	{
		get
		{
			if (_combineLayersShader == null)
			{
				_combineLayersShader = Shader.Find("Hidden/PostProcess/Pixelize/CombineLayers");
			}
			return _combineLayersShader;
		}
	}

	private Material CombineLayersMaterial
	{
		get
		{
			if (_combineLayersMaterial == null && CombineLayersShader != null)
			{
				_combineLayersMaterial = new Material(CombineLayersShader);
			}
			return _combineLayersMaterial;
		}
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		CheckTemporaryRenderTarget();
		if (TemporaryRenderTarget != null && ScreenAndMaskMaterial != null && CombineLayersMaterial != null)
		{
			Graphics.Blit(src, TemporaryRenderTarget, ScreenAndMaskMaterial);
			Graphics.Blit(TemporaryRenderTarget, dest, CombineLayersMaterial);
		}
		else
		{
			Graphics.Blit(src, dest);
		}
	}

	private void CreateTemporaryRenderTarget()
	{
		_temporaryRenderTexture = new RenderTexture(Screen.width, Screen.height, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear)
		{
			useMipMap = true,
			autoGenerateMips = true,
			wrapMode = TextureWrapMode.Clamp,
			filterMode = FilterMode.Point
		};
		_temporaryRenderTexture.Create();
	}

	private void CheckTemporaryRenderTarget()
	{
		if (TemporaryRenderTarget != null && (TemporaryRenderTarget.width != Screen.width || TemporaryRenderTarget.height != Screen.height))
		{
			ReleaseTemporaryRenderTarget();
		}
	}

	private void ReleaseTemporaryRenderTarget()
	{
		if (_temporaryRenderTexture != null)
		{
			_temporaryRenderTexture.Release();
			_temporaryRenderTexture = null;
		}
	}
}
