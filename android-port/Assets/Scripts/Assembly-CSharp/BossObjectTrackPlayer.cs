using System;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000630")]
public class BossObjectTrackPlayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000631")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40AB0", Offset = "0x40AB0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001FFF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002000")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GolfBallController, bool> _003C_003E9__6_0;

		[Token(Token = "0x6001C3F")]
		[Address(RVA = "0x1776AD8", Offset = "0x1776AD8", VA = "0x1776AD8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x1776AE0", Offset = "0x1776AE0", VA = "0x1776AE0")]
		internal bool _003CStart_003Eb__6_0(GolfBallController g)
		{
			return default;
		}
	}

	[Token(Token = "0x4001FF9")]
	[FieldOffset(Offset = "0x18")]
	public float MoveSpeed;

	[Token(Token = "0x4001FFA")]
	[FieldOffset(Offset = "0x20")]
	public RandomAudioClips DeathClips;

	[Token(Token = "0x4001FFB")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController controller;

	[Token(Token = "0x4001FFC")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x4001FFD")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem destroyParticles;

	[Token(Token = "0x4001FFE")]
	[FieldOffset(Offset = "0x40")]
	private bool isGrounded;

	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x16FDF4C", Offset = "0x16FDF4C", VA = "0x16FDF4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x16FE15C", Offset = "0x16FE15C", VA = "0x16FE15C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001C3B")]
	[Address(RVA = "0x16FE31C", Offset = "0x16FE31C", VA = "0x16FE31C")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x6001C3C")]
	[Address(RVA = "0x16FE328", Offset = "0x16FE328", VA = "0x16FE328")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6001C3D")]
	[Address(RVA = "0x16FE488", Offset = "0x16FE488", VA = "0x16FE488")]
	public BossObjectTrackPlayer()
	{
	}
}
