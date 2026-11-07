using System.Collections;
using UnityEngine;

public class SetRTPCByProximity : MonoBehaviour
{
	public float minDistance;

	public float maxDistance;

	public Transform proximityFromTarget;

	public Transform[] proximityToTargets;

	private const float delay = 0.1f;

	private float currentBaseRTPC;

	private void Start()
	{
	}

	private IEnumerator SlowFixedUpdate()
	{
		return null;
	}
}
