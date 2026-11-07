using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011B")]
public class WhackAMoleController : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x200011C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB60", Offset = "0x3DB60")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameObject, bool> _003C_003E9__17_0;

		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x10")]
		public static Func<GameObject, bool> _003C_003E9__17_1;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x18774A0", Offset = "0x18774A0", VA = "0x18774A0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x18774A8", Offset = "0x18774A8", VA = "0x18774A8")]
		internal bool _003CHitSomething_003Eb__17_0(GameObject o)
		{
			return default;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1877508", Offset = "0x1877508", VA = "0x1877508")]
		internal bool _003CHitSomething_003Eb__17_1(GameObject o)
		{
			return default;
		}
	}

	[Token(Token = "0x40004EB")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Animator hammerAnimator;

	[Token(Token = "0x40004EC")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float moveSpeed;

	[Token(Token = "0x40004ED")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float rotateSpeed;

	[Token(Token = "0x40004EE")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float blockTime;

	[Token(Token = "0x40004EF")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private WinnableGolfBall leftGolfBall;

	[Token(Token = "0x40004F0")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private WinnableGolfBall rightGolfBall;

	[Token(Token = "0x40004F1")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private List<GameObject> leftGolfBallObstacles;

	[Token(Token = "0x40004F2")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private List<GameObject> rightGolfBallObstacles;

	[Token(Token = "0x40004F3")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private ParticleSystem obstacleExplosion;

	[Token(Token = "0x40004F4")]
	[FieldOffset(Offset = "0xA0")]
	private float blockTimer;

	[Token(Token = "0x40004F5")]
	[FieldOffset(Offset = "0xA8")]
	private Rigidbody rigid;

	[Token(Token = "0x40004F6")]
	[FieldOffset(Offset = "0xB0")]
	private MultiplayerConfiguration.PlayerInfo player;

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x1751F60", Offset = "0x1751F60", VA = "0x1751F60")]
	private void Start()
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x17521CC", Offset = "0x17521CC", VA = "0x17521CC")]
	private void Update()
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x175220C", Offset = "0x175220C", VA = "0x175220C", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x1752280", Offset = "0x1752280", VA = "0x1752280", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x17523D0", Offset = "0x17523D0", VA = "0x17523D0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x175244C", Offset = "0x175244C", VA = "0x175244C")]
	public void HitSomething()
	{
	}

	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x1752738", Offset = "0x1752738", VA = "0x1752738")]
	public WhackAMoleController()
	{
	}

	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x1752754", Offset = "0x1752754", VA = "0x1752754")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E618", Offset = "0x5E618")]
	private bool _003CStart_003Eb__12_0(MultiplayerConfiguration.PlayerInfo p)
	{
		return default;
	}

	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x17527BC", Offset = "0x17527BC", VA = "0x17527BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E628", Offset = "0x5E628")]
	private void _003CStart_003Eb__12_1(GameObject go)
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x1752834", Offset = "0x1752834", VA = "0x1752834")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E638", Offset = "0x5E638")]
	private void _003CStart_003Eb__12_2(GameObject go)
	{
	}
}
