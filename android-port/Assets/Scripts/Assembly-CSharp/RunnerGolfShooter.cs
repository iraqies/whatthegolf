using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200081B")]
public class RunnerGolfShooter : GolfBallShooterExperimental
{
	[Serializable]
	[Token(Token = "0x200081C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x417D0", Offset = "0x417D0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002BA2")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__18_0;

		[Token(Token = "0x600253E")]
		[Address(RVA = "0x18368BC", Offset = "0x18368BC", VA = "0x18368BC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600253F")]
		[Address(RVA = "0x18368C4", Offset = "0x18368C4", VA = "0x18368C4")]
		internal void _003COnTriggerEnter_003Eb__18_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x4002B94")]
	[FieldOffset(Offset = "0x88")]
	public float ForwardSpeed;

	[Token(Token = "0x4002B95")]
	[FieldOffset(Offset = "0x8C")]
	public float SpinSpeed;

	[Token(Token = "0x4002B96")]
	[FieldOffset(Offset = "0x90")]
	public float JumpSpeed;

	[Token(Token = "0x4002B97")]
	[FieldOffset(Offset = "0x94")]
	public float MoveAngleThreshold;

	[Token(Token = "0x4002B98")]
	[FieldOffset(Offset = "0x98")]
	public float MoveLaneSpeed;

	[Token(Token = "0x4002B99")]
	[FieldOffset(Offset = "0x9C")]
	public float LaneWidth;

	[Token(Token = "0x4002B9A")]
	[FieldOffset(Offset = "0xA0")]
	public int NumberOfLanes;

	[Token(Token = "0x4002B9B")]
	[FieldOffset(Offset = "0xA4")]
	public int StartLane;

	[Token(Token = "0x4002B9C")]
	[FieldOffset(Offset = "0xA8")]
	public AudioClip CoinCollectClip;

	[Token(Token = "0x4002B9D")]
	[FieldOffset(Offset = "0xB0")]
	private int currentLane;

	[Token(Token = "0x4002B9E")]
	[FieldOffset(Offset = "0xB4")]
	private int targetLane;

	[Token(Token = "0x4002B9F")]
	[FieldOffset(Offset = "0xB8")]
	private Vector3 startPos;

	[Token(Token = "0x4002BA0")]
	[FieldOffset(Offset = "0xC4")]
	private bool canJump;

	[Token(Token = "0x6002535")]
	[Address(RVA = "0x1664250", Offset = "0x1664250", VA = "0x1664250", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002536")]
	[Address(RVA = "0x166427C", Offset = "0x166427C", VA = "0x166427C", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002537")]
	[Address(RVA = "0x16643F0", Offset = "0x16643F0", VA = "0x16643F0")]
	private void OnCollisionStay(Collision col)
	{
	}

	[Token(Token = "0x6002538")]
	[Address(RVA = "0x16643FC", Offset = "0x16643FC", VA = "0x16643FC")]
	protected new void FixedUpdate()
	{
	}

	[Token(Token = "0x6002539")]
	[Address(RVA = "0x16645B4", Offset = "0x16645B4", VA = "0x16645B4", Slot = "15")]
	protected virtual void Jump()
	{
	}

	[Token(Token = "0x600253A")]
	[Address(RVA = "0x1664610", Offset = "0x1664610", VA = "0x1664610")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600253B")]
	[Address(RVA = "0x1664800", Offset = "0x1664800", VA = "0x1664800", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x600253C")]
	[Address(RVA = "0x166480C", Offset = "0x166480C", VA = "0x166480C")]
	public RunnerGolfShooter()
	{
	}
}
