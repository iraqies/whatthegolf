using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000041")]
public class OrbitalController : GolfBallShooterBase
{
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x60")]
	public Transform OrbitCenter;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x68")]
	public float HeightFromCenter;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x6C")]
	public float MoveSpeed;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x70")]
	public float RotateSpeed;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x74")]
	public float Gravity;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody rigid;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 aimDir;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x159D7DC", Offset = "0x159D7DC", VA = "0x159D7DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x159D848", Offset = "0x159D848", VA = "0x159D848", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x159D8A4", Offset = "0x159D8A4", VA = "0x159D8A4", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x159D9F0", Offset = "0x159D9F0", VA = "0x159D9F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x159DA94", Offset = "0x159DA94", VA = "0x159DA94")]
	public OrbitalController()
	{
	}
}
