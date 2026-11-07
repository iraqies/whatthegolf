using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000A00")]
public class OverworldEndBall : OverworldBall2D
{
	[Token(Token = "0x2000A01")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x428E8", Offset = "0x428E8")]
	private sealed class _003CDeathRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003735")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003736")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x20")]
		public OverworldEndBall _003C_003E4__this;

		[Token(Token = "0x170004DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F6B")]
			[Address(RVA = "0x1810924", Offset = "0x1810924", VA = "0x1810924", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F6D")]
			[Address(RVA = "0x181096C", Offset = "0x181096C", VA = "0x181096C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F68")]
		[Address(RVA = "0x18106D4", Offset = "0x18106D4", VA = "0x18106D4")]
		[DebuggerHidden]
		public _003CDeathRoutine_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F69")]
		[Address(RVA = "0x1810700", Offset = "0x1810700", VA = "0x1810700", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F6A")]
		[Address(RVA = "0x1810704", Offset = "0x1810704", VA = "0x1810704", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F6B")]
		[Address(RVA = "0x1810924", Offset = "0x1810924", VA = "0x1810924", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F6C")]
		[Address(RVA = "0x181092C", Offset = "0x181092C", VA = "0x181092C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F6D")]
		[Address(RVA = "0x181096C", Offset = "0x181096C", VA = "0x181096C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003723")]
	[FieldOffset(Offset = "0xD8")]
	public List<Renderer> sprites;

	[Token(Token = "0x4003724")]
	[FieldOffset(Offset = "0xE0")]
	public float shootInterval;

	[Token(Token = "0x4003725")]
	[FieldOffset(Offset = "0xE4")]
	public int maxShots;

	[Token(Token = "0x4003726")]
	[FieldOffset(Offset = "0xE8")]
	public float backMoveForceSpeed;

	[Token(Token = "0x4003727")]
	[FieldOffset(Offset = "0xEC")]
	public float shootSpeed;

	[Token(Token = "0x4003728")]
	[FieldOffset(Offset = "0xF0")]
	public Rigidbody2D spitPrefab;

	[Token(Token = "0x4003729")]
	[FieldOffset(Offset = "0xF8")]
	public float RequiredDistanceForHittingFlags;

	[Token(Token = "0x400372A")]
	[FieldOffset(Offset = "0x100")]
	public AudioSource jetpackAudioSource;

	[Token(Token = "0x400372B")]
	[FieldOffset(Offset = "0x108")]
	private float distanceMovedSinceHitFlag;

	[Token(Token = "0x400372C")]
	[FieldOffset(Offset = "0x10C")]
	private Vector3 lastPos;

	[Token(Token = "0x400372D")]
	[FieldOffset(Offset = "0x118")]
	private float timeSinceLastShot;

	[Token(Token = "0x400372E")]
	[FieldOffset(Offset = "0x120")]
	private ObjectPool<Rigidbody2D> pool;

	[Token(Token = "0x400372F")]
	[FieldOffset(Offset = "0x128")]
	private Queue<Rigidbody2D> spawnedSpit;

	[Token(Token = "0x4003730")]
	[FieldOffset(Offset = "0x130")]
	public AudioClip sfxSpit;

	[Token(Token = "0x4003731")]
	[FieldOffset(Offset = "0x138")]
	private bool isDead;

	[Token(Token = "0x4003732")]
	[FieldOffset(Offset = "0x140")]
	private SaveEvents save;

	[Token(Token = "0x4003733")]
	[FieldOffset(Offset = "0x148")]
	public ParticleSystem[] JetpackParticles;

	[Token(Token = "0x4003734")]
	[FieldOffset(Offset = "0x150")]
	public Animator[] FireAnimators;

	[Token(Token = "0x6002F5A")]
	[Address(RVA = "0x15B3FB8", Offset = "0x15B3FB8", VA = "0x15B3FB8", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6002F5B")]
	[Address(RVA = "0x15B40D8", Offset = "0x15B40D8", VA = "0x15B40D8", Slot = "16")]
	protected override void Controller_OnAimUpdate(Vector3 dir, bool onlyLine)
	{
	}

	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0x15B420C", Offset = "0x15B420C", VA = "0x15B420C")]
	private void ShootBullet(Vector3 dir)
	{
	}

	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x15B4404", Offset = "0x15B4404", VA = "0x15B4404")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002F5E")]
	[Address(RVA = "0x15B44C0", Offset = "0x15B44C0", VA = "0x15B44C0", Slot = "15")]
	protected override void Controller_OnAimStart()
	{
	}

	[Token(Token = "0x6002F5F")]
	[Address(RVA = "0x15B45E4", Offset = "0x15B45E4", VA = "0x15B45E4", Slot = "17")]
	protected override void Shooter_OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6002F60")]
	[Address(RVA = "0x15B46E0", Offset = "0x15B46E0", VA = "0x15B46E0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002F61")]
	[Address(RVA = "0x15B46E4", Offset = "0x15B46E4", VA = "0x15B46E4", Slot = "14")]
	protected override void Controller_OnCancel()
	{
	}

	[Token(Token = "0x6002F62")]
	[Address(RVA = "0x15B44EC", Offset = "0x15B44EC", VA = "0x15B44EC")]
	private void StartJetpack()
	{
	}

	[Token(Token = "0x6002F63")]
	[Address(RVA = "0x15B45E8", Offset = "0x15B45E8", VA = "0x15B45E8")]
	private void StopJetpack()
	{
	}

	[Token(Token = "0x6002F64")]
	[Address(RVA = "0x15B470C", Offset = "0x15B470C", VA = "0x15B470C")]
	public void Die()
	{
	}

	[Token(Token = "0x6002F65")]
	[Address(RVA = "0x15B47A0", Offset = "0x15B47A0", VA = "0x15B47A0")]
	private IEnumerator DeathRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002F66")]
	[Address(RVA = "0x15B4814", Offset = "0x15B4814", VA = "0x15B4814", Slot = "18")]
	public override void OnHiddenByTransition()
	{
	}

	[Token(Token = "0x6002F67")]
	[Address(RVA = "0x15B4A2C", Offset = "0x15B4A2C", VA = "0x15B4A2C")]
	public OverworldEndBall()
	{
	}
}
