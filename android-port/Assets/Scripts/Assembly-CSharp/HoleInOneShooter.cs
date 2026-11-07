using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000781")]
public class HoleInOneShooter : MonoBehaviour
{
	[Token(Token = "0x40027B0")]
	[FieldOffset(Offset = "0x18")]
	public bool reflect;

	[Token(Token = "0x40027B1")]
	[FieldOffset(Offset = "0x1C")]
	public float speed;

	[Token(Token = "0x40027B2")]
	[FieldOffset(Offset = "0x20")]
	public BallShooter shooter;

	[Token(Token = "0x40027B3")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody2D rigid;

	[Token(Token = "0x600227F")]
	[Address(RVA = "0x14CF464", Offset = "0x14CF464", VA = "0x14CF464")]
	private void Start()
	{
	}

	[Token(Token = "0x6002280")]
	[Address(RVA = "0x14CF56C", Offset = "0x14CF56C", VA = "0x14CF56C")]
	private void Shooter_OnShoot(Vector2 dir)
	{
	}

	[Token(Token = "0x6002281")]
	[Address(RVA = "0x14CF5E0", Offset = "0x14CF5E0", VA = "0x14CF5E0")]
	public HoleInOneShooter()
	{
	}
}
