using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayParticlesRandomIntervals : MonoBehaviour
{
	private ParticleSystem particles;

	private bool canPlay;

	public float minInterval;

	public float maxInterval;

	public UnityEvent OnPlay;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private IEnumerator PlayingParticles()
	{
		return null;
	}
}
