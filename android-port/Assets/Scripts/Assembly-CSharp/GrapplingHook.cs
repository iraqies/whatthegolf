using System;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
	public enum HookTypeEnum
	{
		Hitscan = 0,
		Physics = 1
	}

	[Serializable]
	public class RopeJoint
	{
		public Vector3? LineDrawPoint;

		public Vector3 Point;

		public Vector3 Normal;

		public bool StartOfNewRope;

		public LineRenderer Line;

		public SimplePortal EndPortal;

		public SimplePortal StartPortal;
	}

	public HookTypeEnum HookType;

	public float PullStrength;

	public float Speed;

	public bool HasHitSomething;

	public Rigidbody DraggingObject;

	public LayerMask HitLayers;

	public LayerMask DragLayers;

	public float DragSmashDistance;

	public float LookAheadDistance;

	public float InheritVelocity;

	public Vector3 LineOffset;

	public Action<Rigidbody> OnCollided;

	public GameObject Test;

	private Rigidbody rigid;

	private LineRenderer line;

	private Vector3 origin;

	private Vector3 originVelocityWhenFired;

	public List<RopeJoint> ropeJoints;

	private float ignoreCollisionTimer;

	private FixedJoint joint;

	private Vector3 lastValidPoint;

	private bool hitPortalThisFrame;

	public void Init()
	{
	}

	public void FireHook(Vector3 position, Vector3 direction, Vector3 originVelocity, float RopeLength)
	{
	}

	public void SetOrigin(Vector3 pos)
	{
	}

	public void MoveHook()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void FindPathToOrigin()
	{
	}

	public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 end, Vector3 point)
	{
		return default;
	}

	public void ThrowDraggingObject(Vector3 velocity)
	{
	}

	public RopeJoint GetPullPoint()
	{
		return null;
	}

	public float GetRopeLength()
	{
		return 0f;
	}

	private void OnDisable()
	{
	}

	private void Reset()
	{
	}

	private void RemoveJoint(RopeJoint joint)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void OriginEnteredPortal(PortalPackage package)
	{
	}

	private void EnteredPortal(PortalPackage package)
	{
	}
}
