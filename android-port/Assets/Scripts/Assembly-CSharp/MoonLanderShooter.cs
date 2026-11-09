using Audio;
using Core;
using UnityEngine;

public class MoonLanderShooter : ShooterBase
{
	[SerializeField]
	private float thrust;

	[SerializeField]
	private float horizontalThrustRatio;

	[SerializeField]
	private float engineLocation;

	[SerializeField]
	private Rigidbody2D rigidbody2D;

	[SerializeField]
	private AudioSource leftAudioSource;

	[SerializeField]
	private AudioSource rightAudioSource;

	[SerializeField]
	private Transform leftFlameTransform;

	[SerializeField]
	private Transform rightFlameTransform;

	[SerializeField]
	private AnimationCurve flameScaleCurve;

	[SerializeField]
	private RandomAudioClips crashClips;

	[SerializeField]
	private Transform feetRoot;

	private float left;

	private float right;

	private float left_target;

	private float right_target;

	private float thrustChangeUp;

	private float thrustChangeDown;

	private float frameRotationRange;

	private float thrustDuration;

	private float timer;

	private float minThrust;

	private float explosionForce;

	private Level level;

	private void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	public void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void Crash()
	{
	}
}
