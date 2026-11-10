using System.Collections;
using CameraStack;
using Core;
using UnityEngine;

public class BowlerShooterRagdoll : GolfBallShooterBase
{
	public GolfBallController OriginalController;

	public Rigidbody HandRigid;

	public float Velocity;

	public float Pitch;

	public float Spin;

	public Transform Anchor;

	public bool UseJoint = true;

	public bool DisableOnStart = true;

	public Rigidbody NonJointRigid;

	private new Rigidbody rigid;

	private CBFollow follow;

	private ConfigurableJoint joint;

	private BowlingShooter shooter;

	protected override void Awake()
	{
		base.Awake();
		rigid = GetComponent<Rigidbody>();
		if (OriginalController != null)
		{
			shooter = OriginalController.gameObject.GetComponent<BowlingShooter>();
		}
	}

	private IEnumerator Start()
	{
		if (OriginalController != null)
		{
			OriginalController.OnShoot += ControllerOnOnShoot;
		}
		if (CameraManager.Instance != null)
		{
			follow = CameraManager.Instance.CurrentBehaviour as CBFollow;
		}
		yield return null;
		if (DisableOnStart && GolfBallController != null)
		{
			GolfBallController.enabled = false;
		}
	}

	private void Update()
	{
		if (joint != null)
		{
			if (joint.connectedBody != null && Anchor != null)
			{
				joint.connectedAnchor = joint.connectedBody.transform.InverseTransformPoint(Anchor.position);
			}
			if (HandRigid != null && rigid != null)
			{
				Vector3 dir = HandRigid.position - base.transform.position;
				if (dir != Vector3.zero)
				{
					rigid.MoveRotation(Quaternion.LookRotation(dir));
				}
			}
		}
		if (shooter != null)
		{
			shooter.EvaluateShot();
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (!UseJoint && NonJointRigid != null && rigid != null)
		{
			NonJointRigid.MovePosition(rigid.position);
		}
	}

	private void ControllerOnOnShoot(Vector3 vector3)
	{
		if (OriginalController != null)
		{
			OriginalController.StopAiming();
			OriginalController.enabled = false;
		}
		if (GolfBallController != null)
		{
			GolfBallController.enabled = true;
		}
		if (UseJoint && HandRigid != null)
		{
			base.transform.LookAt(HandRigid.position);
			joint = HandRigid.gameObject.AddComponent<ConfigurableJoint>();
			if (joint != null)
			{
				joint.connectedBody = rigid;
				joint.xMotion = ConfigurableJointMotion.Locked;
				joint.yMotion = ConfigurableJointMotion.Locked;
				joint.zMotion = ConfigurableJointMotion.Locked;
				joint.projectionMode = JointProjectionMode.PositionAndRotation;
				joint.enablePreprocessing = false;
				joint.anchor = new Vector3(0f, -1.3f, 0f);
				joint.projectionDistance = 0.1f;
				joint.projectionAngle = 180f;
				joint.autoConfigureConnectedAnchor = false;
				joint.connectedMassScale = 1E-05f;
			}
		}
		if (OriginalController != null)
		{
			ToggleGenericRagdoll ragdoll = OriginalController.gameObject.GetComponent<ToggleGenericRagdoll>();
			if (ragdoll != null)
			{
				ragdoll.RagdollOn();
			}
			BowlingShooter bowlShooter = OriginalController.gameObject.GetComponent<BowlingShooter>();
			if (bowlShooter != null)
			{
				bowlShooter.enabled = false;
			}
		}
		if (rigid != null)
		{
			rigid.isKinematic = false;
			rigid.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		}
		if (follow != null)
		{
			follow.FollowTarget = base.transform;
		}
	}

	public override void OnShoot(Vector3 dir)
	{
		Vector3 axis = Vector3.Cross(dir, Vector3.up);
		Vector3 pitched = Quaternion.AngleAxis(Pitch, axis) * dir;
		base.OnShoot(pitched);
		StandardShoot(pitched, Pitch, Velocity, Spin);
	}
}
