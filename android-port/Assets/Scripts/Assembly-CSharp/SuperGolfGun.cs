using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Audio;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000837")]
public class SuperGolfGun : MonoBehaviour
{
	[Token(Token = "0x2000838")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x418E8", Offset = "0x418E8")]
	private sealed class _003CStartShooting_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SuperGolfGun _003C_003E4__this;

		[Token(Token = "0x4002C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 direction;

		[Token(Token = "0x4002C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Collider shooterCollider;

		[Token(Token = "0x4002C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onFinishedShooting;

		[Token(Token = "0x4002C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000416")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60025D8")]
			[Address(RVA = "0x185D250", Offset = "0x185D250", VA = "0x185D250", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000417")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60025DA")]
			[Address(RVA = "0x185D298", Offset = "0x185D298", VA = "0x185D298", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x185CEA4", Offset = "0x185CEA4", VA = "0x185CEA4")]
		[DebuggerHidden]
		public _003CStartShooting_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60025D6")]
		[Address(RVA = "0x185CED0", Offset = "0x185CED0", VA = "0x185CED0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x185CED4", Offset = "0x185CED4", VA = "0x185CED4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60025D8")]
		[Address(RVA = "0x185D250", Offset = "0x185D250", VA = "0x185D250", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x185D258", Offset = "0x185D258", VA = "0x185D258", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60025DA")]
		[Address(RVA = "0x185D298", Offset = "0x185D298", VA = "0x185D298", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000839")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x418F8", Offset = "0x418F8")]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x4002C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Collider shooterCollider;

		[Token(Token = "0x4002C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SuperGolfGun _003C_003E4__this;

		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x185CC5C", Offset = "0x185CC5C", VA = "0x185CC5C")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x185CC64", Offset = "0x185CC64", VA = "0x185CC64")]
		internal void _003CThrowGun_003Eb__1()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200083A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41908", Offset = "0x41908")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__31_0;

		[Token(Token = "0x60025DE")]
		[Address(RVA = "0x185CC50", Offset = "0x185CC50", VA = "0x185CC50")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60025DF")]
		[Address(RVA = "0x185CC58", Offset = "0x185CC58", VA = "0x185CC58")]
		internal void _003CThrowGun_003Eb__31_0(float t)
		{
		}
	}

	[Token(Token = "0x200083B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41918", Offset = "0x41918")]
	private sealed class _003CFlash_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SuperGolfGun _003C_003E4__this;

		[Token(Token = "0x4002C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003Cm_003E5__2;

		[Token(Token = "0x4002C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _003CflashIntensity_003E5__3;

		[Token(Token = "0x17000418")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60025E3")]
			[Address(RVA = "0x185CE54", Offset = "0x185CE54", VA = "0x185CE54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000419")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60025E5")]
			[Address(RVA = "0x185CE9C", Offset = "0x185CE9C", VA = "0x185CE9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60025E0")]
		[Address(RVA = "0x185CD14", Offset = "0x185CD14", VA = "0x185CD14")]
		[DebuggerHidden]
		public _003CFlash_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x185CD40", Offset = "0x185CD40", VA = "0x185CD40", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x185CD44", Offset = "0x185CD44", VA = "0x185CD44", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x185CE54", Offset = "0x185CE54", VA = "0x185CE54", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x185CE5C", Offset = "0x185CE5C", VA = "0x185CE5C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x185CE9C", Offset = "0x185CE9C", VA = "0x185CE9C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002C49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject BulletPrefab;

	[Token(Token = "0x4002C4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform BulletSpawnPoint;

	[Token(Token = "0x4002C4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int Amount;

	[Token(Token = "0x4002C4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int ShotsLeft;

	[Token(Token = "0x4002C4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float Spread;

	[Token(Token = "0x4002C4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float TimeSpread;

	[Token(Token = "0x4002C4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ParticleSystem ShootParticles;

	[Token(Token = "0x4002C50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<AudioClip> ShootClips;

	[Token(Token = "0x4002C51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ClipSettingsCollection sfxOnShoot;

	[Token(Token = "0x4002C52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool CanBePickedUp;

	[Token(Token = "0x4002C53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Collider collider;

	[Token(Token = "0x4002C54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public FollowTransform follow;

	[Token(Token = "0x4002C55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool StopRigidbodyOnPickup;

	[Token(Token = "0x4002C56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool ToggleKinematicOnPickup;

	[Token(Token = "0x4002C57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool LockYOnPickup;

	[Token(Token = "0x4002C58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ObjectPool<GameObject> bulletPool;

	[Token(Token = "0x4002C59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool explodeOnImpact;

	[Token(Token = "0x4002C5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private LaserSight laser;

	[Token(Token = "0x4002C5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Light flash;

	[Token(Token = "0x4002C5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool initialized;

	[Token(Token = "0x4002C5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Timeline timeline;

	[Token(Token = "0x4002C5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Rigidbody rigidbody;

	[Token(Token = "0x60025C6")]
	[Address(RVA = "0x16E9918", Offset = "0x16E9918", VA = "0x16E9918")]
	private void Awake()
	{
	}

	[Token(Token = "0x60025C7")]
	[Address(RVA = "0x16E9A40", Offset = "0x16E9A40", VA = "0x16E9A40")]
	private void Start()
	{
	}

	[Token(Token = "0x60025C8")]
	[Address(RVA = "0x16E9BC8", Offset = "0x16E9BC8", VA = "0x16E9BC8")]
	public void SetOwner(GolfBallController owner)
	{
	}

	[Token(Token = "0x60025C9")]
	[Address(RVA = "0x16E9C74", Offset = "0x16E9C74", VA = "0x16E9C74", Slot = "4")]
	public virtual void Equip(Transform hand, bool followRotation, [Optional] Collider shooterCollider)
	{
	}

	[Token(Token = "0x60025CA")]
	[Address(RVA = "0x16E9E28", Offset = "0x16E9E28", VA = "0x16E9E28", Slot = "5")]
	public virtual bool IsEquipped()
	{
		return default;
	}

	[Token(Token = "0x60025CB")]
	[Address(RVA = "0x16E9ECC", Offset = "0x16E9ECC", VA = "0x16E9ECC")]
	public void Shoot(Collider shooterCollider, Vector3 direction, [Optional] Action onFinishedShooting)
	{
	}

	[Token(Token = "0x60025CC")]
	[Address(RVA = "0x16EA1F8", Offset = "0x16EA1F8", VA = "0x16EA1F8", Slot = "6")]
	protected virtual IEnumerator StartShooting(Collider shooterCollider, Vector3 direction, [Optional] Action onFinishedShooting)
	{
		return null;
	}

	[Token(Token = "0x60025CD")]
	[Address(RVA = "0x16EA2A4", Offset = "0x16EA2A4", VA = "0x16EA2A4", Slot = "7")]
	protected virtual void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60025CE")]
	[Address(RVA = "0x16EA338", Offset = "0x16EA338", VA = "0x16EA338", Slot = "8")]
	public virtual void DestroyGun([Optional] Collider shooterCollider)
	{
	}

	[Token(Token = "0x60025CF")]
	[Address(RVA = "0x16EA378", Offset = "0x16EA378", VA = "0x16EA378", Slot = "9")]
	public virtual void ThrowGun(Collider shooterCollider)
	{
	}

	[Token(Token = "0x60025D0")]
	[Address(RVA = "0x16EA650", Offset = "0x16EA650", VA = "0x16EA650")]
	public void AddForce(Vector3 force)
	{
	}

	[Token(Token = "0x60025D1")]
	[Address(RVA = "0x16E9B1C", Offset = "0x16E9B1C", VA = "0x16E9B1C")]
	public void ToggleLaser(bool state)
	{
	}

	[Token(Token = "0x60025D2")]
	[Address(RVA = "0x16EA184", Offset = "0x16EA184", VA = "0x16EA184")]
	private IEnumerator Flash()
	{
		return null;
	}

	[Token(Token = "0x60025D3")]
	[Address(RVA = "0x16EA6C4", Offset = "0x16EA6C4", VA = "0x16EA6C4")]
	public SuperGolfGun()
	{
	}

	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x16EA6E0", Offset = "0x16EA6E0", VA = "0x16EA6E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66A90", Offset = "0x66A90")]
	private void _003CShoot_003Eb__27_0(AudioSource t)
	{
	}
}
