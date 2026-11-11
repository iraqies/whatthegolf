using System.Collections;
using Audio;
using Buoyancy;
using Core;
using MPuppet;
using UnityEngine;

public class SharkShooter : GolfBallShooterBase
{
	[SerializeField]
	private float speedMultiplierWhileGrabbing = 0.7f;

	[SerializeField]
	private float turnSpeed = 10f;

	[SerializeField]
	private float moveSpeed = 25f;

	[SerializeField]
	private Animator horseAnimator;

	[SerializeField]
	private Rigidbody headRigid;

	[SerializeField]
	private bool useSetVelocity;

	[SerializeField]
	private float maxShootForce = 25f;

	[SerializeField]
	private float maxShootForceUp = 35f;

	[SerializeField]
	private JointDriveSettings grabJointDriveSettings = new JointDriveSettings(5000f, 2f, 5000f);

	[SerializeField]
	private JointDriveSettings defaultJointDriveSettings = new JointDriveSettings(0f, 0f, 5000f);

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
		base.Awake();
		lastBoost = Vector3.forward;
		SetNeckDrive(defaultJointDriveSettings);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		lastBoost = boost;
		velocity = boost * moveSpeed;
		if (currentlyGrabbed != null)
		{
			velocity *= speedMultiplierWhileGrabbing;
		}
	}

	protected override void FixedUpdate()
	{
		if (Controller != null && Controller.IsAiming)
		{
			Quaternion to = Quaternion.LookRotation(lastBoost, Vector3.up);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, to, turnSpeed);
		}
		if (rigid != null)
		{
			rigid.velocity = velocity;
		}
		velocity = Vector3.zero;
	}

	public override void OnShoot(Vector3 boost)
	{
		SetNeckDrive(defaultJointDriveSettings);
		Throw(boost);
	}

	private void Throw(Vector3 boost)
	{
		if (!(currentlyGrabbed != null))
		{
			return;
		}
		if (sfxOnShoot != null)
		{
			sfxOnShoot.Play(base.transform.position);
		}
		SetNeckDrive(defaultJointDriveSettings);
		if (currentlyGrabbed.TryGetComponent<FixedJoint>(out var component))
		{
			Object.Destroy(component);
		}
		if (currentlyGrabbed.TryGetComponent<Rigidbody>(out var component2))
		{
			Vector3 vector = boost.normalized * boost.magnitude * maxShootForce + Vector3.up * boost.magnitude * maxShootForceUp;
			if (useSetVelocity)
			{
				component2.velocity = vector;
			}
			else
			{
				component2.AddForce(vector, ForceMode.Impulse);
			}
		}
		if (currentlyGrabbed.TryGetComponent<RealisticFloatingProp>(out var component3))
		{
			StartCoroutine(DeactivateBuoyancyOnGrabObject(component3, 0.2f));
		}
		SetNeckDrive(defaultJointDriveSettings);
		currentlyGrabbed = null;
	}

	private void Grab(SharkGrab grab)
	{
		SetNeckDrive(grabJointDriveSettings);
		if (sfxOnGrab != null)
		{
			sfxOnGrab.Play(base.transform.position);
		}
		if (sfxHorse != null)
		{
			sfxHorse.PlayDelayed(base.transform.position, 0.1f);
		}
		if (grab != null)
		{
			Collider component = grab.GetComponent<Collider>();
			if (component != null && headRigid != null)
			{
				Bounds bounds = component.bounds;
				grab.transform.position = headRigid.position + headRigid.transform.up * bounds.size.y;
			}
			FixedJoint fixedJoint = grab.gameObject.AddComponent<FixedJoint>();
			if (fixedJoint != null)
			{
				fixedJoint.connectedBody = headRigid;
			}
			currentlyGrabbed = grab;
		}
	}

	private IEnumerator DeactivateBuoyancyOnGrabObject(RealisticFloatingProp floater, float duration)
	{
		if (floater != null)
		{
			floater.active = false;
		}
		yield return new WaitForSeconds(duration);
		if (floater != null)
		{
			floater.active = true;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!(currentlyGrabbed != null) && Controller != null && Controller.IsAiming && other != null && other.TryGetComponent<SharkGrab>(out var component))
		{
			Grab(component);
		}
	}

	private void SetNeckDrive(JointDriveSettings driveSettings)
	{
		if (neckAndHeadJoints == null)
		{
			return;
		}
		for (int i = 0; i < neckAndHeadJoints.Length; i++)
		{
			if (neckAndHeadJoints[i] != null)
			{
				neckAndHeadJoints[i].angularXDrive = driveSettings.GetJointDrive();
				neckAndHeadJoints[i].angularYZDrive = driveSettings.GetJointDrive();
			}
		}
	}
}
