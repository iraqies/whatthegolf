using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio.Rumble;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x200083C")]
public class SuperGolfShootEnemy : MonoBehaviour
{
	[Token(Token = "0x200083D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41928", Offset = "0x41928")]
	private sealed class _003CSpawnDelay_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C97")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C98")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C99")]
		[FieldOffset(Offset = "0x20")]
		public SuperGolfShootEnemy _003C_003E4__this;

		[Token(Token = "0x4002C9A")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x1700041A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60025F7")]
			[Address(RVA = "0x185D4E8", Offset = "0x185D4E8", VA = "0x185D4E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700041B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60025F9")]
			[Address(RVA = "0x185D530", Offset = "0x185D530", VA = "0x185D530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60025F4")]
		[Address(RVA = "0x185D2A0", Offset = "0x185D2A0", VA = "0x185D2A0")]
		[DebuggerHidden]
		public _003CSpawnDelay_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60025F5")]
		[Address(RVA = "0x185D2CC", Offset = "0x185D2CC", VA = "0x185D2CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60025F6")]
		[Address(RVA = "0x185D2D0", Offset = "0x185D2D0", VA = "0x185D2D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60025F7")]
		[Address(RVA = "0x185D4E8", Offset = "0x185D4E8", VA = "0x185D4E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60025F8")]
		[Address(RVA = "0x185D4F0", Offset = "0x185D4F0", VA = "0x185D4F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60025F9")]
		[Address(RVA = "0x185D530", Offset = "0x185D530", VA = "0x185D530", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002C6F")]
	[FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x4002C70")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem DeathParticles;

	[Token(Token = "0x4002C71")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem SpawnParticles;

	[Token(Token = "0x4002C72")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 SpawnInterval;

	[Token(Token = "0x4002C73")]
	[FieldOffset(Offset = "0x38")]
	public int Health;

	[Token(Token = "0x4002C74")]
	[FieldOffset(Offset = "0x3C")]
	public bool LookAtTarget;

	[Token(Token = "0x4002C75")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> DeathClips;

	[Token(Token = "0x4002C76")]
	[FieldOffset(Offset = "0x48")]
	public List<RumbleEventAsset> DeathRumbles;

	[Token(Token = "0x4002C77")]
	[FieldOffset(Offset = "0x50")]
	public SuperGolfGun EquippedGun;

	[Token(Token = "0x4002C78")]
	[FieldOffset(Offset = "0x58")]
	public Transform GunHand;

	[Token(Token = "0x4002C79")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 ShootInterval;

	[Token(Token = "0x4002C7A")]
	[FieldOffset(Offset = "0x68")]
	public bool RequireLOS;

	[Token(Token = "0x4002C7B")]
	[FieldOffset(Offset = "0x6C")]
	public float ShootingRange;

	[Token(Token = "0x4002C7C")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 UnequippedGunRotation;

	[Token(Token = "0x4002C7D")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 EquippedGunRotation;

	[Token(Token = "0x4002C7E")]
	[FieldOffset(Offset = "0x88")]
	public float FirstShotTime;

	[Token(Token = "0x4002C7F")]
	[FieldOffset(Offset = "0x8C")]
	public bool ChaseEnemy;

	[Token(Token = "0x4002C80")]
	[FieldOffset(Offset = "0x90")]
	public float StopDistance;

	[Token(Token = "0x4002C81")]
	[FieldOffset(Offset = "0x94")]
	public float AlertDistance;

	[Token(Token = "0x4002C82")]
	[FieldOffset(Offset = "0x98")]
	public Quaternion DeathRotation;

	[Token(Token = "0x4002C83")]
	[FieldOffset(Offset = "0xA8")]
	public Action<SuperGolfShootEnemy> OnDeath;

	[Token(Token = "0x4002C84")]
	[FieldOffset(Offset = "0xB0")]
	private Timeline timeline;

	[Token(Token = "0x4002C85")]
	[FieldOffset(Offset = "0xB8")]
	private float shootTimer;

	[Token(Token = "0x4002C86")]
	[FieldOffset(Offset = "0xBC")]
	private float spawnTime;

	[Token(Token = "0x4002C87")]
	[FieldOffset(Offset = "0xC0")]
	private NavMeshAgent agent;

	[Token(Token = "0x4002C88")]
	[FieldOffset(Offset = "0xC8")]
	private Renderer[] renderers;

	[Token(Token = "0x4002C89")]
	[FieldOffset(Offset = "0xD0")]
	private Light light;

	[Token(Token = "0x4002C8A")]
	[FieldOffset(Offset = "0xD8")]
	private Collider collider;

	[Token(Token = "0x4002C8B")]
	[FieldOffset(Offset = "0xE0")]
	private float startLightIntensity;

	[Token(Token = "0x4002C8C")]
	[FieldOffset(Offset = "0xE4")]
	private bool hasSpawned;

	[Token(Token = "0x4002C8D")]
	[FieldOffset(Offset = "0xE8")]
	private Rigidbody targetRigidbody;

	[Token(Token = "0x4002C8E")]
	[FieldOffset(Offset = "0xF0")]
	private Animator animator;

	[Token(Token = "0x4002C8F")]
	[FieldOffset(Offset = "0xF8")]
	private float predictionRatio;

	[Token(Token = "0x4002C90")]
	[FieldOffset(Offset = "0xFC")]
	private float bulletSpeed;

	[Token(Token = "0x4002C91")]
	[FieldOffset(Offset = "0x100")]
	private float layerWeightChange;

	[Token(Token = "0x4002C92")]
	[FieldOffset(Offset = "0x104")]
	private float avgTargetVelocityMagnitude;

	[Token(Token = "0x4002C93")]
	[FieldOffset(Offset = "0x108")]
	private float capsuleRadius;

	[Token(Token = "0x4002C94")]
	[FieldOffset(Offset = "0x10C")]
	private bool gameWon;

	[Token(Token = "0x4002C95")]
	[FieldOffset(Offset = "0x110")]
	private SuperGolfShooter playerShooter;

	[Token(Token = "0x4002C96")]
	[FieldOffset(Offset = "0x118")]
	private ObjectShatter objectShatter;

	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x16EA754", Offset = "0x16EA754", VA = "0x16EA754")]
	private void Awake()
	{
	}

	[Token(Token = "0x60025E7")]
	[Address(RVA = "0x16EA8F4", Offset = "0x16EA8F4", VA = "0x16EA8F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60025E8")]
	[Address(RVA = "0x16EAF70", Offset = "0x16EAF70", VA = "0x16EAF70")]
	private void Update()
	{
	}

	[Token(Token = "0x60025E9")]
	[Address(RVA = "0x16EAEF4", Offset = "0x16EAEF4", VA = "0x16EAEF4")]
	private void ToggleRenderers(bool state)
	{
	}

	[Token(Token = "0x60025EA")]
	[Address(RVA = "0x16EBA00", Offset = "0x16EBA00", VA = "0x16EBA00")]
	private IEnumerator SpawnDelay()
	{
		return null;
	}

	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x16EBA74", Offset = "0x16EBA74", VA = "0x16EBA74")]
	public void Kill()
	{
	}

	[Token(Token = "0x60025EC")]
	[Address(RVA = "0x16E8918", Offset = "0x16E8918", VA = "0x16E8918")]
	public void Kill(Vector3 direction)
	{
	}

	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x16EBA9C", Offset = "0x16EBA9C", VA = "0x16EBA9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60025EE")]
	[Address(RVA = "0x16EBB18", Offset = "0x16EBB18", VA = "0x16EBB18")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x16EBBF8", Offset = "0x16EBBF8", VA = "0x16EBBF8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x16EBC74", Offset = "0x16EBC74", VA = "0x16EBC74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60025F1")]
	[Address(RVA = "0x16EBD28", Offset = "0x16EBD28", VA = "0x16EBD28")]
	public SuperGolfShootEnemy()
	{
	}

	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x16EBD7C", Offset = "0x16EBD7C", VA = "0x16EBD7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66B40", Offset = "0x66B40")]
	private void _003CStart_003Eb__41_0(Level.CompletedState s)
	{
	}

	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x16EBD88", Offset = "0x16EBD88", VA = "0x16EBD88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66B50", Offset = "0x66B50")]
	private void _003CKill_003Eb__46_0(AudioSource t)
	{
	}
}
