using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000733")]
public class EvilFlagCircle : MonoBehaviour
{
	[Token(Token = "0x400260D")]
	[FieldOffset(Offset = "0x18")]
	public Transform circleCenter;

	[Token(Token = "0x400260E")]
	[FieldOffset(Offset = "0x20")]
	public int steps;

	[Token(Token = "0x400260F")]
	[FieldOffset(Offset = "0x24")]
	public float velocity;

	[Token(Token = "0x4002610")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController ball;

	[Token(Token = "0x4002611")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002612")]
	[FieldOffset(Offset = "0x38")]
	private int currentStep;

	[Token(Token = "0x4002613")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 currentTarget;

	[Token(Token = "0x4002614")]
	[FieldOffset(Offset = "0x48")]
	private float radius;

	[Token(Token = "0x6002138")]
	[Address(RVA = "0x144AA34", Offset = "0x144AA34", VA = "0x144AA34")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002139")]
	[Address(RVA = "0x144ABE0", Offset = "0x144ABE0", VA = "0x144ABE0")]
	private Vector3 GetCirclePosition(int step, float radius, Vector3 center)
	{
		return default;
	}

	[Token(Token = "0x600213A")]
	[Address(RVA = "0x144AC50", Offset = "0x144AC50", VA = "0x144AC50")]
	private void Ball_OnShoot(Vector3 aim)
	{
	}

	[Token(Token = "0x600213B")]
	[Address(RVA = "0x144AD00", Offset = "0x144AD00", VA = "0x144AD00")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600213C")]
	[Address(RVA = "0x144AE10", Offset = "0x144AE10", VA = "0x144AE10")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600213D")]
	[Address(RVA = "0x144AFAC", Offset = "0x144AFAC", VA = "0x144AFAC")]
	public EvilFlagCircle()
	{
	}
}
