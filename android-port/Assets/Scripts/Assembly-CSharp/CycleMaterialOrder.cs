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
	}

	private IEnumerator ChangeMaterial()
	{
		return null;
	}
}
