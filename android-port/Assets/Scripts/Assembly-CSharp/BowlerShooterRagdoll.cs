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

	public bool UseJoint;

	public bool DisableOnStart;

	public Rigidbody NonJointRigid;

	private Rigidbody rigid;

	private CBFollow follow;

	private ConfigurableJoint joint;

	private BowlingShooter shooter;

	protected override void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void ControllerOnOnShoot(Vector3 vector3)
	{
	}

	public override void OnShoot(Vector3 dir)
	{
	}
}
