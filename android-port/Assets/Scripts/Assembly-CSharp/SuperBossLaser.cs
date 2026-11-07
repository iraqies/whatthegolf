using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200081E")]
public class SuperBossLaser : MonoBehaviour
{
	[Token(Token = "0x200081F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x417E0", Offset = "0x417E0")]
	private sealed class _003CSpawnNewGun_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BB7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BB8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BB9")]
		[FieldOffset(Offset = "0x20")]
		public SuperBossLaser _003C_003E4__this;

		[Token(Token = "0x4002BBA")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ct_003E5__2;

		[Token(Token = "0x1700040A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002552")]
			[Address(RVA = "0x185C32C", Offset = "0x185C32C", VA = "0x185C32C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700040B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002554")]
			[Address(RVA = "0x185C374", Offset = "0x185C374", VA = "0x185C374", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600254F")]
		[Address(RVA = "0x185C21C", Offset = "0x185C21C", VA = "0x185C21C")]
		[DebuggerHidden]
		public _003CSpawnNewGun_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002550")]
		[Address(RVA = "0x185C248", Offset = "0x185C248", VA = "0x185C248", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002551")]
		[Address(RVA = "0x185C24C", Offset = "0x185C24C", VA = "0x185C24C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002552")]
		[Address(RVA = "0x185C32C", Offset = "0x185C32C", VA = "0x185C32C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002553")]
		[Address(RVA = "0x185C334", Offset = "0x185C334", VA = "0x185C334", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002554")]
		[Address(RVA = "0x185C374", Offset = "0x185C374", VA = "0x185C374", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002BAE")]
	[FieldOffset(Offset = "0x18")]
	public SuperPuttBoss CatBoss;

	[Token(Token = "0x4002BAF")]
	[FieldOffset(Offset = "0x20")]
	public Animator Animator;

	[Token(Token = "0x4002BB0")]
	[FieldOffset(Offset = "0x28")]
	public Animator GunAnimator;

	[Token(Token = "0x4002BB1")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> SpawnClips;

	[Token(Token = "0x4002BB2")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem SpawnParticles;

	[Token(Token = "0x4002BB3")]
	[FieldOffset(Offset = "0x40")]
	public float AutoUpTime;

	[Token(Token = "0x4002BB4")]
	[FieldOffset(Offset = "0x48")]
	public List<AudioClip> ShootClips;

	[Token(Token = "0x4002BB5")]
	[FieldOffset(Offset = "0x50")]
	private float cooldown;

	[Token(Token = "0x4002BB6")]
	[FieldOffset(Offset = "0x54")]
	private bool playerOnButton;

	[Token(Token = "0x6002547")]
	[Address(RVA = "0x16E7A78", Offset = "0x16E7A78", VA = "0x16E7A78")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002548")]
	[Address(RVA = "0x16E7B40", Offset = "0x16E7B40", VA = "0x16E7B40")]
	private void OnBossDead()
	{
	}

	[Token(Token = "0x6002549")]
	[Address(RVA = "0x16E7B9C", Offset = "0x16E7B9C", VA = "0x16E7B9C")]
	private void Update()
	{
	}

	[Token(Token = "0x600254A")]
	[Address(RVA = "0x16E7BD8", Offset = "0x16E7BD8", VA = "0x16E7BD8")]
	private void Trigger()
	{
	}

	[Token(Token = "0x600254B")]
	[Address(RVA = "0x16E7CC8", Offset = "0x16E7CC8", VA = "0x16E7CC8")]
	public IEnumerator SpawnNewGun()
	{
		return null;
	}

	[Token(Token = "0x600254C")]
	[Address(RVA = "0x16E7D3C", Offset = "0x16E7D3C", VA = "0x16E7D3C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600254D")]
	[Address(RVA = "0x16E7DD0", Offset = "0x16E7DD0", VA = "0x16E7DD0")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600254E")]
	[Address(RVA = "0x16E7E40", Offset = "0x16E7E40", VA = "0x16E7E40")]
	public SuperBossLaser()
	{
	}
}
