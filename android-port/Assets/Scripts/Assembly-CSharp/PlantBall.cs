using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using SpaceGolf;
using UnityEngine;

[Token(Token = "0x200085B")]
public class PlantBall : MonoBehaviour
{
	[Token(Token = "0x200085C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x419E8", Offset = "0x419E8")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody planetRigidbody;

		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x18")]
		public PlantBall _003C_003E4__this;

		[Token(Token = "0x600268E")]
		[Address(RVA = "0x18264DC", Offset = "0x18264DC", VA = "0x18264DC")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600268F")]
		[Address(RVA = "0x18264E4", Offset = "0x18264E4", VA = "0x18264E4")]
		internal void _003CFakeShoot_003Eb__1()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200085D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x419F8", Offset = "0x419F8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002D6D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002D6E")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__9_0;

		[Token(Token = "0x6002691")]
		[Address(RVA = "0x18264D0", Offset = "0x18264D0", VA = "0x18264D0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002692")]
		[Address(RVA = "0x18264D8", Offset = "0x18264D8", VA = "0x18264D8")]
		internal void _003CFakeShoot_003Eb__9_0(float t)
		{
		}
	}

	[Token(Token = "0x4002D63")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController FakeController;

	[Token(Token = "0x4002D64")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController PlanetController;

	[Token(Token = "0x4002D65")]
	[FieldOffset(Offset = "0x28")]
	public float PlanetFallVelocityMod;

	[Token(Token = "0x4002D66")]
	[FieldOffset(Offset = "0x2C")]
	public bool UseGravityOnFall;

	[Token(Token = "0x4002D67")]
	[FieldOffset(Offset = "0x2D")]
	public bool DisableKinematicOnShot;

	[Token(Token = "0x4002D68")]
	[FieldOffset(Offset = "0x30")]
	private Planet[] planets;

	[Token(Token = "0x4002D69")]
	[FieldOffset(Offset = "0x38")]
	private RotatingPlanet[] rotatingPlanets;

	[Token(Token = "0x4002D6A")]
	[FieldOffset(Offset = "0x40")]
	private List<Rigidbody> planetRigidbodies;

	[Token(Token = "0x600268B")]
	[Address(RVA = "0x15E4560", Offset = "0x15E4560", VA = "0x15E4560")]
	private void Start()
	{
	}

	[Token(Token = "0x600268C")]
	[Address(RVA = "0x15E4798", Offset = "0x15E4798", VA = "0x15E4798")]
	private void FakeShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600268D")]
	[Address(RVA = "0x15E4CD8", Offset = "0x15E4CD8", VA = "0x15E4CD8")]
	public PlantBall()
	{
	}
}
