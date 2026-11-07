using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000232")]
public class RagdollShooterSim2d : GolfBallShooterBase
{
	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x60")]
	public float Force;

	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x64")]
	public Vector2 RandomRange;

	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody[] rigidbodies;

	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x78")]
	private int groundLayer;

	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x7C")]
	private bool grounded;

	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x80")]
	public float airMultiplier;

	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x84")]
	public float maxXWhileFalling;

	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x88")]
	private bool constrainX;

	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x8C")]
	public float xCorrectionSpeedMultiplier;

	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x90")]
	public float minimumXCorrectionSpeed;

	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x94")]
	public float cameraChangeYValue;

	[Token(Token = "0x4000B40")]
	[FieldOffset(Offset = "0x98")]
	public GameObject CMCamera;

	[Token(Token = "0x4000B41")]
	[FieldOffset(Offset = "0xA0")]
	public float allowedZVariance;

	[Token(Token = "0x4000B42")]
	[FieldOffset(Offset = "0xA4")]
	public float zCorrectionSpeedMultiplier;

	[Token(Token = "0x4000B43")]
	[FieldOffset(Offset = "0xA8")]
	public float minimumZCorrectionSpeed;

	[Token(Token = "0x4000B44")]
	[FieldOffset(Offset = "0xAC")]
	private float originZ;

	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x163DCE8", Offset = "0x163DCE8", VA = "0x163DCE8", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x163DDBC", Offset = "0x163DDBC", VA = "0x163DDBC", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x163DFA4", Offset = "0x163DFA4", VA = "0x163DFA4", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x163E164", Offset = "0x163E164", VA = "0x163E164")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x163E1B4", Offset = "0x163E1B4", VA = "0x163E1B4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x163E200", Offset = "0x163E200", VA = "0x163E200")]
	public RagdollShooterSim2d()
	{
	}
}
