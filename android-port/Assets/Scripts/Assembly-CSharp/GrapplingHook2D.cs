using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000750")]
public class GrapplingHook2D : MonoBehaviour
{
	[Token(Token = "0x2000751")]
	public enum HookTypeEnum
	{
		[Token(Token = "0x40026D1")]
		Hitscan = 0,
		[Token(Token = "0x40026D2")]
		Physics = 1
	}

	[Serializable]
	[Token(Token = "0x2000752")]
	public class RopeJoint
	{
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x10")]
		public Vector2? LineDrawPoint;

		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 Point;

		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 Normal;

		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x2C")]
		public bool StartOfNewRope;

		[Token(Token = "0x40026D7")]
		[FieldOffset(Offset = "0x30")]
		public LineRenderer Line;

		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x38")]
		public SimplePortal EndPortal;

		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x40")]
		public SimplePortal StartPortal;

		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x48")]
		public float Dot;

		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x17B8528", Offset = "0x17B8528", VA = "0x17B8528")]
		public RopeJoint()
		{
		}
	}

	[Token(Token = "0x2000753")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41310", Offset = "0x41310")]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x10")]
		public RaycastHit2D hit;

		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x38")]
		public PolygonCollider2D polyCollider;

		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x17B8450", Offset = "0x17B8450", VA = "0x17B8450")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x17B8458", Offset = "0x17B8458", VA = "0x17B8458")]
		internal float _003CGetClosestColliderPointFromRaycastHit_003Eb__0(Vector2 position)
		{
			return default;
		}

		[Token(Token = "0x60021CC")]
		[Address(RVA = "0x17B84E0", Offset = "0x17B84E0", VA = "0x17B84E0")]
		internal Vector2 _003CGetClosestColliderPointFromRaycastHit_003Eb__1(Vector2 position)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000754")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41320", Offset = "0x41320")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40026DE")]
		[FieldOffset(Offset = "0x8")]
		public static Func<KeyValuePair<float, Vector2>, float> _003C_003E9__30_2;

		[Token(Token = "0x60021CE")]
		[Address(RVA = "0x17B8400", Offset = "0x17B8400", VA = "0x17B8400")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x17B8408", Offset = "0x17B8408", VA = "0x17B8408")]
		internal float _003CGetClosestColliderPointFromRaycastHit_003Eb__30_2(KeyValuePair<float, Vector2> e)
		{
			return default;
		}
	}

	[Token(Token = "0x40026BC")]
	[FieldOffset(Offset = "0x18")]
	public HookTypeEnum HookType;

	[Token(Token = "0x40026BD")]
	[FieldOffset(Offset = "0x1C")]
	public float PullStrength;

	[Token(Token = "0x40026BE")]
	[FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40026BF")]
	[FieldOffset(Offset = "0x24")]
	public bool HasHitSomething;

	[Token(Token = "0x40026C0")]
	[FieldOffset(Offset = "0x28")]
	public LayerMask HitLayers;

	[Token(Token = "0x40026C1")]
	[FieldOffset(Offset = "0x2C")]
	public LayerMask DragLayers;

	[Token(Token = "0x40026C2")]
	[FieldOffset(Offset = "0x30")]
	public float DragSmashDistance;

	[Token(Token = "0x40026C3")]
	[FieldOffset(Offset = "0x34")]
	public float LookAheadDistance;

	[Token(Token = "0x40026C4")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4E9C4", Offset = "0x4E9C4")]
	public float InheritVelocity;

	[Token(Token = "0x40026C5")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 LineOffset;

	[Token(Token = "0x40026C6")]
	[FieldOffset(Offset = "0x48")]
	public Action<Rigidbody2D> OnCollided;

	[Token(Token = "0x40026C7")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Test;

	[Token(Token = "0x40026C8")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40026C9")]
	[FieldOffset(Offset = "0x60")]
	private LineRenderer line;

	[Token(Token = "0x40026CA")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 origin;

	[Token(Token = "0x40026CB")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 originVelocityWhenFired;

	[Token(Token = "0x40026CC")]
	[FieldOffset(Offset = "0x78")]
	public List<RopeJoint> ropeJoints;

	[Token(Token = "0x40026CD")]
	[FieldOffset(Offset = "0x80")]
	private float ignoreCollisionTimer;

	[Token(Token = "0x40026CE")]
	[FieldOffset(Offset = "0x88")]
	private FixedJoint2D joint;

	[Token(Token = "0x40026CF")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 lastValidPoint;

	[Token(Token = "0x60021B5")]
	[Address(RVA = "0x14B1B58", Offset = "0x14B1B58", VA = "0x14B1B58")]
	public void Init()
	{
	}

	[Token(Token = "0x60021B6")]
	[Address(RVA = "0x14B1CBC", Offset = "0x14B1CBC", VA = "0x14B1CBC")]
	public void FireHook(Vector2 position, Vector2 direction, Vector2 originVelocity, float RopeLength)
	{
	}

	[Token(Token = "0x60021B7")]
	[Address(RVA = "0x14B2588", Offset = "0x14B2588", VA = "0x14B2588")]
	public void SetOrigin(Vector2 pos)
	{
	}

	[Token(Token = "0x60021B8")]
	[Address(RVA = "0x14B26F8", Offset = "0x14B26F8", VA = "0x14B26F8")]
	public void MoveHook()
	{
	}

	[Token(Token = "0x60021B9")]
	[Address(RVA = "0x14B34B0", Offset = "0x14B34B0", VA = "0x14B34B0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x14B21D8", Offset = "0x14B21D8", VA = "0x14B21D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60021BB")]
	[Address(RVA = "0x14B2BFC", Offset = "0x14B2BFC", VA = "0x14B2BFC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x14B2E40", Offset = "0x14B2E40", VA = "0x14B2E40")]
	private void FindPathToOrigin()
	{
	}

	[Token(Token = "0x60021BD")]
	[Address(RVA = "0x14B34F0", Offset = "0x14B34F0", VA = "0x14B34F0")]
	private Vector2 GetClosestColliderPointFromRaycastHit(RaycastHit2D hit, PolygonCollider2D polyCollider)
	{
		return default;
	}

	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x14B38E4", Offset = "0x14B38E4", VA = "0x14B38E4")]
	public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 end, Vector3 point)
	{
		return default;
	}

	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x14B39BC", Offset = "0x14B39BC", VA = "0x14B39BC")]
	public void ThrowDraggingObject(Vector3 velocity)
	{
	}

	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x14B39E4", Offset = "0x14B39E4", VA = "0x14B39E4")]
	public RopeJoint GetPullPoint()
	{
		return null;
	}

	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x14B3A6C", Offset = "0x14B3A6C", VA = "0x14B3A6C")]
	public float GetRopeLength()
	{
		return default;
	}

	[Token(Token = "0x60021C2")]
	[Address(RVA = "0x14B3C9C", Offset = "0x14B3C9C", VA = "0x14B3C9C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60021C3")]
	[Address(RVA = "0x14B1FDC", Offset = "0x14B1FDC", VA = "0x14B1FDC")]
	private void Reset()
	{
	}

	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x14B37F4", Offset = "0x14B37F4", VA = "0x14B37F4")]
	private void RemoveJoint(RopeJoint joint)
	{
	}

	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x14B3CA0", Offset = "0x14B3CA0", VA = "0x14B3CA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x14B3DF8", Offset = "0x14B3DF8", VA = "0x14B3DF8")]
	public void OriginEnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x60021C7")]
	[Address(RVA = "0x14B40C0", Offset = "0x14B40C0", VA = "0x14B40C0")]
	private void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x60021C8")]
	[Address(RVA = "0x14B43A0", Offset = "0x14B43A0", VA = "0x14B43A0")]
	public GrapplingHook2D()
	{
	}
}
