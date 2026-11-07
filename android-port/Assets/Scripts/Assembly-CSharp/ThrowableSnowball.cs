using System.Collections;
using UnityEngine;

public class ThrowableSnowball : MonoBehaviour
{
	public ParticleSystem HitParticles;

	public ParticleSystem FlyParticles;

	public TrailRenderer Trail;

	public float ShrinkTime;

	private Rigidbody rigid;

	private float baseDrag;

	public float HitShakeDuration;

	public float HitShakeSpeed;

	public float HitShakeMagnitude;

	private void Awake()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnCollisionStay(Collision other)
	{
	}

	private void OnCollisionExit(Collision other)
	{
	}

	private IEnumerator Shrink()
	{
		return null;
	}

	private IEnumerator FreezeFrame()
	{
		return null;
	}
}
