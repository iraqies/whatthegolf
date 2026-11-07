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
	}

	private IEnumerator ChangeMaterial()
	{
		return null;
	}
}
