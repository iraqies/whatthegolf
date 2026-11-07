using UnityEngine;

[ExecuteInEditMode]
public class CameraFilterPack_TV_VHS_Rewind : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	private Material SCMaterial;

	public float Cryptage;

	public float Parasite;

	public float Parasite2;

	private float WhiteParasite;

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
