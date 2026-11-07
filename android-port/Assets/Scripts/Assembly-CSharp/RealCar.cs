using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B20")]
public class RealCar : MonoBehaviour
{
	[Token(Token = "0x4003E36")]
	[FieldOffset(Offset = "0x18")]
	public List<AxleInfo> axleInfos;

	[Token(Token = "0x4003E37")]
	[FieldOffset(Offset = "0x20")]
	public float maxMotorTorque;

	[Token(Token = "0x4003E38")]
	[FieldOffset(Offset = "0x24")]
	public float maxSteeringAngle;

	[Token(Token = "0x4003E39")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4003E3A")]
	[FieldOffset(Offset = "0x30")]
	public List<Transform> WaypointRoutes;

	[Token(Token = "0x4003E3B")]
	[FieldOffset(Offset = "0x38")]
	public Transform CenterOfMass;

	[Token(Token = "0x4003E3C")]
	[FieldOffset(Offset = "0x40")]
	public float OffsetDiminissSpeed;

	[Token(Token = "0x4003E3D")]
	[FieldOffset(Offset = "0x44")]
	private float startOffset;

	[Token(Token = "0x4003E3E")]
	[FieldOffset(Offset = "0x48")]
	private float currentOffset;

	[Token(Token = "0x4003E3F")]
	[FieldOffset(Offset = "0x4C")]
	private int routeIndex;

	[Token(Token = "0x4003E40")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rigid;

	[Token(Token = "0x6003513")]
	[Address(RVA = "0x1642974", Offset = "0x1642974", VA = "0x1642974")]
	private void Start()
	{
	}

	[Token(Token = "0x6003514")]
	[Address(RVA = "0x1642C58", Offset = "0x1642C58", VA = "0x1642C58")]
	public void ResetOffset()
	{
	}

	[Token(Token = "0x6003515")]
	[Address(RVA = "0x1642E54", Offset = "0x1642E54", VA = "0x1642E54")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x6003516")]
	[Address(RVA = "0x1643294", Offset = "0x1643294", VA = "0x1643294")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003517")]
	[Address(RVA = "0x1643398", Offset = "0x1643398", VA = "0x1643398")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003518")]
	[Address(RVA = "0x16436E4", Offset = "0x16436E4", VA = "0x16436E4")]
	public RealCar()
	{
	}
}
