using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20008A6")]
public class HorsebackShooter2D : GolfBall2DShooterBase
{
	[Token(Token = "0x4002F81")]
	[FieldOffset(Offset = "0x48")]
	public Transform ShootOrigin;

	[Token(Token = "0x4002F82")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ProjectilePrefab;

	[Token(Token = "0x4002F83")]
	[FieldOffset(Offset = "0x58")]
	public Rigidbody2D Limb;

	[Token(Token = "0x4002F84")]
	[FieldOffset(Offset = "0x60")]
	public bool rotate;

	[Token(Token = "0x4002F85")]
	[FieldOffset(Offset = "0x68")]
	private ObjectPool<GameObject> projectiles;

	[Token(Token = "0x4002F86")]
	[FieldOffset(Offset = "0x70")]
	private Rigidbody2D[] childLimbs;

	[Token(Token = "0x60027F7")]
	[Address(RVA = "0x14D9468", Offset = "0x14D9468", VA = "0x14D9468", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60027F8")]
	[Address(RVA = "0x14D94D0", Offset = "0x14D94D0", VA = "0x14D94D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60027F9")]
	[Address(RVA = "0x14D9558", Offset = "0x14D9558", VA = "0x14D9558", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60027FA")]
	[Address(RVA = "0x14D9698", Offset = "0x14D9698", VA = "0x14D9698", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60027FB")]
	[Address(RVA = "0x14D9804", Offset = "0x14D9804", VA = "0x14D9804")]
	public HorsebackShooter2D()
	{
	}
}
