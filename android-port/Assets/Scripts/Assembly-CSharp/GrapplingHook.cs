using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074C")]
public class GrapplingHook : MonoBehaviour
{
	[Token(Token = "0x200074D")]
	public enum HookTypeEnum
	{
		[Token(Token = "0x40026B2")]
		Hitscan = 0,
		[Token(Token = "0x40026B3")]
		Physics = 1
	}

	[Serializable]
	[Token(Token = "0x200074E")]
	public class RopeJoint
	{
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x10")]
		public Vector3? LineDrawPoint;

		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 Point;

		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 Normal;

		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x38")]
		public bool StartOfNewRope;

		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x40")]
		public LineRenderer Line;

		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x48")]
		public SimplePortal EndPortal;

		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x50")]
		public SimplePortal StartPortal;

		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x17B8398", Offset = "0x17B8398", VA = "0x17B8398")]
		public RopeJoint()
		{
		}
	}

	[Token(Token = "0x200074F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41300", Offset = "0x41300")]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x10")]
		public PortalPackage package;

		[Token(Token = "0x60021B2")]
		[Address(RVA = "0x17B82B0", Offset = "0x17B82B0", VA = "0x17B82B0")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x60021B3")]
		[Address(RVA = "0x17B82B8", Offset = "0x17B82B8", VA = "0x17B82B8")]
		internal bool _003COriginEnteredPortal_003Eb__0(RopeJoint j)
		{
			return default;
		}

		[Token(Token = "0x60021B4")]
		[Address(RVA = "0x17B8328", Offset = "0x17B8328", VA = "0x17B8328")]
		internal bool _003COriginEnteredPortal_003Eb__1(RopeJoint j)
		{
			return default;
		}
	}

	[Token(Token = "0x400269B")]
	[FieldOffset(Offset = "0x18")]
	public HookTypeEnum HookType;

	[Token(Token = "0x400269C")]
	[FieldOffset(Offset = "0x1C")]
	public float PullStrength;

	[Token(Token = "0x400269D")]
	[FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x400269E")]
	[FieldOffset(Offset = "0x24")]
	public bool HasHitSomething;

	[Token(Token = "0x400269F")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody DraggingObject;

	[Token(Token = "0x40026A0")]
	[FieldOffset(Offset = "0x30")]
	public LayerMask HitLayers;

	[Token(Token = "0x40026A1")]
	[FieldOffset(Offset = "0x34")]
	public LayerMask DragLayers;

	[Token(Token = "0x40026A2")]
	[FieldOffset(Offset = "0x38")]
	public float DragSmashDistance;

	[Token(Token = "0x40026A3")]
	[FieldOffset(Offset = "0x3C")]
	public float LookAheadDistance;

	[Token(Token = "0x40026A4")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4E9AC", Offset = "0x4E9AC")]
	public float InheritVelocity;

	[Token(Token = "0x40026A5")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 LineOffset;

	[Token(Token = "0x40026A6")]
	[FieldOffset(Offset = "0x50")]
	public Action<Rigidbody> OnCollided;

	[Token(Token = "0x40026A7")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Test;

	[Token(Token = "0x40026A8")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rigid;

	[Token(Token = "0x40026A9")]
	[FieldOffset(Offset = "0x68")]
	private LineRenderer line;

	[Token(Token = "0x40026AA")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 origin;

	[Token(Token = "0x40026AB")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 originVelocityWhenFired;

	[Token(Token = "0x40026AC")]
	[FieldOffset(Offset = "0x88")]
	public List<RopeJoint> ropeJoints;

	[Token(Token = "0x40026AD")]
	[FieldOffset(Offset = "0x90")]
	private float ignoreCollisionTimer;

	[Token(Token = "0x40026AE")]
	[FieldOffset(Offset = "0x98")]
	private FixedJoint joint;

	[Token(Token = "0x40026AF")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 lastValidPoint;

	[Token(Token = "0x40026B0")]
	[FieldOffset(Offset = "0xAC")]
	private bool hitPortalThisFrame;

	[Token(Token = "0x600219D")]
	[Address(RVA = "0x14AF4B4", Offset = "0x14AF4B4", VA = "0x14AF4B4")]
	public void Init()
	{
	}

	[Token(Token = "0x600219E")]
	[Address(RVA = "0x14AF618", Offset = "0x14AF618", VA = "0x14AF618")]
	public void FireHook(Vector3 position, Vector3 direction, Vector3 originVelocity, float RopeLength)
	{
	}

	[Token(Token = "0x600219F")]
	[Address(RVA = "0x14AFF60", Offset = "0x14AFF60", VA = "0x14AFF60")]
	public void SetOrigin(Vector3 pos)
	{
	}

	[Token(Token = "0x60021A0")]
	[Address(RVA = "0x14B00F8", Offset = "0x14B00F8", VA = "0x14B00F8")]
	public void MoveHook()
	{
	}

	[Token(Token = "0x60021A1")]
	[Address(RVA = "0x14B0DC4", Offset = "0x14B0DC4", VA = "0x14B0DC4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60021A2")]
	[Address(RVA = "0x14B0E04", Offset = "0x14B0E04", VA = "0x14B0E04")]
	private void Update()
	{
	}

	[Token(Token = "0x60021A3")]
	[Address(RVA = "0x14AFB88", Offset = "0x14AFB88", VA = "0x14AFB88")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60021A4")]
	[Address(RVA = "0x14B06A4", Offset = "0x14B06A4", VA = "0x14B06A4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60021A5")]
	[Address(RVA = "0x14B08F4", Offset = "0x14B08F4", VA = "0x14B08F4")]
	private void FindPathToOrigin()
	{
	}

	[Token(Token = "0x60021A6")]
	[Address(RVA = "0x14B0E0C", Offset = "0x14B0E0C", VA = "0x14B0E0C")]
	public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 end, Vector3 point)
	{
		return default;
	}

	[Token(Token = "0x60021A7")]
	[Address(RVA = "0x14B0FD4", Offset = "0x14B0FD4", VA = "0x14B0FD4")]
	public void ThrowDraggingObject(Vector3 velocity)
	{
	}

	[Token(Token = "0x60021A8")]
	[Address(RVA = "0x14B101C", Offset = "0x14B101C", VA = "0x14B101C")]
	public RopeJoint GetPullPoint()
	{
		return null;
	}

	[Token(Token = "0x60021A9")]
	[Address(RVA = "0x14B10A4", Offset = "0x14B10A4", VA = "0x14B10A4")]
	public float GetRopeLength()
	{
		return default;
	}

	[Token(Token = "0x60021AA")]
	[Address(RVA = "0x14B12D4", Offset = "0x14B12D4", VA = "0x14B12D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60021AB")]
	[Address(RVA = "0x14AF96C", Offset = "0x14AF96C", VA = "0x14AF96C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60021AC")]
	[Address(RVA = "0x14B0EE4", Offset = "0x14B0EE4", VA = "0x14B0EE4")]
	private void RemoveJoint(RopeJoint joint)
	{
	}

	[Token(Token = "0x60021AD")]
	[Address(RVA = "0x14B12D8", Offset = "0x14B12D8", VA = "0x14B12D8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60021AE")]
	[Address(RVA = "0x14B1430", Offset = "0x14B1430", VA = "0x14B1430")]
	public void OriginEnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x60021AF")]
	[Address(RVA = "0x14B1870", Offset = "0x14B1870", VA = "0x14B1870")]
	private void EnteredPortal(PortalPackage package)
	{
	}

	[Token(Token = "0x60021B0")]
	[Address(RVA = "0x14B1B3C", Offset = "0x14B1B3C", VA = "0x14B1B3C")]
	public GrapplingHook()
	{
	}
}
