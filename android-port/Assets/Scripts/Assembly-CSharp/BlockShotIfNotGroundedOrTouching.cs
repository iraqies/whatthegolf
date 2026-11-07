using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC1")]
public class BlockShotIfNotGroundedOrTouching : MonoBehaviour
{
	[Token(Token = "0x4004177")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask groundMask;

	[Token(Token = "0x4004178")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float groundDist;

	[Token(Token = "0x4004179")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 down;

	[Token(Token = "0x400417A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector3 checkOffset;

	[Token(Token = "0x400417B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float AcceptedNormalUp;

	[Token(Token = "0x400417C")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int framesNeeded;

	[Token(Token = "0x400417D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool addToControllerBlockingFunctions;

	[Token(Token = "0x400417E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Transform[] additionalTransformChecks;

	[Token(Token = "0x400417F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool is2D;

	[Token(Token = "0x4004180")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float circleCastRadius;

	[Token(Token = "0x4004181")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool useLocalDown;

	[Token(Token = "0x4004182")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	public bool isBlocked;

	[Token(Token = "0x4004183")]
	[FieldOffset(Offset = "0x60")]
	private GolfBallController controller;

	[Token(Token = "0x4004184")]
	[FieldOffset(Offset = "0x68")]
	private int frameCount;

	[Token(Token = "0x4004185")]
	[FieldOffset(Offset = "0x6C")]
	private bool isTouchingGround;

	[Token(Token = "0x4004186")]
	[FieldOffset(Offset = "0x70")]
	private List<Collider> groundContacts;

	[Token(Token = "0x60038A1")]
	[Address(RVA = "0x1613E3C", Offset = "0x1613E3C", VA = "0x1613E3C")]
	private void Start()
	{
	}

	[Token(Token = "0x60038A2")]
	[Address(RVA = "0x1613EE4", Offset = "0x1613EE4", VA = "0x1613EE4")]
	private bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x60038A3")]
	[Address(RVA = "0x16141C0", Offset = "0x16141C0", VA = "0x16141C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60038A4")]
	[Address(RVA = "0x16144E0", Offset = "0x16144E0", VA = "0x16144E0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60038A5")]
	[Address(RVA = "0x1614624", Offset = "0x1614624", VA = "0x1614624")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x60038A6")]
	[Address(RVA = "0x1614784", Offset = "0x1614784", VA = "0x1614784")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60038A7")]
	[Address(RVA = "0x16148F0", Offset = "0x16148F0", VA = "0x16148F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60038A8")]
	[Address(RVA = "0x1614A00", Offset = "0x1614A00", VA = "0x1614A00")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60038A9")]
	[Address(RVA = "0x1614BA4", Offset = "0x1614BA4", VA = "0x1614BA4")]
	public BlockShotIfNotGroundedOrTouching()
	{
	}
}
