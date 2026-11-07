using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20006FD")]
public class FirstPersonFisher : GolfBallShooterBase
{
	[Token(Token = "0x40024A2")]
	[FieldOffset(Offset = "0x60")]
	public float SleepVelocity;

	[Token(Token = "0x40024A3")]
	[FieldOffset(Offset = "0x64")]
	public float ShootInterval;

	[Token(Token = "0x40024A4")]
	[FieldOffset(Offset = "0x68")]
	public float minShootVelocity;

	[Token(Token = "0x40024A5")]
	[FieldOffset(Offset = "0x6C")]
	public float fullShootVelocity;

	[Token(Token = "0x40024A6")]
	[FieldOffset(Offset = "0x70")]
	public GameObject Bullet;

	[Token(Token = "0x40024A7")]
	[FieldOffset(Offset = "0x78")]
	public bool CanShoot;

	[Token(Token = "0x40024A8")]
	[FieldOffset(Offset = "0x80")]
	private ObjectPool<GameObject> bulletPool;

	[Token(Token = "0x40024A9")]
	[FieldOffset(Offset = "0x88")]
	private Collider collider;

	[Token(Token = "0x40024AA")]
	[FieldOffset(Offset = "0x90")]
	private GolfBallController golfControl;

	[Token(Token = "0x40024AB")]
	[FieldOffset(Offset = "0x98")]
	private Rigidbody fishingRod;

	[Token(Token = "0x40024AC")]
	[FieldOffset(Offset = "0xA0")]
	private float shootTimer;

	[Token(Token = "0x40024AD")]
	[FieldOffset(Offset = "0xA4")]
	private Vector3 shootVelocity;

	[Token(Token = "0x40024AE")]
	[FieldOffset(Offset = "0x0")]
	public static Vector3 fishingRodTop;

	[Token(Token = "0x600203B")]
	[Address(RVA = "0x14660B0", Offset = "0x14660B0", VA = "0x14660B0")]
	[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x658F8", Offset = "0x658F8")]
	private static void Init()
	{
	}

	[Token(Token = "0x600203C")]
	[Address(RVA = "0x1466108", Offset = "0x1466108", VA = "0x1466108")]
	private void Start()
	{
	}

	[Token(Token = "0x600203D")]
	[Address(RVA = "0x146621C", Offset = "0x146621C", VA = "0x146621C")]
	private void Update()
	{
	}

	[Token(Token = "0x600203E")]
	[Address(RVA = "0x14664F0", Offset = "0x14664F0", VA = "0x14664F0", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600203F")]
	[Address(RVA = "0x146676C", Offset = "0x146676C", VA = "0x146676C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x1466870", Offset = "0x1466870", VA = "0x1466870")]
	private void TryShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002041")]
	[Address(RVA = "0x1466340", Offset = "0x1466340", VA = "0x1466340")]
	private void Yank()
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0x1466B98", Offset = "0x1466B98", VA = "0x1466B98")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002043")]
	[Address(RVA = "0x1466D00", Offset = "0x1466D00", VA = "0x1466D00")]
	public FirstPersonFisher()
	{
	}
}
