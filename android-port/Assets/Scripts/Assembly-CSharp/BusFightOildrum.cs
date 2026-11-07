using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200065C")]
public class BusFightOildrum : MonoBehaviour
{
	[Token(Token = "0x40020FA")]
	[FieldOffset(Offset = "0x18")]
	public bool isRolling;

	[Token(Token = "0x40020FB")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 rollForce;

	[Token(Token = "0x40020FC")]
	[FieldOffset(Offset = "0x28")]
	private ExplosionBarrel barrel;

	[Token(Token = "0x40020FD")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x40020FE")]
	[FieldOffset(Offset = "0x38")]
	private float stillTime;

	[Token(Token = "0x40020FF")]
	[FieldOffset(Offset = "0x3C")]
	private bool didExplode;

	[Token(Token = "0x6001D16")]
	[Address(RVA = "0x17D6320", Offset = "0x17D6320", VA = "0x17D6320")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001D17")]
	[Address(RVA = "0x17D6420", Offset = "0x17D6420", VA = "0x17D6420")]
	private void Barrel_OnExplode(Collider col, ExplosionBarrel barrel)
	{
	}

	[Token(Token = "0x6001D18")]
	[Address(RVA = "0x17D69B0", Offset = "0x17D69B0", VA = "0x17D69B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D19")]
	[Address(RVA = "0x17D6A60", Offset = "0x17D6A60", VA = "0x17D6A60")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D1A")]
	[Address(RVA = "0x17D6AE4", Offset = "0x17D6AE4", VA = "0x17D6AE4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001D1B")]
	[Address(RVA = "0x17D6C8C", Offset = "0x17D6C8C", VA = "0x17D6C8C")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001D1C")]
	[Address(RVA = "0x17D6E78", Offset = "0x17D6E78", VA = "0x17D6E78")]
	public BusFightOildrum()
	{
	}
}
