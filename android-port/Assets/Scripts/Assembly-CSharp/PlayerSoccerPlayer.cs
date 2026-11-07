using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000857")]
public class PlayerSoccerPlayer : GolfBallShooterBase
{
	[Token(Token = "0x4002D37")]
	[FieldOffset(Offset = "0x60")]
	public float MoveSpeed;

	[Token(Token = "0x4002D38")]
	[FieldOffset(Offset = "0x64")]
	public float ShootForce;

	[Token(Token = "0x4002D39")]
	[FieldOffset(Offset = "0x68")]
	public float ShootUpForce;

	[Token(Token = "0x4002D3A")]
	[FieldOffset(Offset = "0x6C")]
	public float SlideForce;

	[Token(Token = "0x4002D3B")]
	[FieldOffset(Offset = "0x70")]
	public float MaxSpeedSqr;

	[Token(Token = "0x4002D3C")]
	[FieldOffset(Offset = "0x74")]
	public float MaxSpeedWithBallSqr;

	[Token(Token = "0x4002D3D")]
	[FieldOffset(Offset = "0x78")]
	public float MaxSlideSpeed;

	[Token(Token = "0x4002D3E")]
	[FieldOffset(Offset = "0x7C")]
	public float SlideTime;

	[Token(Token = "0x4002D3F")]
	[FieldOffset(Offset = "0x80")]
	public float MinSpeedForSlide;

	[Token(Token = "0x4002D40")]
	[FieldOffset(Offset = "0x88")]
	public PlayableSoccerBall Football;

	[Token(Token = "0x4002D41")]
	[FieldOffset(Offset = "0x90")]
	public RandomAudioClips ShootClips;

	[Token(Token = "0x4002D42")]
	[FieldOffset(Offset = "0x98")]
	public RandomAudioClips SlideClips;

	[Token(Token = "0x4002D43")]
	[FieldOffset(Offset = "0xA0")]
	public List<PlayerSoccerInfo> Players;

	[Token(Token = "0x4002D44")]
	[FieldOffset(Offset = "0xA8")]
	public Transform CameraFollow;

	[Token(Token = "0x4002D45")]
	[FieldOffset(Offset = "0xB0")]
	public bool AffectTime;

	[Token(Token = "0x4002D46")]
	[FieldOffset(Offset = "0xB4")]
	public float ChangeTargetBlockTime;

	[Token(Token = "0x4002D47")]
	[FieldOffset(Offset = "0xB8")]
	public float SidewaysDrag;

	[Token(Token = "0x4002D48")]
	[FieldOffset(Offset = "0xBC")]
	private float changeTargetTimer;

	[Token(Token = "0x4002D49")]
	[FieldOffset(Offset = "0xC0")]
	private bool hasBall;

	[Token(Token = "0x4002D4A")]
	[FieldOffset(Offset = "0xC8")]
	private Rigidbody attatchedBall;

	[Token(Token = "0x4002D4B")]
	[FieldOffset(Offset = "0xD0")]
	private FixedJoint attachedJoint;

	[Token(Token = "0x4002D4C")]
	[FieldOffset(Offset = "0xD8")]
	private float currentMaxSpeed;

	[Token(Token = "0x4002D4D")]
	[FieldOffset(Offset = "0xDC")]
	private float slideTimer;

	[Token(Token = "0x4002D4E")]
	[FieldOffset(Offset = "0xE0")]
	private float targetRot;

	[Token(Token = "0x4002D4F")]
	[FieldOffset(Offset = "0xE4")]
	private float rotVel;

	[Token(Token = "0x4002D50")]
	[FieldOffset(Offset = "0xE8")]
	private PlayerSoccerInfo currentPlayer;

	[Token(Token = "0x4002D51")]
	[FieldOffset(Offset = "0xF0")]
	private Vector3 curVel;

	[Token(Token = "0x4002D52")]
	[FieldOffset(Offset = "0xFC")]
	private float switchPlayerTimer;

	[Token(Token = "0x4002D53")]
	[FieldOffset(Offset = "0x100")]
	private Collider collider;

	[Token(Token = "0x6002677")]
	[Address(RVA = "0x15FB958", Offset = "0x15FB958", VA = "0x15FB958")]
	private void Start()
	{
	}

	[Token(Token = "0x6002678")]
	[Address(RVA = "0x15FBD20", Offset = "0x15FBD20", VA = "0x15FBD20")]
	private void OnBallLost()
	{
	}

	[Token(Token = "0x6002679")]
	[Address(RVA = "0x15FBC28", Offset = "0x15FBC28", VA = "0x15FBC28")]
	private void SetPlayer(PlayerSoccerInfo newPlayer)
	{
	}

	[Token(Token = "0x600267A")]
	[Address(RVA = "0x15FBD28", Offset = "0x15FBD28", VA = "0x15FBD28", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600267B")]
	[Address(RVA = "0x15FBEE8", Offset = "0x15FBEE8", VA = "0x15FBEE8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600267C")]
	[Address(RVA = "0x15FC040", Offset = "0x15FC040", VA = "0x15FC040", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x600267D")]
	[Address(RVA = "0x15FC8B8", Offset = "0x15FC8B8", VA = "0x15FC8B8")]
	private void Update()
	{
	}

	[Token(Token = "0x600267E")]
	[Address(RVA = "0x15FCB64", Offset = "0x15FCB64", VA = "0x15FCB64")]
	private void OnBallRecieved()
	{
	}

	[Token(Token = "0x600267F")]
	[Address(RVA = "0x15FCBC4", Offset = "0x15FCBC4", VA = "0x15FCBC4")]
	public PlayerSoccerPlayer()
	{
	}
}
