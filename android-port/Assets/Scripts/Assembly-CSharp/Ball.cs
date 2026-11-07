using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200075E")]
[Attribute(Name = "RequireComponent", RVA = "0x413B8", Offset = "0x413B8")]
public class Ball : MonoBehaviour
{
	[Token(Token = "0x4002719")]
	[FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400271A")]
	[FieldOffset(Offset = "0x1C")]
	public LayerMask layers;

	[Token(Token = "0x400271B")]
	[FieldOffset(Offset = "0x20")]
	public float minSpeed;

	[Token(Token = "0x400271C")]
	[FieldOffset(Offset = "0x24")]
	public float maxSpeedMultiplier;

	[Token(Token = "0x400271D")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigid;

	[Token(Token = "0x400271E")]
	[FieldOffset(Offset = "0x30")]
	public bool adjustSpeed;

	[Token(Token = "0x400271F")]
	[FieldOffset(Offset = "0x38")]
	private BallShooter shooter;

	[Token(Token = "0x4002720")]
	[FieldOffset(Offset = "0x40")]
	private Killable killable;

	[Token(Token = "0x4002721")]
	[FieldOffset(Offset = "0x48")]
	private Winable winable;

	[Token(Token = "0x4002722")]
	[FieldOffset(Offset = "0x50")]
	private bool isMoving;

	[Token(Token = "0x4002723")]
	[FieldOffset(Offset = "0x51")]
	public bool UseMinSpeed;

	[Token(Token = "0x60021FB")]
	[Address(RVA = "0x151756C", Offset = "0x151756C", VA = "0x151756C")]
	private void Start()
	{
	}

	[Token(Token = "0x60021FC")]
	[Address(RVA = "0x1517894", Offset = "0x1517894", VA = "0x1517894")]
	private void Killable_OnKilled()
	{
	}

	[Token(Token = "0x60021FD")]
	[Address(RVA = "0x151789C", Offset = "0x151789C", VA = "0x151789C")]
	private void Winable_OnWon(Vector3 pos)
	{
	}

	[Token(Token = "0x60021FE")]
	[Address(RVA = "0x15178A4", Offset = "0x15178A4", VA = "0x15178A4")]
	private void Shooter_OnShoot(Vector2 dir)
	{
	}

	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x15178D8", Offset = "0x15178D8", VA = "0x15178D8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002200")]
	[Address(RVA = "0x1517A98", Offset = "0x1517A98", VA = "0x1517A98")]
	public Ball()
	{
	}
}
