using System;
using System.Collections.Generic;
using Audio;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200083E")]
public class SuperGolfShooter : GolfBallShooterExperimental
{
	[Token(Token = "0x200083F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41938", Offset = "0x41938")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x4002CBB")]
		[FieldOffset(Offset = "0x10")]
		public SuperGolfShooter _003C_003E4__this;

		[Token(Token = "0x4002CBC")]
		[FieldOffset(Offset = "0x18")]
		public float currentTimescale;

		[Token(Token = "0x6002608")]
		[Address(RVA = "0x185D634", Offset = "0x185D634", VA = "0x185D634")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6002609")]
		[Address(RVA = "0x185D63C", Offset = "0x185D63C", VA = "0x185D63C")]
		internal void _003CKill_003Eb__1(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000840")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41948", Offset = "0x41948")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002CBD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002CBE")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__42_0;

		[Token(Token = "0x4002CBF")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__42_2;

		[Token(Token = "0x600260B")]
		[Address(RVA = "0x185D598", Offset = "0x185D598", VA = "0x185D598")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600260C")]
		[Address(RVA = "0x185D5A0", Offset = "0x185D5A0", VA = "0x185D5A0")]
		internal void _003CKill_003Eb__42_0(AudioSource s)
		{
		}

		[Token(Token = "0x600260D")]
		[Address(RVA = "0x185D5C8", Offset = "0x185D5C8", VA = "0x185D5C8")]
		internal void _003CKill_003Eb__42_2()
		{
		}
	}

	[Token(Token = "0x4002C9B")]
	[FieldOffset(Offset = "0x88")]
	public float SmashVelocity;

	[Token(Token = "0x4002C9C")]
	[FieldOffset(Offset = "0x90")]
	public GlobalClock GlobalClock;

	[Token(Token = "0x4002C9D")]
	[FieldOffset(Offset = "0x98")]
	public float MinTimeScale;

	[Token(Token = "0x4002C9E")]
	[FieldOffset(Offset = "0xA0")]
	public SuperGolfGun EquippedGun;

	[Token(Token = "0x4002C9F")]
	[FieldOffset(Offset = "0xA8")]
	public bool IsShooting;

	[Token(Token = "0x4002CA0")]
	[FieldOffset(Offset = "0xAC")]
	public Vector3 WeaponPositionOffset;

	[Token(Token = "0x4002CA1")]
	[FieldOffset(Offset = "0xB8")]
	public List<AudioClip> WeaponPickupClips;

	[Token(Token = "0x4002CA2")]
	[FieldOffset(Offset = "0xC0")]
	public ClipSettingsCollection sfxOnPickup;

	[Token(Token = "0x4002CA3")]
	[FieldOffset(Offset = "0xC8")]
	public AudioClip deathClip;

	[Token(Token = "0x4002CA4")]
	[FieldOffset(Offset = "0xD0")]
	public bool RestartGameWhenDead;

	[Token(Token = "0x4002CA5")]
	[FieldOffset(Offset = "0xD1")]
	public bool useSlowShot;

	[Token(Token = "0x4002CA6")]
	[FieldOffset(Offset = "0xD4")]
	public float slowShootPct;

	[Token(Token = "0x4002CA7")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject Model;

	[Token(Token = "0x4002CA8")]
	[FieldOffset(Offset = "0xE0")]
	public bool RotatePlayerOnAim;

	[Token(Token = "0x4002CA9")]
	[FieldOffset(Offset = "0xE1")]
	public bool SpeedAffectsTime;

	[Token(Token = "0x4002CAA")]
	[FieldOffset(Offset = "0xE2")]
	public bool CanDie;

	[Token(Token = "0x4002CAB")]
	[FieldOffset(Offset = "0xE3")]
	public bool KnockbackWhenShooting;

	[Token(Token = "0x4002CAC")]
	[FieldOffset(Offset = "0xE8")]
	public Action<SuperGolfShooter> OnDeath;

	[Token(Token = "0x4002CAD")]
	[FieldOffset(Offset = "0xF0")]
	public Action<SuperGolfGun, Vector3> OnPlayerShot;

	[Token(Token = "0x4002CAE")]
	[FieldOffset(Offset = "0xF8")]
	public Action<SuperGolfGun> OnWeaponPickUp;

	[Token(Token = "0x4002CAF")]
	[FieldOffset(Offset = "0x100")]
	public bool RotateGunWithPlayer;

	[Token(Token = "0x4002CB0")]
	[FieldOffset(Offset = "0x104")]
	public float KillEquipBlockTime;

	[Token(Token = "0x4002CB1")]
	[FieldOffset(Offset = "0x108")]
	public float SphereCastRadius;

	[Token(Token = "0x4002CB2")]
	[FieldOffset(Offset = "0x10C")]
	public float MaxDistance;

	[Token(Token = "0x4002CB3")]
	[FieldOffset(Offset = "0x110")]
	public bool IsDead;

	[Token(Token = "0x4002CB4")]
	[FieldOffset(Offset = "0x118")]
	private Collider collider;

	[Token(Token = "0x4002CB5")]
	[FieldOffset(Offset = "0x120")]
	private Vector3 velocityLastFrame;

	[Token(Token = "0x4002CB6")]
	[FieldOffset(Offset = "0x12C")]
	private float currentAmbientTimescale;

	[Token(Token = "0x4002CB7")]
	[FieldOffset(Offset = "0x130")]
	private float extraTime;

	[Token(Token = "0x4002CB8")]
	[FieldOffset(Offset = "0x138")]
	private ObjectShatter objectShatter;

	[Token(Token = "0x4002CB9")]
	[FieldOffset(Offset = "0x140")]
	private Vector3 lastBoost;

	[Token(Token = "0x4002CBA")]
	[FieldOffset(Offset = "0x14C")]
	private float killEquipBlockTimer;

	[Token(Token = "0x60025FA")]
	[Address(RVA = "0x16EBE04", Offset = "0x16EBE04", VA = "0x16EBE04", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60025FB")]
	[Address(RVA = "0x16EBE98", Offset = "0x16EBE98", VA = "0x16EBE98")]
	private void Start()
	{
	}

	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x16EBF50", Offset = "0x16EBF50", VA = "0x16EBF50")]
	private void Instance_OnGoal(Level.CompletedState s)
	{
	}

	[Token(Token = "0x60025FD")]
	[Address(RVA = "0x16EBF5C", Offset = "0x16EBF5C", VA = "0x16EBF5C", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60025FE")]
	[Address(RVA = "0x16EC530", Offset = "0x16EC530", VA = "0x16EC530", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60025FF")]
	[Address(RVA = "0x16EC840", Offset = "0x16EC840", VA = "0x16EC840", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002600")]
	[Address(RVA = "0x16EC98C", Offset = "0x16EC98C", VA = "0x16EC98C")]
	public void SetExtraTime(float time)
	{
	}

	[Token(Token = "0x6002601")]
	[Address(RVA = "0x16EC994", Offset = "0x16EC994", VA = "0x16EC994")]
	public void StopAiming()
	{
	}

	[Token(Token = "0x6002602")]
	[Address(RVA = "0x16ECA38", Offset = "0x16ECA38", VA = "0x16ECA38")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002603")]
	[Address(RVA = "0x16ECAB8", Offset = "0x16ECAB8", VA = "0x16ECAB8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002604")]
	[Address(RVA = "0x16E8BD4", Offset = "0x16E8BD4", VA = "0x16E8BD4")]
	public void Kill()
	{
	}

	[Token(Token = "0x6002605")]
	[Address(RVA = "0x16ED020", Offset = "0x16ED020", VA = "0x16ED020")]
	public SuperGolfShooter()
	{
	}

	[Token(Token = "0x6002606")]
	[Address(RVA = "0x16ED05C", Offset = "0x16ED05C", VA = "0x16ED05C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66BB0", Offset = "0x66BB0")]
	private void _003COnShoot_003Eb__36_0()
	{
	}

	[Token(Token = "0x6002607")]
	[Address(RVA = "0x16ED0F8", Offset = "0x16ED0F8", VA = "0x16ED0F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66BC0", Offset = "0x66BC0")]
	private void _003COnCollisionEnter_003Eb__41_0(AudioSource t)
	{
	}
}
