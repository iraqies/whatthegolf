using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B23")]
public class RotateRigidbodyWhenAiming : MonoBehaviour
{
	[Token(Token = "0x4003E4A")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController controller;

	[Token(Token = "0x4003E4B")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x4003E4C")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem DoneParticles;

	[Token(Token = "0x4003E4D")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> DoneClips;

	[Token(Token = "0x4003E4E")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 restingRotationEuler;

	[Token(Token = "0x4003E4F")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigidbody;

	[Token(Token = "0x600351E")]
	[Address(RVA = "0x165F43C", Offset = "0x165F43C", VA = "0x165F43C")]
	private void Start()
	{
	}

	[Token(Token = "0x600351F")]
	[Address(RVA = "0x165F4DC", Offset = "0x165F4DC", VA = "0x165F4DC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003520")]
	[Address(RVA = "0x165F710", Offset = "0x165F710", VA = "0x165F710")]
	public RotateRigidbodyWhenAiming()
	{
	}
}
