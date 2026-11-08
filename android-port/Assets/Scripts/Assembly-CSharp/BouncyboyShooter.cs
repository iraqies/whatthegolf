using System;
using Core;
using UnityEngine;

public class BouncyboyShooter : GolfBall2DShooterBase
{
	[Serializable]
	public class Leg
	{
		public Transform transform;

		public float rotationDirection;
	}

	[SerializeField]
	private float minShootVelocity;

	[SerializeField]
	private float fullShootVelocity;

	[SerializeField]
	private float upwardsForceRatio;

	[SerializeField]
	private float MaxVelocity;

	[SerializeField]
	private float MinVerticalVelocity;

	[SerializeField]
	private float BounceRatio;

	[SerializeField]
	private CircleCollider2D feetCollider;

	public Transform LookTransform;

	public float RotateSpeed;

	[SerializeField]
	private float maxLegAngle;

	[SerializeField]
	private AnimationCurve verticalSpeedToLegAngle;

	[SerializeField]
	private Leg[] legs;

	[SerializeField]
	private AudioClip bounceAudioClip;

	private Vector3 currentDirection;

	private bool hasHitGround;

	private LayerMask groundLayer;

	private Vector2 lastVelocity;

	protected override void Awake()
	{
	base.Awake();
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
