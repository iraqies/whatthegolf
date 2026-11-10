using System.Collections;
using UnityEngine;

public class CycleMaterialOrder : MonoBehaviour
{
	private MeshRenderer meshrenderer;

	public Material[] materialList;

	private float nextActionTime;

	public float interval;

	public int startOffset;

	private int materialIndex;

	private void Start()
	{
		meshrenderer = GetComponent<MeshRenderer>();
		materialIndex = startOffset;
		StartCoroutine(ChangeMaterial());
	}

	private IEnumerator ChangeMaterial()
	{
		while (true)
		{
			if (materialList != null && materialList.Length > 0 && meshrenderer != null)
			{
				if (materialIndex >= 0 && materialIndex < materialList.Length)
				{
					meshrenderer.material = materialList[materialIndex];
				}
				materialIndex = ((materialIndex < materialList.Length - 1) ? (materialIndex + 1) : 0);
			}
			yield return new WaitForSeconds(interval);
		}
	}

	public CycleMaterialOrder()
	{
		interval = 1f;
	}
}
