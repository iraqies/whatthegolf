using UnityEngine;

public class Draw3DObjectOntoQuad : MonoBehaviour
{
	public GameObject masterObject;

	public GameObject object3D;

	public Camera projectingCamera;

	public GameObject quad;

	public RenderTexture renderTextureTemplate;

	public Material renderTextureMaterialTemplate;

	private MeshRenderer mesh;

	private RenderTexture renderTexture;

	private Material material;

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	private void Update()
	{
	}
}
