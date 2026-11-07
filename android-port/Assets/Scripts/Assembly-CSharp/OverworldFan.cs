using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A39")]
public class OverworldFan : MonoBehaviour
{
	[Token(Token = "0x400386B")]
	[FieldOffset(Offset = "0x18")]
	public bool isFanning;

	[Token(Token = "0x400386C")]
	[FieldOffset(Offset = "0x20")]
	public Transform blade;

	[Token(Token = "0x400386D")]
	[FieldOffset(Offset = "0x28")]
	public float bladeRotationSpeed;

	[Token(Token = "0x400386E")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 windForce;

	[Token(Token = "0x400386F")]
	[FieldOffset(Offset = "0x38")]
	public WindArea2D windarea;

	[Token(Token = "0x4003870")]
	[FieldOffset(Offset = "0x40")]
	public List<WindArea2D> extraWindAreas;

	[Token(Token = "0x4003871")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem particles;

	[Token(Token = "0x4003872")]
	[FieldOffset(Offset = "0x50")]
	public AudioSource fanAudioSource;

	[Token(Token = "0x60030AC")]
	[Address(RVA = "0x15B6280", Offset = "0x15B6280", VA = "0x15B6280")]
	private void Awake()
	{
	}

	[Token(Token = "0x60030AD")]
	[Address(RVA = "0x15B6288", Offset = "0x15B6288", VA = "0x15B6288")]
	public void SetState(bool isStart)
	{
	}

	[Token(Token = "0x60030AE")]
	[Address(RVA = "0x15B65D8", Offset = "0x15B65D8", VA = "0x15B65D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60030AF")]
	[Address(RVA = "0x15B6678", Offset = "0x15B6678", VA = "0x15B6678")]
	public OverworldFan()
	{
	}
}
