using Il2CppDummyDll;
using Triband.Splines;
using UnityEngine;

[Token(Token = "0x2000DF8")]
public class RideToyRoad : MonoBehaviour
{
	[Token(Token = "0x4004C0D")]
	[FieldOffset(Offset = "0x18")]
	public float maxSpeed;

	[Token(Token = "0x4004C0E")]
	[FieldOffset(Offset = "0x1C")]
	public float followSplineYdistance;

	[Token(Token = "0x4004C0F")]
	[FieldOffset(Offset = "0x20")]
	private Spline currentRoad;

	[Token(Token = "0x4004C10")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4004C11")]
	[FieldOffset(Offset = "0x30")]
	private float savedVelocity;

	[Token(Token = "0x4004C12")]
	[FieldOffset(Offset = "0x34")]
	private float dir;

	[Token(Token = "0x4004C13")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 splineDir;

	[Token(Token = "0x60041C8")]
	[Address(RVA = "0x1656DAC", Offset = "0x1656DAC", VA = "0x1656DAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60041C9")]
	[Address(RVA = "0x1656E08", Offset = "0x1656E08", VA = "0x1656E08")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60041CA")]
	[Address(RVA = "0x1657040", Offset = "0x1657040", VA = "0x1657040")]
	private void VelocityFollowsSpline()
	{
	}

	[Token(Token = "0x60041CB")]
	[Address(RVA = "0x16572E0", Offset = "0x16572E0", VA = "0x16572E0")]
	public RideToyRoad()
	{
	}
}
