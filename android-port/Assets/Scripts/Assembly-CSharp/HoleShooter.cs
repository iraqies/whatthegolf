using System;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005E1")]
public class HoleShooter : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x20005E2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x408E0", Offset = "0x408E0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001DFF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001E00")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__13_0;

		[Token(Token = "0x6001AD0")]
		[Address(RVA = "0x17BE034", Offset = "0x17BE034", VA = "0x17BE034")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0x17BE03C", Offset = "0x17BE03C", VA = "0x17BE03C")]
		internal void _003COnShoot_003Eb__13_0(float t)
		{
		}
	}

	[Token(Token = "0x4001DF3")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float startUpForce;

	[Token(Token = "0x4001DF4")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float startForwardForce;

	[Token(Token = "0x4001DF5")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Collider croundCollider;

	[Token(Token = "0x4001DF6")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ParticleSystem breakFreeParticles;

	[Token(Token = "0x4001DF7")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float minShootVelocity;

	[Token(Token = "0x4001DF8")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float fullShootVelocity;

	[Token(Token = "0x4001DF9")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float pitch;

	[Token(Token = "0x4001DFA")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float spin;

	[Token(Token = "0x4001DFB")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform newArrowPosition;

	[Token(Token = "0x4001DFC")]
	[FieldOffset(Offset = "0x90")]
	private Collider col;

	[Token(Token = "0x4001DFD")]
	[FieldOffset(Offset = "0x98")]
	private bool firstShot;

	[Token(Token = "0x4001DFE")]
	[FieldOffset(Offset = "0xA0")]
	private Transform firstShotArrowPosition;

	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x14D0A2C", Offset = "0x14D0A2C", VA = "0x14D0A2C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x14D0AA8", Offset = "0x14D0AA8", VA = "0x14D0AA8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001ACC")]
	[Address(RVA = "0x14D0E88", Offset = "0x14D0E88", VA = "0x14D0E88", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x6001ACD")]
	[Address(RVA = "0x14D0EE8", Offset = "0x14D0EE8", VA = "0x14D0EE8")]
	public HoleShooter()
	{
	}

	[Token(Token = "0x6001ACE")]
	[Address(RVA = "0x14D0F04", Offset = "0x14D0F04", VA = "0x14D0F04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6394C", Offset = "0x6394C")]
	private void _003COnShoot_003Eb__13_1()
	{
	}
}
