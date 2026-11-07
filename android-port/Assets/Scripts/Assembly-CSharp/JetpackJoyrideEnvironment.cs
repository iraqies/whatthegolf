using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A3")]
public class JetpackJoyrideEnvironment : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41550", Offset = "0x41550")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400286A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400286B")]
		[FieldOffset(Offset = "0x8")]
		public static Func<JetpackJoyrideChallenge, int> _003C_003E9__15_0;

		[Token(Token = "0x400286C")]
		[FieldOffset(Offset = "0x10")]
		public static Func<JetpackJoyrideChallenge, int> _003C_003E9__15_1;

		[Token(Token = "0x6002309")]
		[Address(RVA = "0x17CB898", Offset = "0x17CB898", VA = "0x17CB898")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600230A")]
		[Address(RVA = "0x17CB8A0", Offset = "0x17CB8A0", VA = "0x17CB8A0")]
		internal int _003CUpdate_003Eb__15_0(JetpackJoyrideChallenge c)
		{
			return default;
		}

		[Token(Token = "0x600230B")]
		[Address(RVA = "0x17CB8B8", Offset = "0x17CB8B8", VA = "0x17CB8B8")]
		internal int _003CUpdate_003Eb__15_1(JetpackJoyrideChallenge x)
		{
			return default;
		}
	}

	[Token(Token = "0x20007A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41560", Offset = "0x41560")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x400286D")]
		[FieldOffset(Offset = "0x10")]
		public JetpackJoyrideChallenge challenge;

		[Token(Token = "0x400286E")]
		[FieldOffset(Offset = "0x18")]
		public int i1;

		[Token(Token = "0x400286F")]
		[FieldOffset(Offset = "0x20")]
		public JetpackJoyrideEnvironment _003C_003E4__this;

		[Token(Token = "0x600230C")]
		[Address(RVA = "0x17CB8D0", Offset = "0x17CB8D0", VA = "0x17CB8D0")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600230D")]
		[Address(RVA = "0x17CB8D8", Offset = "0x17CB8D8", VA = "0x17CB8D8")]
		internal void _003CFixedUpdate_003Eb__0()
		{
		}
	}

	[Token(Token = "0x400285C")]
	[FieldOffset(Offset = "0x18")]
	public float MoveSpeed;

	[Token(Token = "0x400285D")]
	[FieldOffset(Offset = "0x20")]
	public List<Rigidbody2D> StaticObjects;

	[Token(Token = "0x400285E")]
	[FieldOffset(Offset = "0x28")]
	public List<JetpackJoyrideBackgroundObject> BackgroundObjects;

	[Token(Token = "0x400285F")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 SpawnIntervalRange;

	[Token(Token = "0x4002860")]
	[FieldOffset(Offset = "0x38")]
	public Transform Challenges;

	[Token(Token = "0x4002861")]
	[FieldOffset(Offset = "0x40")]
	public Vector2 challengeSpawnIntervalRange;

	[Token(Token = "0x4002862")]
	[FieldOffset(Offset = "0x48")]
	public Transform ChallengeStartPosition;

	[Token(Token = "0x4002863")]
	[FieldOffset(Offset = "0x50")]
	public Transform ChallengeEndPosition;

	[Token(Token = "0x4002864")]
	[FieldOffset(Offset = "0x58")]
	private List<JetpackJoyrideChallenge> activeChallenges;

	[Token(Token = "0x4002865")]
	[FieldOffset(Offset = "0x60")]
	private List<JetpackJoyrideBackgroundObject> activeBackgroundObjects;

	[Token(Token = "0x4002866")]
	[FieldOffset(Offset = "0x68")]
	private List<JetpackJoyrideBackgroundObject> inactiveBackgroundObjects;

	[Token(Token = "0x4002867")]
	[FieldOffset(Offset = "0x70")]
	private float nextBackgroundSpawn;

	[Token(Token = "0x4002868")]
	[FieldOffset(Offset = "0x74")]
	private float nextChallengeSpawn;

	[Token(Token = "0x4002869")]
	[FieldOffset(Offset = "0x78")]
	private JetpackJoyrideChallenge[] challenges;

	[Token(Token = "0x6002304")]
	[Address(RVA = "0x14F6F7C", Offset = "0x14F6F7C", VA = "0x14F6F7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002305")]
	[Address(RVA = "0x14F714C", Offset = "0x14F714C", VA = "0x14F714C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002306")]
	[Address(RVA = "0x14F77B8", Offset = "0x14F77B8", VA = "0x14F77B8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002307")]
	[Address(RVA = "0x14F7B90", Offset = "0x14F7B90", VA = "0x14F7B90")]
	public JetpackJoyrideEnvironment()
	{
	}
}
