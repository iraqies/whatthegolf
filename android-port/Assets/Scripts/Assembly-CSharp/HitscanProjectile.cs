using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200089C")]
public class HitscanProjectile : SuperGolfBullet
{
	[Token(Token = "0x200089D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B60", Offset = "0x41B60")]
	private sealed class _003CNextFrameMoveTrail_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002F50")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002F51")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002F52")]
		[FieldOffset(Offset = "0x20")]
		public HitscanProjectile _003C_003E4__this;

		[Token(Token = "0x4002F53")]
		[FieldOffset(Offset = "0x28")]
		public RaycastHit hit;

		[Token(Token = "0x17000435")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60027CA")]
			[Address(RVA = "0x17BC0B0", Offset = "0x17BC0B0", VA = "0x17BC0B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000436")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60027CC")]
			[Address(RVA = "0x17BC0F8", Offset = "0x17BC0F8", VA = "0x17BC0F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x17BBFB0", Offset = "0x17BBFB0", VA = "0x17BBFB0")]
		[DebuggerHidden]
		public _003CNextFrameMoveTrail_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x17BBFDC", Offset = "0x17BBFDC", VA = "0x17BBFDC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x17BBFE0", Offset = "0x17BBFE0", VA = "0x17BBFE0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x17BC0B0", Offset = "0x17BC0B0", VA = "0x17BC0B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x17BC0B8", Offset = "0x17BC0B8", VA = "0x17BC0B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x17BC0F8", Offset = "0x17BC0F8", VA = "0x17BC0F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002F4B")]
	[FieldOffset(Offset = "0x90")]
	public float Force;

	[Token(Token = "0x4002F4C")]
	[FieldOffset(Offset = "0x94")]
	public float TrailOffset;

	[Token(Token = "0x4002F4D")]
	[FieldOffset(Offset = "0x98")]
	public RandomAudioClips ricochetSounds;

	[Token(Token = "0x4002F4E")]
	[FieldOffset(Offset = "0xA0")]
	private float lifetimeTimer;

	[Token(Token = "0x4002F4F")]
	[FieldOffset(Offset = "0xA8")]
	private ParticleSystem particles;

	[Token(Token = "0x60027C0")]
	[Address(RVA = "0x14CD254", Offset = "0x14CD254", VA = "0x14CD254", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60027C1")]
	[Address(RVA = "0x14CD2BC", Offset = "0x14CD2BC", VA = "0x14CD2BC", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60027C2")]
	[Address(RVA = "0x14CD728", Offset = "0x14CD728", VA = "0x14CD728")]
	private IEnumerator NextFrameMoveTrail(RaycastHit hit)
	{
		return null;
	}

	[Token(Token = "0x60027C3")]
	[Address(RVA = "0x14CD7BC", Offset = "0x14CD7BC", VA = "0x14CD7BC", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60027C4")]
	[Address(RVA = "0x14CD824", Offset = "0x14CD824", VA = "0x14CD824", Slot = "8")]
	protected override void KillBullet(Vector3 point)
	{
	}

	[Token(Token = "0x60027C5")]
	[Address(RVA = "0x14CD894", Offset = "0x14CD894", VA = "0x14CD894", Slot = "6")]
	public override void SetSpeed(float speedMod)
	{
	}

	[Token(Token = "0x60027C6")]
	[Address(RVA = "0x14CD898", Offset = "0x14CD898", VA = "0x14CD898")]
	public HitscanProjectile()
	{
	}
}
