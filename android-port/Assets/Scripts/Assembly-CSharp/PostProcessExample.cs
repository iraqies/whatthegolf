using UnityEngine;

[ExecuteInEditMode]
public class PostProcessExample : MonoBehaviour
{
	public Material PostProcessMat;

	private void Awake()
	{
	}

	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
	}
}
