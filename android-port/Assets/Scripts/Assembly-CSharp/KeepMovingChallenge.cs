using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200040A")]
public class KeepMovingChallenge : Challenge
{
	[Token(Token = "0x4001609")]
	[FieldOffset(Offset = "0xA8")]
	private Rigidbody _ballRigidbody;

	[Token(Token = "0x400160A")]
	[FieldOffset(Offset = "0xB0")]
	private GolfBallController _controller;

	[Token(Token = "0x400160B")]
	[FieldOffset(Offset = "0xB8")]
	private float _failChallengeTimer;

	[Token(Token = "0x400160C")]
	[FieldOffset(Offset = "0xBC")]
	private bool _challengeStarted;

	[Token(Token = "0x400160D")]
	[FieldOffset(Offset = "0xC0")]
	private float _levelTimer;

	[Token(Token = "0x400160E")]
	[FieldOffset(Offset = "0xC4")]
	public float timeToBeat;

	[Token(Token = "0x400160F")]
	[FieldOffset(Offset = "0xC8")]
	private int _currentTimeInt;

	[Token(Token = "0x4001610")]
	[FieldOffset(Offset = "0xCC")]
	public bool beginOnAim;

	[Token(Token = "0x4001611")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x4D5E4", Offset = "0x4D5E4")]
	public float minVelocity;

	[Token(Token = "0x60012FA")]
	[Address(RVA = "0x14FC94C", Offset = "0x14FC94C", VA = "0x14FC94C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012FB")]
	[Address(RVA = "0x14FCB34", Offset = "0x14FCB34", VA = "0x14FCB34")]
	private void ControllerOnAimStart()
	{
	}

	[Token(Token = "0x60012FC")]
	[Address(RVA = "0x14FCB40", Offset = "0x14FCB40", VA = "0x14FCB40")]
	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x60012FD")]
	[Address(RVA = "0x14FCB4C", Offset = "0x14FCB4C", VA = "0x14FCB4C", Slot = "9")]
	protected override void ChallengeUpdate()
	{
	}

	[Token(Token = "0x60012FE")]
	[Address(RVA = "0x14FCCB0", Offset = "0x14FCCB0", VA = "0x14FCCB0", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x60012FF")]
	[Address(RVA = "0x14FCDF4", Offset = "0x14FCDF4", VA = "0x14FCDF4", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x6001300")]
	[Address(RVA = "0x14FCE58", Offset = "0x14FCE58", VA = "0x14FCE58")]
	public KeepMovingChallenge()
	{
	}
}
