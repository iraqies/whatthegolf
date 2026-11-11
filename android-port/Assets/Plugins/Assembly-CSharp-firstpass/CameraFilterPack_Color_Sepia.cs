using UnityEngine;

[ExecuteInEditMode]
public class CameraFilterPack_Color_Sepia : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX = 1f;

	public float _Fade = 1f;

	private Material SCMaterial;

	private Material material
	{
		get
		{
			if (SCMaterial == null && SCShader != null)
			{
				SCMaterial = new Material(SCShader)
				{
					hideFlags = HideFlags.HideAndDontSave
				};
			}
			return SCMaterial;
		}
	}

	private void Start()
	{
		if (SCShader == null)
		{
			SCShader = Shader.Find("CameraFilterPack/Color_Sepia");
		}
	}

	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		if (SCShader != null && material != null)
		{
			TimeX += Time.deltaTime;
			if (TimeX > 100f)
			{
				TimeX = 0f;
			}
			material.SetFloat("_TimeX", TimeX);
			material.SetFloat("_Fade", _Fade);
			Graphics.Blit(sourceTexture, destTexture, material);
		}
		else
		{
			Graphics.Blit(sourceTexture, destTexture);
		}
	}

	private void OnDisable()
	{
		if (SCMaterial != null)
		{
			Object.DestroyImmediate(SCMaterial);
		}
	}
}
