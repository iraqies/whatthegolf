using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000422")]
public class TargetShootingChallenge : Challenge
{
	[Serializable]
	[Token(Token = "0x2000423")]
	public class Launcher
	{
		[Token(Token = "0x40016A2")]
		[FieldOffset(Offset = "0x10")]
		public float force;

		[Token(Token = "0x40016A3")]
		[FieldOffset(Offset = "0x14")]
		public float angularForce;

		[Token(Token = "0x40016A4")]
		[FieldOffset(Offset = "0x18")]
		public Transform m_LauncherContainer;

		[Token(Token = "0x40016A5")]
		[FieldOffset(Offset = "0x20")]
		public List<float> m_LaunchTimes;

		[Token(Token = "0x6001373")]
		[Address(RVA = "0x1861248", Offset = "0x1861248", VA = "0x1861248")]
		public void ThrowBottle(Rigidbody newBottle)
		{
		}

		[Token(Token = "0x6001374")]
		[Address(RVA = "0x18612FC", Offset = "0x18612FC", VA = "0x18612FC")]
		public Launcher()
		{
		}
	}

	[Token(Token = "0x4001697")]
	[FieldOffset(Offset = "0xA4")]
	public int HitsToWin;

	[Token(Token = "0x4001698")]
	[FieldOffset(Offset = "0xA8")]
	public BreakableBottle prefab;

	[Token(Token = "0x4001699")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject bottlePrefab;

	[Token(Token = "0x400169A")]
	[FieldOffset(Offset = "0xB8")]
	public Launcher[] launchers;

	[Token(Token = "0x400169B")]
	[FieldOffset(Offset = "0xC0")]
	private float timeAtStart;

	[Token(Token = "0x400169C")]
	[FieldOffset(Offset = "0xC4")]
	private int index;

	[Token(Token = "0x400169D")]
	[FieldOffset(Offset = "0xC8")]
	private int hitCount;

	[Token(Token = "0x400169E")]
	[FieldOffset(Offset = "0xCC")]
	private int targetsLeft;

	[Token(Token = "0x400169F")]
	[FieldOffset(Offset = "0xD0")]
	private GolfBallController controller;

	[Token(Token = "0x40016A0")]
	[FieldOffset(Offset = "0xD8")]
	private int finalLaunchTime;

	[Token(Token = "0x40016A1")]
	[FieldOffset(Offset = "0xDC")]
	private int lastSecond;

	[Token(Token = "0x600136E")]
	[Address(RVA = "0x16F6F10", Offset = "0x16F6F10", VA = "0x16F6F10", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x600136F")]
	[Address(RVA = "0x16F70D0", Offset = "0x16F70D0", VA = "0x16F70D0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0x16F7524", Offset = "0x16F7524", VA = "0x16F7524", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0x16F7668", Offset = "0x16F7668", VA = "0x16F7668")]
	private void OnBottleHit(IHitscanTarget target)
	{
	}

	[Token(Token = "0x6001372")]
	[Address(RVA = "0x16F7710", Offset = "0x16F7710", VA = "0x16F7710")]
	public TargetShootingChallenge()
	{
	}
}
