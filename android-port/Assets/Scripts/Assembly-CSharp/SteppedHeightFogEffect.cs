using UnityEngine;

[ExecuteInEditMode]
public class SteppedHeightFogEffect : MonoBehaviour
{
	private Shader shader;

	private Material material;

	public float fogStartHeight;

	public float fogStopHeight;

	public int stepPower;

	public bool useCameraClearColor;

	public Color fogColor;

	public bool skyMask;

	private void SetMaterialValues()
	{
	}

	private void Start()
	{
	}

	private void CreateMaterial()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	private void OnValidate()
	{
	}
}
