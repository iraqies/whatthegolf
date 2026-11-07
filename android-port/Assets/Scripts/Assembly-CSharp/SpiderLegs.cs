using System.Collections.Generic;
using UnityEngine;

public class SpiderLegs : MonoBehaviour
{
	private class LegInfo
	{
		public Rigidbody LegRigid;

		public LineRenderer Line;

		public Transform Foot;

		public Vector3 FootTarget;

		public Vector3? LegTarget;

		public Vector3 OrigPosition;

		public float ForceRepositionTimer;

		public float RepositionTimer;
	}

	public AnimationCurve DragCurveOnShot;

	public bool changeDrag;

	public List<Rigidbody> Legs;

	public float MaxFeetFromLegDistance;

	public float FeetSpread;

	public float FeetSpreadVelocity;

	public float FeetMoveSpeed;

	public float FeetMoveSpeedVelocityMod;

	public float test;

	public float test2;

	public GameObject footTemplate;

	public int LegJoints;

	public float Height;

	public float CustomGravity;

	public Transform CustomUp;

	public float CustomUpFollowSpeed;

	public float RepositionTimerMod;

	public float ForceRepositionTimerMod;

	private List<LegInfo> LegInfos;

	private Vector3 origGravity;

	private ConstantForce customGravity;

	private Vector3 velocityLastFrame;

	private Collider currentGravityCollider;

	private float dragOnShotTimer;

	private float originalDrag;

	private Transform cachedTrans;

	private Collider[] overlapCols;

	private Vector3 lastColliderPosition;

	private Vector3 colliderMoveDelta;

	private Rigidbody rigidbodyC;

	public bool IsFlying;

	private void Start()
	{
	}

	public void Reset()
	{
	}

	public void ToggleLegs(bool state)
	{
	}

	private void FixedUpdate()
	{
	}

	public bool IsGrounded()
	{
		return false;
	}

	public bool CanMove(Vector3 boost)
	{
		return false;
	}

	public void Move(Vector3 boost)
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}

	private void OnCollisionExit(Collision col)
	{
	}
}
