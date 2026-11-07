using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000763")]
public class Brick : MonoBehaviour
{
	[Token(Token = "0x2000764")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41420", Offset = "0x41420")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4002731")]
		[FieldOffset(Offset = "0x10")]
		public Brick _003C_003E4__this;

		[Token(Token = "0x4002732")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startScale;

		[Token(Token = "0x6002210")]
		[Address(RVA = "0x177BB84", Offset = "0x177BB84", VA = "0x177BB84")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6002211")]
		[Address(RVA = "0x177BB8C", Offset = "0x177BB8C", VA = "0x177BB8C")]
		internal void _003COnCollisionEnter2D_003Eb__0(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000765")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41430", Offset = "0x41430")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__4_1;

		[Token(Token = "0x6002213")]
		[Address(RVA = "0x177BB20", Offset = "0x177BB20", VA = "0x177BB20")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002214")]
		[Address(RVA = "0x177BB28", Offset = "0x177BB28", VA = "0x177BB28")]
		internal void _003COnCollisionEnter2D_003Eb__4_1(AudioSource s)
		{
		}
	}

	[Token(Token = "0x400272E")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip sfxBreak;

	[Token(Token = "0x400272F")]
	[FieldOffset(Offset = "0x20")]
	private Collider2D col;

	[Token(Token = "0x4002730")]
	[FieldOffset(Offset = "0x28")]
	private bool isSolid;

	[Token(Token = "0x600220D")]
	[Address(RVA = "0x1708920", Offset = "0x1708920", VA = "0x1708920")]
	private void Start()
	{
	}

	[Token(Token = "0x600220E")]
	[Address(RVA = "0x170897C", Offset = "0x170897C", VA = "0x170897C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600220F")]
	[Address(RVA = "0x1708BD4", Offset = "0x1708BD4", VA = "0x1708BD4")]
	public Brick()
	{
	}
}
