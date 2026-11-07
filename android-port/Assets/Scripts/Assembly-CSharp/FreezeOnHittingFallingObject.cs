using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using VFX;

[Token(Token = "0x2000881")]
public class FreezeOnHittingFallingObject : MonoBehaviour
{
	[Token(Token = "0x4002E9C")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002E9D")]
	[FieldOffset(Offset = "0x20")]
	private FixedJoint joint;

	[Token(Token = "0x4002E9E")]
	[FieldOffset(Offset = "0x28")]
	private Collider collider;

	[Token(Token = "0x4002E9F")]
	[FieldOffset(Offset = "0x30")]
	private List<Collider> ignoreColliders;

	[Token(Token = "0x4002EA0")]
	[FieldOffset(Offset = "0x38")]
	private TrajectoryProjector trajectory;

	[Token(Token = "0x4002EA1")]
	[FieldOffset(Offset = "0x40")]
	private GolfBallShooterBase shooter;

	[Token(Token = "0x4002EA2")]
	[FieldOffset(Offset = "0x48")]
	private float origShootingThreshold;

	[Token(Token = "0x6002742")]
	[Address(RVA = "0x147287C", Offset = "0x147287C", VA = "0x147287C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002743")]
	[Address(RVA = "0x1472A80", Offset = "0x1472A80", VA = "0x1472A80")]
	private void InstanceOnOnOutOfBounds()
	{
	}

	[Token(Token = "0x6002744")]
	[Address(RVA = "0x1472C64", Offset = "0x1472C64", VA = "0x1472C64")]
	private void BallOnOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6002745")]
	[Address(RVA = "0x1472CF8", Offset = "0x1472CF8", VA = "0x1472CF8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002746")]
	[Address(RVA = "0x147300C", Offset = "0x147300C", VA = "0x147300C")]
	public FreezeOnHittingFallingObject()
	{
	}
}
