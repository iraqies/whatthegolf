using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class MooseController : GolfBallShooterBase
{
	public float MoveSpeed = 1f;

	public float RotateSpeed = 10f;

	public float HeightCheck;

	public LayerMask GroundLayer;

	public float RunSpeed = 1f;

	public List<MooseLegJoint> Joints;

	public List<SpringJoint> CarryJoints;

	public Rigidbody Moose;

	public Rigidbody MooseHead;

	public float ShootForce = 10f;

	public OutOfBoundsTrigger OutOfBoundsTrigger;

	private Vector3 boost;

	private Dictionary<SpringJoint, float> springJointSettings;

	private Vector3 offset;

	private bool grounded;

	private List<Rigidbody> MooseRigidbodies;

	private Vector3 lastBoost;

	protected override void Awake()
	{
		base.Awake();
		if (Joints != null)
		{
			foreach (MooseLegJoint joint in Joints)
			{
				if (joint != null)
				{
					joint.Init();
					joint.Toggle(false);
				}
			}
		}
		springJointSettings = new Dictionary<SpringJoint, float>();
		if (CarryJoints != null)
		{
			foreach (SpringJoint carryJoint in CarryJoints)
			{
				if (carryJoint != null)
				{
					springJointSettings.Add(carryJoint, carryJoint.spring);
					carryJoint.spring = 0f;
				}
			}
		}
		if (Moose != null)
		{
			offset = Moose.position - base.transform.position;
		}
		if (OutOfBoundsTrigger != null)
		{
			OutOfBoundsTrigger.OnOutOfBounds += OnOutOfBounds;
		}
		if (Moose != null)
		{
			MooseRigidbodies = Moose.gameObject.GetComponentsInChildren<Rigidbody>().ToList();
		}
	}

	private void OnOutOfBounds(OutOfBoundsTrigger obj)
	{
		if (Level.Instance != null)
		{
			Level.Instance.Fail(true, true, null, 0f, true, "");
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		ToggleJoints(false);
		StartCoroutine(OneFrameWait(boost));
	}

	private IEnumerator OneFrameWait(Vector3 shootBoost)
	{
		yield return null;
		if (MooseRigidbodies != null)
		{
			foreach (Rigidbody mooseRigidbody in MooseRigidbodies)
			{
				if (mooseRigidbody != null)
				{
					mooseRigidbody.velocity = shootBoost.normalized * ShootForce;
				}
			}
		}
	}

	public override void OnAimStart()
	{
		ToggleJoints(true);
	}

	public override void OnCancel()
	{
		ToggleJoints(false);
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		this.boost = boost;
	}

	private void ToggleJoints(bool state)
	{
		if (Joints == null)
		{
			return;
		}
		foreach (MooseLegJoint joint in Joints)
		{
			if (joint != null)
			{
				joint.Toggle(state);
			}
		}
	}

	protected override void FixedUpdate()
	{
		bool flag = Physics.Raycast(base.transform.position + Vector3.up, Vector3.down, HeightCheck, GroundLayer);
		if (grounded && !flag)
		{
			grounded = false;
			ToggleJoints(false);
			if (springJointSettings != null)
			{
				foreach (KeyValuePair<SpringJoint, float> springJointSetting in springJointSettings)
				{
					if (springJointSetting.Key != null)
					{
						springJointSetting.Key.spring = 0f;
					}
				}
			}
		}
		if (!grounded && flag)
		{
			grounded = true;
			ToggleJoints(true);
			if (springJointSettings != null)
			{
				foreach (KeyValuePair<SpringJoint, float> springJointSetting2 in springJointSettings)
				{
					if (springJointSetting2.Key != null)
					{
						springJointSetting2.Key.spring = springJointSetting2.Value;
					}
				}
			}
		}
		if (grounded && Controller != null && Controller.IsAiming)
		{
			if (Joints != null)
			{
				foreach (MooseLegJoint joint in Joints)
				{
					if (joint != null)
					{
						joint.UpdateJoint(RunSpeed);
					}
				}
			}
			if (rigid != null)
			{
				rigid.MovePosition(rigid.position + boost.normalized * (MoveSpeed * Time.deltaTime));
				rigid.MoveRotation(Quaternion.RotateTowards(rigid.rotation, Quaternion.LookRotation(boost), RotateSpeed * Time.deltaTime));
			}
			if (springJointSettings != null)
			{
				foreach (KeyValuePair<SpringJoint, float> springJointSetting3 in springJointSettings)
				{
					if (springJointSetting3.Key != null)
					{
						springJointSetting3.Key.spring = springJointSetting3.Value;
					}
				}
			}
		}
		else
		{
			if (grounded && springJointSettings != null)
			{
				foreach (KeyValuePair<SpringJoint, float> springJointSetting4 in springJointSettings)
				{
					if (springJointSetting4.Key != null)
					{
						springJointSetting4.Key.spring = 0f;
					}
				}
			}
			MoveTransformToRigidbody();
		}
		Vector3 vector = (grounded ? Vector3.down : (Vector3.down * 200f));
		if (MooseRigidbodies == null)
		{
			return;
		}
		foreach (Rigidbody mooseRigidbody in MooseRigidbodies)
		{
			if (mooseRigidbody != null)
			{
				mooseRigidbody.AddForce((vector + boost * 750f) * Time.fixedDeltaTime);
			}
		}
	}

	private void MoveTransformToRigidbody()
	{
		if (Moose != null)
		{
			base.transform.position = new Vector3(Moose.position.x - offset.x, base.transform.position.y, Moose.position.z - offset.z);
			if (MooseHead != null)
			{
				Vector3 normalized = new Vector3(MooseHead.position.x - Moose.position.x, 0f, MooseHead.position.z - Moose.position.z).normalized;
				base.transform.rotation = Quaternion.LookRotation(normalized, Vector3.up);
			}
		}
	}
}
