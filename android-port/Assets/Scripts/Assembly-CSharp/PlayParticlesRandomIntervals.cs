using System.Collections;
using UnityEngine;

public class PlayParticlesRandomIntervals : MonoBehaviour
{
	public float minInterval = 2f;

	public float maxInterval = 6f;

	private ParticleSystem particles;

	private void OnEnable()
	{
		if (particles == null)
			particles = GetComponent<ParticleSystem>();
		StopAllCoroutines();
		StartCoroutine(PlayRoutine());
	}

	private IEnumerator PlayRoutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(Random.Range(minInterval, maxInterval));
			if (particles != null)
				particles.Play();
		}
	}
}
