using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200076C")]
public class FlyingBallShooter : BallShooter
{
	[Token(Token = "0x400274D")]
	[FieldOffset(Offset = "0x58")]
	public float gravity;

	[Token(Token = "0x400274E")]
	[FieldOffset(Offset = "0x5C")]
	public float moveDistnace;

	[Token(Token = "0x400274F")]
	[FieldOffset(Offset = "0x60")]
	public float speed;

	[Token(Token = "0x4002750")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 target;

	[Token(Token = "0x4002751")]
	[FieldOffset(Offset = "0x70")]
	public bool useBounds;

	[Token(Token = "0x4002752")]
	[FieldOffset(Offset = "0x71")]
	public bool useGravity;

	[Token(Token = "0x4002753")]
	[FieldOffset(Offset = "0x74")]
	public Vector2 bounds;

	[Token(Token = "0x4002754")]
	[FieldOffset(Offset = "0x7C")]
	private bool startedFlying;

	[Token(Token = "0x600222E")]
	[Address(RVA = "0x146D598", Offset = "0x146D598", VA = "0x146D598", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600222F")]
	[Address(RVA = "0x146D674", Offset = "0x146D674", VA = "0x146D674")]
	private void Controller_OnAimUpdate(Vector3 boost, bool arg2)
	{
	}

	[Token(Token = "0x6002230")]
	[Address(RVA = "0x146D830", Offset = "0x146D830", VA = "0x146D830", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002231")]
	[Address(RVA = "0x146D704", Offset = "0x146D704", VA = "0x146D704")]
	private void ClampVelocity()
	{
	}

	[Token(Token = "0x6002232")]
	[Address(RVA = "0x146D834", Offset = "0x146D834", VA = "0x146D834", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6002233")]
	[Address(RVA = "0x146D8F0", Offset = "0x146D8F0", VA = "0x146D8F0")]
	public FlyingBallShooter()
	{
	}
}
