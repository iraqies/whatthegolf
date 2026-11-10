using System.Collections;
using UnityEngine;

public class CycleMaterial : MonoBehaviour
{
	private MeshRenderer meshrenderer;

	public Material[] materialList;

	private float nextActionTime;

	public float interval;

	private int materialIndex;

	private void Start()
	{
		meshrenderer = GetComponent<MeshRenderer>();
		StartCoroutine(ChangeMaterial());
	}

	private IEnumerator ChangeMaterial()
	{
		while (true)
		{
			if (materialList != null && materialList.Length > 0 && meshrenderer != null)
			{
				meshrenderer.material = materialList[Random.Range(0, materialList.Length)];
			}
			yield return new WaitForSeconds(interval);
		}
	}

	public CycleMaterial()
	{
		interval = 1f;
	}
}
