using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000727")]
public class TrainShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x40025B5")]
	[FieldOffset(Offset = "0x48")]
	public float JumpUpForce;

	[Token(Token = "0x40025B6")]
	[FieldOffset(Offset = "0x4C")]
	public float JumpForwardForce;

	[Token(Token = "0x40025B7")]
	[FieldOffset(Offset = "0x50")]
	public bool Grounded;

	[Token(Token = "0x40025B8")]
	[FieldOffset(Offset = "0x54")]
	public float engineDirection;

	[Token(Token = "0x40025B9")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float engineBaseForce;

	[Token(Token = "0x40025BA")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private Vector3 localForcePoint;

	[Token(Token = "0x40025BB")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float groundedCheckRadius;

	[Token(Token = "0x40025BC")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Vector2[] groundedCheckPositions;

	[Token(Token = "0x40025BD")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E8DC", Offset = "0x4E8DC")]
	private Vector2 engineVelocity__BackingField;

	[Token(Token = "0x40025BE")]
	[FieldOffset(Offset = "0x80")]
	private int groundLayer;

	[Token(Token = "0x170003B9")]
	public Vector2 engineVelocity
	{
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x1729554", Offset = "0x1729554", VA = "0x1729554")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65AF0", Offset = "0x65AF0")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x172955C", Offset = "0x172955C", VA = "0x172955C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65B00", Offset = "0x65B00")]
		private set
		{
		}
	}

	[Token(Token = "0x6002106")]
	[Address(RVA = "0x1729564", Offset = "0x1729564", VA = "0x1729564", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002107")]
	[Address(RVA = "0x17295D4", Offset = "0x17295D4", VA = "0x17295D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002108")]
	[Address(RVA = "0x17295D8", Offset = "0x17295D8", VA = "0x17295D8")]
	private void UpdateGrounded()
	{
	}

	[Token(Token = "0x6002109")]
	[Address(RVA = "0x1729764", Offset = "0x1729764", VA = "0x1729764", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600210A")]
	[Address(RVA = "0x1729844", Offset = "0x1729844", VA = "0x1729844", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600210B")]
	[Address(RVA = "0x17298A8", Offset = "0x17298A8", VA = "0x17298A8")]
	public TrainShooter()
	{
	}
}
