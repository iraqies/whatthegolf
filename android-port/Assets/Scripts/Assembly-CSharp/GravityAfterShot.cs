using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000778")]
public class GravityAfterShot : MonoBehaviour
{
	[Token(Token = "0x2000779")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x414A0", Offset = "0x414A0")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x10")]
		public Collision2D collision;

		[Token(Token = "0x6002264")]
		[Address(RVA = "0x17B9270", Offset = "0x17B9270", VA = "0x17B9270")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6002265")]
		[Address(RVA = "0x17B9278", Offset = "0x17B9278", VA = "0x17B9278")]
		internal void _003COnCollisionEnter2D_003Eb__0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x400278B")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 gravityDir;

	[Token(Token = "0x400278C")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip sfxHit;

	[Token(Token = "0x400278D")]
	[FieldOffset(Offset = "0x28")]
	public float gravity;

	[Token(Token = "0x400278E")]
	[FieldOffset(Offset = "0x2C")]
	private bool useGravity;

	[Token(Token = "0x400278F")]
	[FieldOffset(Offset = "0x30")]
	public BallShooter shooter;

	[Token(Token = "0x4002790")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D rigid;

	[Token(Token = "0x600225F")]
	[Address(RVA = "0x14B8AD0", Offset = "0x14B8AD0", VA = "0x14B8AD0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002260")]
	[Address(RVA = "0x14B8BD8", Offset = "0x14B8BD8", VA = "0x14B8BD8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002261")]
	[Address(RVA = "0x14B8C50", Offset = "0x14B8C50", VA = "0x14B8C50")]
	private void Shooter_OnShoot(Vector2 obj)
	{
	}

	[Token(Token = "0x6002262")]
	[Address(RVA = "0x14B8C5C", Offset = "0x14B8C5C", VA = "0x14B8C5C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002263")]
	[Address(RVA = "0x14B8D90", Offset = "0x14B8D90", VA = "0x14B8D90")]
	public GravityAfterShot()
	{
	}
}
