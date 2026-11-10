using UnityEngine;

public class AmongUsRandomizeFinalCrewmates : MonoBehaviour
{
	public MeshRenderer helmetMeshRenderer;

	public Material[] helmetMaterials;

	private void Start()
	{
		if (helmetMaterials != null && helmetMaterials.Length > 0 && helmetMeshRenderer != null)
		{
			helmetMeshRenderer.material = helmetMaterials[Random.Range(0, helmetMaterials.Length)];
		}
	}
}
