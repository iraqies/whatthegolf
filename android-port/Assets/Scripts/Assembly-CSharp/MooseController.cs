using System.Collections.Generic;
using Core;
using UnityEngine;

public class MooseController : GolfBallShooterBase
{
	public float MoveSpeed;

	public float RotateSpeed;

	public float HeightCheck;

	public LayerMask GroundLayer;

	public float RunSpeed;

	public List<MooseLegJoint> Joints;

	public List<SpringJoint> CarryJoints;

	public Rigidbody Moose;

	public Rigidbody MooseHead;

	public float ShootForce;

	public OutOfBoundsTrigger OutOfBoundsTrigger;

	private Vector3 boost;

	private Dictionary<SpringJoint, float> springJointSettings;

	private Vector3 offset;

	private bool grounded;

	private List<Rigidbody> MooseRigidbodies;

	private Vector3 lastBoost;

	protected override void Awake()
	{
	}

	private void OnOutOfBounds(OutOfBoundsTrigger obj)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	public override void OnAimStart()
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void ToggleJoints(bool state)
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void MoveTransformToRigidbody()
	{
	}
}
