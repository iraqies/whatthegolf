using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x200086C")]
public class Shooter : MonoBehaviour
{
	[Token(Token = "0x4002E13")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer splatter;

	[Token(Token = "0x4002E14")]
	[FieldOffset(Offset = "0x20")]
	public float DistSplatter;

	[Token(Token = "0x4002E15")]
	[FieldOffset(Offset = "0x24")]
	public float HeightCheck;

	[Token(Token = "0x4002E16")]
	[FieldOffset(Offset = "0x28")]
	public float NormalMod;

	[Token(Token = "0x4002E17")]
	[FieldOffset(Offset = "0x2C")]
	public LayerMask SplatterLayer;

	[Token(Token = "0x4002E18")]
	[FieldOffset(Offset = "0x30")]
	public List<Sprite> Sprites;

	[Token(Token = "0x4002E19")]
	[FieldOffset(Offset = "0x38")]
	public float GroundSplatterRotation;

	[Token(Token = "0x4002E1A")]
	[FieldOffset(Offset = "0x3C")]
	public float WallSplatterRotation;

	[Token(Token = "0x4002E1B")]
	[FieldOffset(Offset = "0x40")]
	public float SplatterLifeTime;

	[Token(Token = "0x4002E1C")]
	[FieldOffset(Offset = "0x44")]
	public float SplatterFadeTime;

	[Token(Token = "0x4002E1D")]
	[FieldOffset(Offset = "0x48")]
	public LayerMask KillLayer;

	[Token(Token = "0x4002E1E")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem KillParticles;

	[Token(Token = "0x4002E1F")]
	[FieldOffset(Offset = "0x58")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002E20")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 lastPosition;

	[Token(Token = "0x4002E21")]
	[FieldOffset(Offset = "0x70")]
	private GameObject splatterContainer;

	[Token(Token = "0x4002E22")]
	[FieldOffset(Offset = "0x78")]
	private ObjectPool<SpriteRenderer> splatterPool;

	[Token(Token = "0x4002E23")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<SpriteRenderer, float> activeSplatters;

	[Token(Token = "0x4002E24")]
	[FieldOffset(Offset = "0x88")]
	private GolfBallController controller;

	[Token(Token = "0x60026DE")]
	[Address(RVA = "0x16A2BA8", Offset = "0x16A2BA8", VA = "0x16A2BA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60026DF")]
	[Address(RVA = "0x16A2C70", Offset = "0x16A2C70", VA = "0x16A2C70")]
	private void Start()
	{
	}

	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x16A2D6C", Offset = "0x16A2D6C", VA = "0x16A2D6C")]
	private void Update()
	{
	}

	[Token(Token = "0x60026E1")]
	[Address(RVA = "0x16A2FD8", Offset = "0x16A2FD8", VA = "0x16A2FD8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60026E2")]
	[Address(RVA = "0x16A36B0", Offset = "0x16A36B0", VA = "0x16A36B0")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x60026E3")]
	[Address(RVA = "0x16A31DC", Offset = "0x16A31DC", VA = "0x16A31DC")]
	private void SplatterAt(ContactPoint contact, GameObject objectHit)
	{
	}

	[Token(Token = "0x60026E4")]
	[Address(RVA = "0x16A37C8", Offset = "0x16A37C8", VA = "0x16A37C8")]
	public Shooter()
	{
	}
}
