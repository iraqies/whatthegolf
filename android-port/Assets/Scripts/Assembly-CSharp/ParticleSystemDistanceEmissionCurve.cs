using UnityEngine;

public class ParticleSystemDistanceEmissionCurve : MonoBehaviour
{
	public float minRate;

	public float maxRate;

	public float minDistance;

	public float maxDistance;

	private ParticleSystem.EmissionModule emissionModule;

	private Vector3 prevPos;

	private void Start()
	{
		ParticleSystem ps = GetComponent<ParticleSystem>();
		if (ps != null)
			emissionModule = ps.emission;
		prevPos = transform.position;
	}

	private void Update()
	{
		float speed = Time.deltaTime > 0f ? Vector3.Distance(transform.position, prevPos) / Time.deltaTime : 0f;
		prevPos = transform.position;
		float t = maxDistance > minDistance ? Mathf.InverseLerp(minDistance, maxDistance, speed) : 1f;
		emissionModule.rateOverDistanceMultiplier = Mathf.Lerp(minRate, maxRate, t);
	}
}
