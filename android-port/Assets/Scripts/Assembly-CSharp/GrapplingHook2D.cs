using System;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook2D : MonoBehaviour
{
	public enum HookTypeEnum
	{
		Hitscan = 0,
		Physics = 1
	}

	[Serializable]
	public class RopeJoint
	{
		public Vector2? LineDrawPoint;

		public Vector2 Point;

		public Vector2 Normal;

		public bool StartOfNewRope;

		public LineRenderer Line;

		public SimplePortal EndPortal;

		public SimplePortal StartPortal;

		public float Dot;
	}

	public HookTypeEnum HookType;

	public float PullStrength;

	public float Speed;

	public bool HasHitSomething;

	public LayerMask HitLayers;

	public LayerMask DragLayers;

	public float DragSmashDistance;

	public float LookAheadDistance;

	public float InheritVelocity;

	public Vector2 LineOffset;

	public Action<Rigidbody2D> OnCollided;

	public GameObject Test;

	private Rigidbody2D rigid;

	private LineRenderer line;

	private Vector2 origin;

	private Vector2 originVelocityWhenFired;

	public List<RopeJoint> ropeJoints;

	private float ignoreCollisionTimer;

	private FixedJoint2D joint;

	private Vector3 lastValidPoint;

	public void Init()
	{
	}

	public void FireHook(Vector2 position, Vector2 direction, Vector2 originVelocity, float RopeLength)
	{
	}

	public void SetOrigin(Vector2 pos)
	{
	}

	public void MoveHook()
	{
	}

	private void FixedUpdate()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void FindPathToOrigin()
	{
	}

	private Vector2 GetClosestColliderPointFromRaycastHit(RaycastHit2D hit, PolygonCollider2D polyCollider)
	{
		return default;
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
