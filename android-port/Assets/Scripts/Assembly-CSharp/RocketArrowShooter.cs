using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001D1")]
[Attribute(Name = "RequireComponent", RVA = "0x3E278", Offset = "0x3E278")]
public class RocketArrowShooter : GolfBallShooterBase
{
	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rb;

	[Token(Token = "0x400086D")]
	[FieldOffset(Offset = "0x68")]
	public float minShootVelocity;

	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x6C")]
	public float fullShootVelocity;

	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x70")]
	public ParticleSystem particle;

	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x78")]
	private GolfBallController controller;

	[Token(Token = "0x4000871")]
	[FieldOffset(Offset = "0x80")]
	private bool isAiming;

	[Token(Token = "0x4000872")]
	[FieldOffset(Offset = "0x88")]
	private Arrow3D arrow;

	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x90")]
	private bool hasAimedOnce;

	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private AudioSource rocketAudio;

	[Token(Token = "0x6000824")]
	[Address(RVA = "0x1658FE0", Offset = "0x1658FE0", VA = "0x1658FE0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0x1659198", Offset = "0x1659198", VA = "0x1659198", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0x16591A4", Offset = "0x16591A4", VA = "0x16591A4", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0x165937C", Offset = "0x165937C", VA = "0x165937C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0x1659384", Offset = "0x1659384", VA = "0x1659384", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0x165938C", Offset = "0x165938C", VA = "0x165938C")]
	private void HandleCollision(Collision collision)
	{
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0x1659548", Offset = "0x1659548", VA = "0x1659548")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x1659564", Offset = "0x1659564", VA = "0x1659564", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0x16596A4", Offset = "0x16596A4", VA = "0x16596A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600082D")]
	[Address(RVA = "0x1659794", Offset = "0x1659794", VA = "0x1659794")]
	protected bool IsPointOutsideCamera(Vector3 p)
	{
		return default;
	}

	[Token(Token = "0x600082E")]
	[Address(RVA = "0x1659868", Offset = "0x1659868", VA = "0x1659868")]
	public RocketArrowShooter()
	{
	}
}
