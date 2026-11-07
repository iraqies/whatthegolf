using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006B4")]
public class VelocityAimBlendOrbitTarget : MonoBehaviour
{
	[Token(Token = "0x4002311")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody rigidbody;

	[Token(Token = "0x4002312")]
	[FieldOffset(Offset = "0x20")]
	public float distance;

	[Token(Token = "0x4002313")]
	[FieldOffset(Offset = "0x24")]
	public float elevation;

	[Token(Token = "0x4002314")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4002315")]
	[FieldOffset(Offset = "0x2C")]
	public float aimLengthThreshold;

	[Token(Token = "0x4002316")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve forwardToVelocityBlend;

	[Token(Token = "0x4002317")]
	[FieldOffset(Offset = "0x38")]
	public GolfBallController ball;

	[Token(Token = "0x4002318")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 aimDir;

	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x1749DF8", Offset = "0x1749DF8", VA = "0x1749DF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EE4")]
	[Address(RVA = "0x1749FF8", Offset = "0x1749FF8", VA = "0x1749FF8")]
	private void Ball_OnAimStart()
	{
	}

	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x174A03C", Offset = "0x174A03C", VA = "0x174A03C")]
	private void Ball_OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x174A094", Offset = "0x174A094", VA = "0x174A094")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x174A38C", Offset = "0x174A38C", VA = "0x174A38C")]
	public VelocityAimBlendOrbitTarget()
	{
	}
}
