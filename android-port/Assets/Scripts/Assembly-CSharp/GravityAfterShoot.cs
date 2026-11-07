using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000777")]
public class GravityAfterShoot : MonoBehaviour
{
	[Token(Token = "0x4002784")]
	[FieldOffset(Offset = "0x18")]
	public float gravity;

	[Token(Token = "0x4002785")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 gravityDirection;

	[Token(Token = "0x4002786")]
	[FieldOffset(Offset = "0x28")]
	public float drag;

	[Token(Token = "0x4002787")]
	[FieldOffset(Offset = "0x2C")]
	private bool useGravity;

	[Token(Token = "0x4002788")]
	[FieldOffset(Offset = "0x30")]
	private BallShooter shooter;

	[Token(Token = "0x4002789")]
	[FieldOffset(Offset = "0x38")]
	private Ball ball;

	[Token(Token = "0x400278A")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody2D rigid;

	[Token(Token = "0x600225A")]
	[Address(RVA = "0x14B8888", Offset = "0x14B8888", VA = "0x14B8888")]
	private void Start()
	{
	}

	[Token(Token = "0x600225B")]
	[Address(RVA = "0x14B89D8", Offset = "0x14B89D8", VA = "0x14B89D8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600225C")]
	[Address(RVA = "0x14B8A50", Offset = "0x14B8A50", VA = "0x14B8A50")]
	private void Shooter_OnShoot(Vector2 obj)
	{
	}

	[Token(Token = "0x600225D")]
	[Address(RVA = "0x14B8A8C", Offset = "0x14B8A8C", VA = "0x14B8A8C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600225E")]
	[Address(RVA = "0x14B8A94", Offset = "0x14B8A94", VA = "0x14B8A94")]
	public GravityAfterShoot()
	{
	}
}
