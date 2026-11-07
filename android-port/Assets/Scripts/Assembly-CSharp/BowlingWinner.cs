using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000604")]
public class BowlingWinner : MonoBehaviour
{
	[Token(Token = "0x2000605")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40980", Offset = "0x40980")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody pin;

		[Token(Token = "0x6001B73")]
		[Address(RVA = "0x177B980", Offset = "0x177B980", VA = "0x177B980")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x177B988", Offset = "0x177B988", VA = "0x177B988")]
		internal void _003CEvaluateShot_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x177BA40", Offset = "0x177BA40", VA = "0x177BA40")]
		internal void _003CEvaluateShot_003Eb__2()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000606")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40990", Offset = "0x40990")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__7_0;

		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x177B974", Offset = "0x177B974", VA = "0x177B974")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x177B97C", Offset = "0x177B97C", VA = "0x177B97C")]
		internal void _003CEvaluateShot_003Eb__7_0(float t)
		{
		}
	}

	[Token(Token = "0x4001EFB")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> Pins;

	[Token(Token = "0x4001EFC")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4E3DC", Offset = "0x4E3DC")]
	public float TippedOverThreshold;

	[Token(Token = "0x4001EFD")]
	[FieldOffset(Offset = "0x24")]
	public int numberOfShots;

	[Token(Token = "0x4001EFE")]
	[FieldOffset(Offset = "0x28")]
	private int numberOfPins;

	[Token(Token = "0x4001EFF")]
	[FieldOffset(Offset = "0x2C")]
	private bool didWin;

	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x17057BC", Offset = "0x17057BC", VA = "0x17057BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B70")]
	[Address(RVA = "0x170580C", Offset = "0x170580C", VA = "0x170580C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x1705810", Offset = "0x1705810", VA = "0x1705810")]
	public void EvaluateShot()
	{
	}

	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x1705C34", Offset = "0x1705C34", VA = "0x1705C34")]
	public BowlingWinner()
	{
	}
}
