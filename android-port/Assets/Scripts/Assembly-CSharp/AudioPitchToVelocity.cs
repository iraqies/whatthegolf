using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000389")]
[Attribute(Name = "RequireComponent", RVA = "0x3F5BC", Offset = "0x3F5BC")]
public class AudioPitchToVelocity : MonoBehaviour
{
	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x18")]
	public bool use2D;

	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody target;

	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody2D target2D;

	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x30")]
	public float minPitch;

	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0x34")]
	public float maxPitch;

	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0x38")]
	public float minVelocity;

	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0x3C")]
	public float maxVelocity;

	[Token(Token = "0x400136C")]
	[FieldOffset(Offset = "0x40")]
	public float currentVelocity;

	[Token(Token = "0x400136D")]
	[FieldOffset(Offset = "0x48")]
	private AudioSource audioSrc;

	[Token(Token = "0x400136E")]
	[FieldOffset(Offset = "0x50")]
	private float dampVelocity;

	[Token(Token = "0x400136F")]
	[FieldOffset(Offset = "0x58")]
	private AudioPitchToTimeScale timeScalePitcher;

	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x150B688", Offset = "0x150B688", VA = "0x150B688")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x150B708", Offset = "0x150B708", VA = "0x150B708")]
	private void Update()
	{
	}

	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x150B71C", Offset = "0x150B71C", VA = "0x150B71C")]
	private void Check2D()
	{
	}

	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x150B850", Offset = "0x150B850", VA = "0x150B850")]
	private void Check3D()
	{
	}

	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x150B98C", Offset = "0x150B98C", VA = "0x150B98C")]
	public AudioPitchToVelocity()
	{
	}
}
