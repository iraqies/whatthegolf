using System.Collections;
using Core;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
	public FinalLevel FinalLevel;

	public SuperGolfShooter Shooter;

	public ParticleSystem Particles;

	public Rigidbody Rigidbody;

	public float InvisibilityDuration;

	private float baseDrag;

	private float invisibilityTimer;

	private bool ignoreFirstReset;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnOnReset()
	{
	}

	private void Update()
	{
	}

	public void OnDeath(SuperGolfShooter obj)
	{
	}

	public void OnDeath(GolfBallController obj)
	{
	}

	private IEnumerator FreezeFrame()
	{
		return null;
	}
}
