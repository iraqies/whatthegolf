using Core;
using UnityEngine;

public class HoleShooter : GolfBallShooterBase
{
	[SerializeField]
	private float startUpForce;

	[SerializeField]
	private float startForwardForce;

	[SerializeField]
	private Collider croundCollider;

	[SerializeField]
	private ParticleSystem breakFreeParticles;

	[SerializeField]
	private float minShootVelocity;

	[SerializeField]
	private float fullShootVelocity;

	[SerializeField]
	private float pitch;

	[SerializeField]
	private float spin;

	[SerializeField]
	private Transform newArrowPosition;

	private Collider col;

	private bool firstShot;

	private Transform firstShotArrowPosition;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	public override void OnReset()
	{
	}
}
