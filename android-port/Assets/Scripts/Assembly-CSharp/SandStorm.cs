using UnityEngine;
using UnityEngine.Events;

public class SandStorm : MonoBehaviour
{
	public float WarmupDuration;

	public float SandstormTimeToFullEffect;

	public ParticleSystem SandParticles;

	public UnityEvent OnSandstormStarted;

	private bool countdownStarted;

	private bool sandstormStarted;

	private float sandstormTimer;

	private bool hasBeenInvoked;

	private void Start()
	{
	}

	private void BallOnOnShoot(Vector3 vector3)
	{
	}

	private void Update()
	{
	}
}
