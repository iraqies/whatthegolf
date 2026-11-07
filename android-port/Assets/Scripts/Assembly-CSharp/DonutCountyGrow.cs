using System.Collections;
using UnityEngine;

public class DonutCountyGrow : MonoBehaviour
{
	public Transform holeToGrow;

	public Transform wallColliders;

	public Animator holeToAnimate;

	public float maxSize;

	public float growthFactor;

	private GameObject lastObject;

	public ParticleSystem dustFX;

	public AnimationCurve boundsSizeToGrowthSize;

	public float maxVolSize;

	public float minVolSize;

	private void OnTriggerEnter(Collider other)
	{
	}

	private IEnumerator DestroyObject(GameObject go)
	{
		return null;
	}
}
