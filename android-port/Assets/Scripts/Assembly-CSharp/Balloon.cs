using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BB9")]
public class Balloon : MonoBehaviour
{
	[Token(Token = "0x4004148")]
	[FieldOffset(Offset = "0x18")]
	public float MinPopForceSqr;

	[Token(Token = "0x4004149")]
	[FieldOffset(Offset = "0x20")]
	public List<string> PopTags;

	[Token(Token = "0x400414A")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioClip> PopSounds;

	[Token(Token = "0x400414B")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 ForceChangeRange;

	[Token(Token = "0x400414C")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 UpForceIfNoConstantForce;

	[Token(Token = "0x400414D")]
	[FieldOffset(Offset = "0x48")]
	private ConstantForce upForce;

	[Token(Token = "0x400414E")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startForce;

	[Token(Token = "0x400414F")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rigid;

	[Token(Token = "0x4004150")]
	[FieldOffset(Offset = "0x68")]
	public bool isPopped;

	[Token(Token = "0x4004151")]
	[FieldOffset(Offset = "0x70")]
	public Action<Balloon> OnPopped;

	[Token(Token = "0x600387F")]
	[Address(RVA = "0x15196D8", Offset = "0x15196D8", VA = "0x15196D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003880")]
	[Address(RVA = "0x15197DC", Offset = "0x15197DC", VA = "0x15197DC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003881")]
	[Address(RVA = "0x15198C0", Offset = "0x15198C0", VA = "0x15198C0")]
	public void PopBalloon(float propbabiltity)
	{
	}

	[Token(Token = "0x6003882")]
	[Address(RVA = "0x1519A28", Offset = "0x1519A28", VA = "0x1519A28")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003883")]
	[Address(RVA = "0x1519BD4", Offset = "0x1519BD4", VA = "0x1519BD4")]
	public Balloon()
	{
	}

	[Token(Token = "0x6003884")]
	[Address(RVA = "0x1519BE4", Offset = "0x1519BE4", VA = "0x1519BE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B110", Offset = "0x6B110")]
	private void _003CPopBalloon_003Eb__12_0(AudioSource t)
	{
	}
}
