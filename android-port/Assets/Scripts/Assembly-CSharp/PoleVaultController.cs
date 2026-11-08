using System;
using System.Collections.Generic;
using Audio;
using Core;
using RootMotion.Dynamics;
using UnityEngine;

public class PoleVaultController : GolfBallShooterBase
{
	[Serializable]
	public struct OneshotTime
	{
		public float delay;

		public ClipSettingsCollection sfx;
	}

	public Joint HandJoint;

	public HingeJoint PoleJoint;

	public HingeJoint PoleAnchor;

	public float MinTargetVelocity;

	public float MaxTargetVelocity;

	public PuppetMaster PoleVaulter;

	public bool SpawnFakeArrowOnShoot;

	public Transform FakeArrowParent;

	public bool CanShootAgainAfterGettingUp;

	public float ReleasePoleThreshold;

	public bool ReleaseWhenAboutToGetUp;

	public Collider PoleCollider;

	public bool IgnoreBoundsAfterAnchored;

	public ClipSettingsCollection ReleaseClip;

	public List<OneshotTime> oneshotsOnVault;

	private float target;

	private bool hasShot;

	private Quaternion startRot;

	private Vector3 startOffset;

	private Vector3 anchor;

	private Rigidbody hingeJointConnectedBody;

	private GameObject handJointGameObject;

	private PuppetAutoRun puppet;

	private GameObject fakeArrow;

	protected override void Awake()
	{
	base.Awake();
	}

	private void Start()
	{
	}

	public void OnRegainBalance()
	{
	}

	public void AboutToGetUp()
	{
	}

	private void OnShootArrowInitialized(ShootArrow arrow)
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	private void SetJointMotorTargetVel(float val)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
