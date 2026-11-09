using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class SkeletonShooter : GolfBallShooterBase
{
	[SerializeField]
	private float minVelocity;

	[SerializeField]
	private float fullVelocity;

	[SerializeField]
	private float fullPitch;

	[SerializeField]
	private float fullSpin;

	[SerializeField]
	private Animator golfAnimator;

	[SerializeField]
	private List<Rigidbody> skeletonParts;

	private Rigidbody[] rigidbodies;

	[SerializeField]
	private Rigidbody hips;

	private bool hasCollapsed;

	private bool isCollapsing;

	private Vector3 oldPosition;

	private Quaternion oldRotation;

	private CBFollow followCamera;

	private float mass;

	protected override void Awake()
	{
	base.Awake();
	}

	private void Update()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, fullPitch, (minVelocity > 0f ? minVelocity : 5f), (fullVelocity > 0f ? fullVelocity : 22f), fullSpin);
	}

	public override void OnReset()
	{
	}

	private Vector3 PitchBoost(Vector3 boost)
	{
		return default;
	}

	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		return null;
	}
}
