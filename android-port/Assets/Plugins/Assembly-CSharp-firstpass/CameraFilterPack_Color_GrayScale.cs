using UnityEngine;

[ExecuteInEditMode]
public class CameraFilterPack_Color_GrayScale : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	public float _Fade;

	private Material SCMaterial;

	private Material material => null;

	private void Start()
	{
	}

	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
	}

	private void OnDisable()
	{
	}
}
