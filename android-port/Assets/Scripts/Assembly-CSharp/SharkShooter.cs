using System.Collections;
using Audio;
using Buoyancy;
using Core;
using MPuppet;
using UnityEngine;

public class SharkShooter : GolfBallShooterBase
{
	[SerializeField]
	private float speedMultiplierWhileGrabbing;

	[SerializeField]
	private float turnSpeed;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private Animator horseAnimator;

	[SerializeField]
	private Rigidbody headRigid;

	[SerializeField]
	private bool useSetVelocity;

	[SerializeField]
	private float maxShootForce;

	[SerializeField]
	private float maxShootForceUp;

	[SerializeField]
	private JointDriveSettings grabJointDriveSettings;

	[SerializeField]
	private JointDriveSettings defaultJointDriveSettings;

	[SerializeField]
	private ConfigurableJoint[] neckAndHeadJoints;

	[SerializeField]
	private ClipSettingsCollection sfxOnGrab;

	[SerializeField]
	private ClipSettingsCollection sfxOnShoot;

	[SerializeField]
	private ClipSettingsCollection sfxHorse;

	private SharkGrab currentlyGrabbed;

	private Vector3 lastBoost;

	private Vector3 velocity;

	protected override void Awake()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void FixedUpdate()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void Throw(Vector3 boost)
	{
	}

	private void Grab(SharkGrab grab)
	{
	}

	private IEnumerator DeactivateBuoyancyOnGrabObject(RealisticFloatingProp floater, float duration)
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void SetNeckDrive(JointDriveSettings driveSettings)
	{
	}
}
