using Chronos;
using UnityEngine;

public class ParticlesOnlyWhenGrounded : MonoBehaviour
{
	public LayerMask layer;

	public float distanceToGroundThreshold;

	public bool StopInsteadOfPause;

	private ParticleSystem ps;

	private ParticleSystem.EmissionModule emission;

	private TimelineChild timeline;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
