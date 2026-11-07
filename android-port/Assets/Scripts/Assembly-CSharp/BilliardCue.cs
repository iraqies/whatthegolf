using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005F7")]
public class BilliardCue : MonoBehaviour
{
	[Token(Token = "0x4001E76")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4001E77")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x4001E78")]
	[FieldOffset(Offset = "0x24")]
	public float RotationSpeed;

	[Token(Token = "0x4001E79")]
	[FieldOffset(Offset = "0x28")]
	public float ShootDistance;

	[Token(Token = "0x4001E7A")]
	[FieldOffset(Offset = "0x2C")]
	public float ShootSpeed;

	[Token(Token = "0x4001E7B")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x4001E7C")]
	[FieldOffset(Offset = "0x38")]
	private float shootTimer;

	[Token(Token = "0x4001E7D")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 startShootPoint;

	[Token(Token = "0x4001E7E")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody ballRigid;

	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x1610F58", Offset = "0x1610F58", VA = "0x1610F58")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x161117C", Offset = "0x161117C", VA = "0x161117C")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6001B21")]
	[Address(RVA = "0x161119C", Offset = "0x161119C", VA = "0x161119C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x1611294", Offset = "0x1611294", VA = "0x1611294")]
	private void OnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x16112E8", Offset = "0x16112E8", VA = "0x16112E8")]
	private void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x161149C", Offset = "0x161149C", VA = "0x161149C")]
	public BilliardCue()
	{
	}
}
