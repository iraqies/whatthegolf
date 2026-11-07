using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B3")]
public class ElephantCatcher : GolfBallShooterBase
{
	[Token(Token = "0x20005B4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x40810", Offset = "0x40810")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4001D20")]
		[FieldOffset(Offset = "0x10")]
		public ElephantCatcher _003C_003E4__this;

		[Token(Token = "0x4001D21")]
		[FieldOffset(Offset = "0x18")]
		public float startHeight;

		[Token(Token = "0x60019E6")]
		[Address(RVA = "0x179E95C", Offset = "0x179E95C", VA = "0x179E95C")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x179E964", Offset = "0x179E964", VA = "0x179E964")]
		internal void _003CUpdate_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x4001D09")]
	[FieldOffset(Offset = "0x60")]
	public Transform CatcherRoot;

	[Token(Token = "0x4001D0A")]
	[FieldOffset(Offset = "0x68")]
	public Rigidbody CatcherRagdoolRoot;

	[Token(Token = "0x4001D0B")]
	[FieldOffset(Offset = "0x70")]
	public float MoveForce;

	[Token(Token = "0x4001D0C")]
	[FieldOffset(Offset = "0x74")]
	public float MoveDuration;

	[Token(Token = "0x4001D0D")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve DampenCurve;

	[Token(Token = "0x4001D0E")]
	[FieldOffset(Offset = "0x80")]
	public Transform Elephant;

	[Token(Token = "0x4001D0F")]
	[FieldOffset(Offset = "0x88")]
	public float RotateSpeed;

	[Token(Token = "0x4001D10")]
	[FieldOffset(Offset = "0x90")]
	public Rigidbody elephantRoot;

	[Token(Token = "0x4001D11")]
	[FieldOffset(Offset = "0x98")]
	public float minShotVelocity;

	[Token(Token = "0x4001D12")]
	[FieldOffset(Offset = "0x9C")]
	public float shotVelocity;

	[Token(Token = "0x4001D13")]
	[FieldOffset(Offset = "0xA0")]
	public float pitch;

	[Token(Token = "0x4001D14")]
	[FieldOffset(Offset = "0xA4")]
	public float spin;

	[Token(Token = "0x4001D15")]
	[FieldOffset(Offset = "0xA8")]
	public Transform ElephantEntry;

	[Token(Token = "0x4001D16")]
	[FieldOffset(Offset = "0xB0")]
	public Rigidbody ElephantMountain;

	[Token(Token = "0x4001D17")]
	[FieldOffset(Offset = "0xB8")]
	public ParticleSystem Particles;

	[Token(Token = "0x4001D18")]
	[FieldOffset(Offset = "0xC0")]
	public Transform Car;

	[Token(Token = "0x4001D19")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 currentDirection;

	[Token(Token = "0x4001D1A")]
	[FieldOffset(Offset = "0xD4")]
	private float moveTimer;

	[Token(Token = "0x4001D1B")]
	[FieldOffset(Offset = "0xD8")]
	private bool aiming;

	[Token(Token = "0x4001D1C")]
	[FieldOffset(Offset = "0xD9")]
	private bool hasBrokenFree;

	[Token(Token = "0x4001D1D")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 catcherStartPos;

	[Token(Token = "0x4001D1E")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 elephantStartPos;

	[Token(Token = "0x4001D1F")]
	[FieldOffset(Offset = "0xF8")]
	private Coroutine elephantEntryRoutine;

	[Token(Token = "0x60019DF")]
	[Address(RVA = "0x143F5B8", Offset = "0x143F5B8", VA = "0x143F5B8")]
	private void Start()
	{
	}

	[Token(Token = "0x60019E0")]
	[Address(RVA = "0x143F790", Offset = "0x143F790", VA = "0x143F790", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60019E1")]
	[Address(RVA = "0x143F894", Offset = "0x143F894", VA = "0x143F894", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x143F8BC", Offset = "0x143F8BC", VA = "0x143F8BC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60019E3")]
	[Address(RVA = "0x143F94C", Offset = "0x143F94C", VA = "0x143F94C")]
	private void Update()
	{
	}

	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x143FD58", Offset = "0x143FD58", VA = "0x143FD58", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x14400E4", Offset = "0x14400E4", VA = "0x14400E4")]
	public ElephantCatcher()
	{
	}
}
