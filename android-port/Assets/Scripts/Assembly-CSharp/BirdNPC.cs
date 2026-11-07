using System;
using System.Collections.Generic;
using Audio;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200093C")]
public class BirdNPC : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x4003267")]
	[FieldOffset(Offset = "0x18")]
	public List<string> ScaredOfTags;

	[Token(Token = "0x4003268")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody scareOnOtherColliderEnter;

	[Token(Token = "0x4003269")]
	[FieldOffset(Offset = "0x28")]
	public float MoveSpeed;

	[Token(Token = "0x400326A")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> birdFlapClips;

	[Token(Token = "0x400326B")]
	[FieldOffset(Offset = "0x38")]
	private Vector3? posTarget;

	[Token(Token = "0x400326C")]
	[FieldOffset(Offset = "0x48")]
	private Animator birdAnimator;

	[Token(Token = "0x400326D")]
	[FieldOffset(Offset = "0x50")]
	private Timeline _timeline;

	[Token(Token = "0x400326E")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 startPos;

	[Token(Token = "0x400326F")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 startScale;

	[Token(Token = "0x4003270")]
	[FieldOffset(Offset = "0x70")]
	private bool wasScared;

	[Token(Token = "0x4003271")]
	[FieldOffset(Offset = "0x78")]
	private RigidbodyCollisionInfo otherColInfo;

	[Token(Token = "0x4003272")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FAA4", Offset = "0x4FAA4")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x4003273")]
	[FieldOffset(Offset = "0x88")]
	public Action<BirdNPC> OnBirdScared;

	[Token(Token = "0x4003274")]
	[FieldOffset(Offset = "0x90")]
	private int birdAnimatorFlyingID;

	[Token(Token = "0x17000469")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x1611C2C", Offset = "0x1611C2C", VA = "0x1611C2C", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67920", Offset = "0x67920")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x1611C34", Offset = "0x1611C34", VA = "0x1611C34", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67930", Offset = "0x67930")]
		set
		{
		}
	}

	[Token(Token = "0x6002ADC")]
	[Address(RVA = "0x1611C3C", Offset = "0x1611C3C", VA = "0x1611C3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002ADD")]
	[Address(RVA = "0x1611E60", Offset = "0x1611E60", VA = "0x1611E60")]
	private void OnOtherCollision(HitInfo hitinfo)
	{
	}

	[Token(Token = "0x6002ADE")]
	[Address(RVA = "0x1611FF4", Offset = "0x1611FF4", VA = "0x1611FF4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002ADF")]
	[Address(RVA = "0x1612488", Offset = "0x1612488", VA = "0x1612488")]
	public void SetTriggerRange(float radius)
	{
	}

	[Token(Token = "0x6002AE0")]
	[Address(RVA = "0x161255C", Offset = "0x161255C", VA = "0x161255C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002AE1")]
	[Address(RVA = "0x1612594", Offset = "0x1612594", VA = "0x1612594")]
	private void CheckIfScared(GameObject obj)
	{
	}

	[Token(Token = "0x6002AE2")]
	[Address(RVA = "0x1611EA4", Offset = "0x1611EA4", VA = "0x1611EA4")]
	private void Scare()
	{
	}

	[Token(Token = "0x6002AE3")]
	[Address(RVA = "0x1612658", Offset = "0x1612658", VA = "0x1612658")]
	public BirdNPC()
	{
	}
}
