using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007F8")]
public class MobilePhoneShooter : GolfBallShooterExperimental
{
	[Token(Token = "0x4002AB3")]
	[FieldOffset(Offset = "0x88")]
	public float ShakeDuration;

	[Token(Token = "0x4002AB4")]
	[FieldOffset(Offset = "0x8C")]
	public float ShakeSpeed;

	[Token(Token = "0x4002AB5")]
	[FieldOffset(Offset = "0x90")]
	public float MoveSpeed;

	[Token(Token = "0x4002AB6")]
	[FieldOffset(Offset = "0x94")]
	public Vector2 RotationAmount;

	[Token(Token = "0x4002AB7")]
	[FieldOffset(Offset = "0x9C")]
	public float ShakeDampener;

	[Token(Token = "0x4002AB8")]
	[FieldOffset(Offset = "0xA0")]
	public Material CallMaterial;

	[Token(Token = "0x4002AB9")]
	[FieldOffset(Offset = "0xA8")]
	public Material IdleMaterial;

	[Token(Token = "0x4002ABA")]
	[FieldOffset(Offset = "0xB0")]
	private MeshRenderer renderer;

	[Token(Token = "0x4002ABB")]
	[FieldOffset(Offset = "0xB8")]
	private float shakeTimer;

	[Token(Token = "0x4002ABC")]
	[FieldOffset(Offset = "0xBC")]
	private Vector3 currentDirection;

	[Token(Token = "0x4002ABD")]
	[FieldOffset(Offset = "0xC8")]
	private Quaternion startRot;

	[Token(Token = "0x4002ABE")]
	[FieldOffset(Offset = "0xD8")]
	private Quaternion endRot;

	[Token(Token = "0x6002497")]
	[Address(RVA = "0x156912C", Offset = "0x156912C", VA = "0x156912C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002498")]
	[Address(RVA = "0x1569194", Offset = "0x1569194", VA = "0x1569194")]
	private new void FixedUpdate()
	{
	}

	[Token(Token = "0x6002499")]
	[Address(RVA = "0x1569300", Offset = "0x1569300", VA = "0x1569300", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600249A")]
	[Address(RVA = "0x15693D0", Offset = "0x15693D0", VA = "0x15693D0")]
	public MobilePhoneShooter()
	{
	}
}
