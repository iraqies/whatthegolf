using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000862")]
public class SpiderLegs : MonoBehaviour
{
	[Token(Token = "0x2000863")]
	private class LegInfo
	{
		[Token(Token = "0x4002DA2")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody LegRigid;

		[Token(Token = "0x4002DA3")]
		[FieldOffset(Offset = "0x18")]
		public LineRenderer Line;

		[Token(Token = "0x4002DA4")]
		[FieldOffset(Offset = "0x20")]
		public Transform Foot;

		[Token(Token = "0x4002DA5")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 FootTarget;

		[Token(Token = "0x4002DA6")]
		[FieldOffset(Offset = "0x34")]
		public Vector3? LegTarget;

		[Token(Token = "0x4002DA7")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 OrigPosition;

		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0x50")]
		public float ForceRepositionTimer;

		[Token(Token = "0x4002DA9")]
		[FieldOffset(Offset = "0x54")]
		public float RepositionTimer;

		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x1859500", Offset = "0x1859500", VA = "0x1859500")]
		public LegInfo()
		{
		}
	}

	[Token(Token = "0x4002D83")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve DragCurveOnShot;

	[Token(Token = "0x4002D84")]
	[FieldOffset(Offset = "0x20")]
	public bool changeDrag;

	[Token(Token = "0x4002D85")]
	[FieldOffset(Offset = "0x28")]
	public List<Rigidbody> Legs;

	[Token(Token = "0x4002D86")]
	[FieldOffset(Offset = "0x30")]
	public float MaxFeetFromLegDistance;

	[Token(Token = "0x4002D87")]
	[FieldOffset(Offset = "0x34")]
	public float FeetSpread;

	[Token(Token = "0x4002D88")]
	[FieldOffset(Offset = "0x38")]
	public float FeetSpreadVelocity;

	[Token(Token = "0x4002D89")]
	[FieldOffset(Offset = "0x3C")]
	public float FeetMoveSpeed;

	[Token(Token = "0x4002D8A")]
	[FieldOffset(Offset = "0x40")]
	public float FeetMoveSpeedVelocityMod;

	[Token(Token = "0x4002D8B")]
	[FieldOffset(Offset = "0x44")]
	public float test;

	[Token(Token = "0x4002D8C")]
	[FieldOffset(Offset = "0x48")]
	public float test2;

	[Token(Token = "0x4002D8D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject footTemplate;

	[Token(Token = "0x4002D8E")]
	[FieldOffset(Offset = "0x58")]
	public int LegJoints;

	[Token(Token = "0x4002D8F")]
	[FieldOffset(Offset = "0x5C")]
	public float Height;

	[Token(Token = "0x4002D90")]
	[FieldOffset(Offset = "0x60")]
	public float CustomGravity;

	[Token(Token = "0x4002D91")]
	[FieldOffset(Offset = "0x68")]
	public Transform CustomUp;

	[Token(Token = "0x4002D92")]
	[FieldOffset(Offset = "0x70")]
	public float CustomUpFollowSpeed;

	[Token(Token = "0x4002D93")]
	[FieldOffset(Offset = "0x74")]
	public float RepositionTimerMod;

	[Token(Token = "0x4002D94")]
	[FieldOffset(Offset = "0x78")]
	public float ForceRepositionTimerMod;

	[Token(Token = "0x4002D95")]
	[FieldOffset(Offset = "0x80")]
	private List<LegInfo> LegInfos;

	[Token(Token = "0x4002D96")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 origGravity;

	[Token(Token = "0x4002D97")]
	[FieldOffset(Offset = "0x98")]
	private ConstantForce customGravity;

	[Token(Token = "0x4002D98")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 velocityLastFrame;

	[Token(Token = "0x4002D99")]
	[FieldOffset(Offset = "0xB0")]
	private Collider currentGravityCollider;

	[Token(Token = "0x4002D9A")]
	[FieldOffset(Offset = "0xB8")]
	private float dragOnShotTimer;

	[Token(Token = "0x4002D9B")]
	[FieldOffset(Offset = "0xBC")]
	private float originalDrag;

	[Token(Token = "0x4002D9C")]
	[FieldOffset(Offset = "0xC0")]
	private Transform cachedTrans;

	[Token(Token = "0x4002D9D")]
	[FieldOffset(Offset = "0xC8")]
	private Collider[] overlapCols;

	[Token(Token = "0x4002D9E")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 lastColliderPosition;

	[Token(Token = "0x4002D9F")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 colliderMoveDelta;

	[Token(Token = "0x4002DA0")]
	[FieldOffset(Offset = "0xE8")]
	private Rigidbody rigidbodyC;

	[Token(Token = "0x4002DA1")]
	[FieldOffset(Offset = "0xF0")]
	public bool IsFlying;

	[Token(Token = "0x60026A1")]
	[Address(RVA = "0x16D2F4C", Offset = "0x16D2F4C", VA = "0x16D2F4C")]
	private void Start()
	{
	}

	[Token(Token = "0x60026A2")]
	[Address(RVA = "0x16D3474", Offset = "0x16D3474", VA = "0x16D3474")]
	public void Reset()
	{
	}

	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x16D3708", Offset = "0x16D3708", VA = "0x16D3708")]
	public void ToggleLegs(bool state)
	{
	}

	[Token(Token = "0x60026A4")]
	[Address(RVA = "0x16D37E0", Offset = "0x16D37E0", VA = "0x16D37E0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60026A5")]
	[Address(RVA = "0x16D449C", Offset = "0x16D449C", VA = "0x16D449C")]
	public bool IsGrounded()
	{
		return default;
	}

	[Token(Token = "0x60026A6")]
	[Address(RVA = "0x16D4574", Offset = "0x16D4574", VA = "0x16D4574")]
	public bool CanMove(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x60026A7")]
	[Address(RVA = "0x16D459C", Offset = "0x16D459C", VA = "0x16D459C")]
	public void Move(Vector3 boost)
	{
	}

	[Token(Token = "0x60026A8")]
	[Address(RVA = "0x16D4610", Offset = "0x16D4610", VA = "0x16D4610")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x60026A9")]
	[Address(RVA = "0x16D4880", Offset = "0x16D4880", VA = "0x16D4880")]
	private void OnCollisionExit(Collision col)
	{
	}

	[Token(Token = "0x60026AA")]
	[Address(RVA = "0x16D4C70", Offset = "0x16D4C70", VA = "0x16D4C70")]
	public SpiderLegs()
	{
	}
}
