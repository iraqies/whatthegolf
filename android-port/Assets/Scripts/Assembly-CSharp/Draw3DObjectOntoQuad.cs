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
		if (quad != null)
		{
			mesh = quad.GetComponent<MeshRenderer>();
			renderTexture = new RenderTexture(renderTextureTemplate);
			renderTexture.Create();
			material = new Material(renderTextureMaterialTemplate);
			material.mainTexture = renderTexture;
			if (projectingCamera != null)
			{
				projectingCamera.targetTexture = renderTexture;
			}
			mesh.material = material;
		}
	}

	private void OnValidate()
	{
		object3D.transform.rotation = masterObject.transform.rotation;
	}

	private void Update()
	{
		object3D.transform.rotation = masterObject.transform.rotation;
	}
}
