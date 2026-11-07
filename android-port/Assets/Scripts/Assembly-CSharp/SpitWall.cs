using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000AD2")]
public class SpitWall : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000AD3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43328", Offset = "0x43328")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003C56")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003C57")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__14_0;

		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x18595F8", Offset = "0x18595F8", VA = "0x18595F8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60033C6")]
		[Address(RVA = "0x1859600", Offset = "0x1859600", VA = "0x1859600")]
		internal void _003CSpit_003Eb__14_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x4003C4A")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip sfxSpit;

	[Token(Token = "0x4003C4B")]
	[FieldOffset(Offset = "0x20")]
	public float shootInterval;

	[Token(Token = "0x4003C4C")]
	[FieldOffset(Offset = "0x24")]
	public float shootDistance;

	[Token(Token = "0x4003C4D")]
	[FieldOffset(Offset = "0x28")]
	public int maxShots;

	[Token(Token = "0x4003C4E")]
	[FieldOffset(Offset = "0x2C")]
	public float maxAngle;

	[Token(Token = "0x4003C4F")]
	[FieldOffset(Offset = "0x30")]
	public float shootSpeed;

	[Token(Token = "0x4003C50")]
	[FieldOffset(Offset = "0x38")]
	public Transform spitPositionTransform;

	[Token(Token = "0x4003C51")]
	[FieldOffset(Offset = "0x40")]
	public Rigidbody2D spitPrefab;

	[Token(Token = "0x4003C52")]
	[FieldOffset(Offset = "0x48")]
	private float nextSpit;

	[Token(Token = "0x4003C53")]
	[FieldOffset(Offset = "0x50")]
	private Queue<Rigidbody2D> spawnedSpit;

	[Token(Token = "0x4003C54")]
	[FieldOffset(Offset = "0x58")]
	private ObjectPool<Rigidbody2D> pool;

	[Token(Token = "0x4003C55")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 lastBallPosition;

	[Token(Token = "0x60033C0")]
	[Address(RVA = "0x16D791C", Offset = "0x16D791C", VA = "0x16D791C")]
	private void Start()
	{
	}

	[Token(Token = "0x60033C1")]
	[Address(RVA = "0x16D7A0C", Offset = "0x16D7A0C", VA = "0x16D7A0C")]
	private void Update()
	{
	}

	[Token(Token = "0x60033C2")]
	[Address(RVA = "0x16D7B2C", Offset = "0x16D7B2C", VA = "0x16D7B2C")]
	private void Spit(Vector3 dir)
	{
	}

	[Token(Token = "0x60033C3")]
	[Address(RVA = "0x16D7E44", Offset = "0x16D7E44", VA = "0x16D7E44")]
	public SpitWall()
	{
	}
}
