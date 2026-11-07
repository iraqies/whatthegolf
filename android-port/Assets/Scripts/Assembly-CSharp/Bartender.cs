using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000896")]
public class Bartender : MonoBehaviour
{
	[Token(Token = "0x2000897")]
	public enum BartenderStateEnum
	{
		[Token(Token = "0x4002F2F")]
		Normal = 0,
		[Token(Token = "0x4002F30")]
		GoingIntoHiding = 1,
		[Token(Token = "0x4002F31")]
		Hiding = 2,
		[Token(Token = "0x4002F32")]
		Resetting = 3
	}

	[Token(Token = "0x4002F20")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Controller;

	[Token(Token = "0x4002F21")]
	[FieldOffset(Offset = "0x20")]
	public List<BreakableBottle> Bottles;

	[Token(Token = "0x4002F22")]
	[FieldOffset(Offset = "0x28")]
	public Transform Flag;

	[Token(Token = "0x4002F23")]
	[FieldOffset(Offset = "0x30")]
	public float HideSpeed;

	[Token(Token = "0x4002F24")]
	[FieldOffset(Offset = "0x34")]
	public float ResetSpeed;

	[Token(Token = "0x4002F25")]
	[FieldOffset(Offset = "0x38")]
	public float HideDuration;

	[Token(Token = "0x4002F26")]
	[FieldOffset(Offset = "0x3C")]
	public float FlagWaveRange;

	[Token(Token = "0x4002F27")]
	[FieldOffset(Offset = "0x40")]
	public float FlagWaveSpeed;

	[Token(Token = "0x4002F28")]
	[FieldOffset(Offset = "0x44")]
	private bool hasSurrendered;

	[Token(Token = "0x4002F29")]
	[FieldOffset(Offset = "0x48")]
	private Animator animator;

	[Token(Token = "0x4002F2A")]
	[FieldOffset(Offset = "0x50")]
	private int startNumberOfBottles;

	[Token(Token = "0x4002F2B")]
	[FieldOffset(Offset = "0x54")]
	private BartenderStateEnum bartenderState;

	[Token(Token = "0x4002F2C")]
	[FieldOffset(Offset = "0x58")]
	private float animationTimer;

	[Token(Token = "0x4002F2D")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 startPos;

	[Token(Token = "0x60027A1")]
	[Address(RVA = "0x151ACE4", Offset = "0x151ACE4", VA = "0x151ACE4")]
	private void Start()
	{
	}

	[Token(Token = "0x60027A2")]
	[Address(RVA = "0x151ADF8", Offset = "0x151ADF8", VA = "0x151ADF8")]
	private void OnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x60027A3")]
	[Address(RVA = "0x151AE14", Offset = "0x151AE14", VA = "0x151AE14")]
	private void Update()
	{
	}

	[Token(Token = "0x60027A4")]
	[Address(RVA = "0x151B2A8", Offset = "0x151B2A8", VA = "0x151B2A8")]
	public Bartender()
	{
	}
}
