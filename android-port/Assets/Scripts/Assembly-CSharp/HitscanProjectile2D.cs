using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200089E")]
public class HitscanProjectile2D : SuperGolfBullet
{
	[Token(Token = "0x200089F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B70", Offset = "0x41B70")]
	private sealed class _003CLaunchProjectile_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002F60")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002F61")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x20")]
		public HitscanProjectile2D _003C_003E4__this;

		[Token(Token = "0x17000437")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60027D8")]
			[Address(RVA = "0x17BC318", Offset = "0x17BC318", VA = "0x17BC318", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000438")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60027DA")]
			[Address(RVA = "0x17BC360", Offset = "0x17BC360", VA = "0x17BC360", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x17BC100", Offset = "0x17BC100", VA = "0x17BC100")]
		[DebuggerHidden]
		public _003CLaunchProjectile_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x17BC12C", Offset = "0x17BC12C", VA = "0x17BC12C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x17BC130", Offset = "0x17BC130", VA = "0x17BC130", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x17BC318", Offset = "0x17BC318", VA = "0x17BC318", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x17BC320", Offset = "0x17BC320", VA = "0x17BC320", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x17BC360", Offset = "0x17BC360", VA = "0x17BC360", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002F54")]
	[FieldOffset(Offset = "0x90")]
	public float Force;

	[Token(Token = "0x4002F55")]
	[FieldOffset(Offset = "0x94")]
	public float TrailOffset;

	[Token(Token = "0x4002F56")]
	[FieldOffset(Offset = "0x98")]
	public float distance;

	[Token(Token = "0x4002F57")]
	[FieldOffset(Offset = "0x9C")]
	public LayerMask hitMask;

	[Token(Token = "0x4002F58")]
	[FieldOffset(Offset = "0xA0")]
	public bool CanShootFlag;

	[Token(Token = "0x4002F59")]
	[FieldOffset(Offset = "0xA8")]
	public ClipSettingsCollection _ricochetSounds;

	[Token(Token = "0x4002F5A")]
	[FieldOffset(Offset = "0xB0")]
	public ClipSettingsCollection shootSounds;

	[Token(Token = "0x4002F5B")]
	[FieldOffset(Offset = "0xB8")]
	private float lifetimeTimer;

	[Token(Token = "0x4002F5C")]
	[FieldOffset(Offset = "0xC0")]
	private ParticleSystem particles;

	[Token(Token = "0x4002F5D")]
	[FieldOffset(Offset = "0xC8")]
	private int bouncesLeft;

	[Token(Token = "0x4002F5E")]
	[FieldOffset(Offset = "0xCC")]
	private int bouncesDone;

	[Token(Token = "0x4002F5F")]
	[FieldOffset(Offset = "0xD0")]
	private TrailRenderer projectileTrail;

	[Token(Token = "0x60027CD")]
	[Address(RVA = "0x14CD8AC", Offset = "0x14CD8AC", VA = "0x14CD8AC", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60027CE")]
	[Address(RVA = "0x14CD938", Offset = "0x14CD938", VA = "0x14CD938", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60027CF")]
	[Address(RVA = "0x14CD9EC", Offset = "0x14CD9EC", VA = "0x14CD9EC")]
	private IEnumerator LaunchProjectile()
	{
		return null;
	}

	[Token(Token = "0x60027D0")]
	[Address(RVA = "0x14CDA60", Offset = "0x14CDA60", VA = "0x14CDA60")]
	private void CheckProjectilePath(Vector3 origin, Vector3 direction)
	{
	}

	[Token(Token = "0x60027D1")]
	[Address(RVA = "0x14CE0A8", Offset = "0x14CE0A8", VA = "0x14CE0A8", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60027D2")]
	[Address(RVA = "0x14CE13C", Offset = "0x14CE13C", VA = "0x14CE13C", Slot = "8")]
	protected override void KillBullet(Vector3 point)
	{
	}

	[Token(Token = "0x60027D3")]
	[Address(RVA = "0x14CE1AC", Offset = "0x14CE1AC", VA = "0x14CE1AC", Slot = "6")]
	public override void SetSpeed(float speedMod)
	{
	}

	[Token(Token = "0x60027D4")]
	[Address(RVA = "0x14CE1B0", Offset = "0x14CE1B0", VA = "0x14CE1B0")]
	public HitscanProjectile2D()
	{
	}
}
