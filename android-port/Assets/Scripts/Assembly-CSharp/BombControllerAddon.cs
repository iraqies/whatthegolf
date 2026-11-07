using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D63")]
public class BombControllerAddon : MonoBehaviour
{
	[Token(Token = "0x2000D64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44928", Offset = "0x44928")]
	private sealed class _003CWaitForCooldown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40048E6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40048E7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40048E8")]
		[FieldOffset(Offset = "0x20")]
		public BombControllerAddon _003C_003E4__this;

		[Token(Token = "0x17000669")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F06")]
			[Address(RVA = "0x1773BFC", Offset = "0x1773BFC", VA = "0x1773BFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700066A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F08")]
			[Address(RVA = "0x1773C44", Offset = "0x1773C44", VA = "0x1773C44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F03")]
		[Address(RVA = "0x1773B0C", Offset = "0x1773B0C", VA = "0x1773B0C")]
		[DebuggerHidden]
		public _003CWaitForCooldown_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F04")]
		[Address(RVA = "0x1773B38", Offset = "0x1773B38", VA = "0x1773B38", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F05")]
		[Address(RVA = "0x1773B3C", Offset = "0x1773B3C", VA = "0x1773B3C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F06")]
		[Address(RVA = "0x1773BFC", Offset = "0x1773BFC", VA = "0x1773BFC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F07")]
		[Address(RVA = "0x1773C04", Offset = "0x1773C04", VA = "0x1773C04", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F08")]
		[Address(RVA = "0x1773C44", Offset = "0x1773C44", VA = "0x1773C44", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40048D9")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem explosionParticlesPrefab;

	[Token(Token = "0x40048DA")]
	[FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x40048DB")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem _explosion;

	[Token(Token = "0x40048DC")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x40048DD")]
	[FieldOffset(Offset = "0x38")]
	public float explosionForce;

	[Token(Token = "0x40048DE")]
	[FieldOffset(Offset = "0x3C")]
	public float selfExplosionForce;

	[Token(Token = "0x40048DF")]
	[FieldOffset(Offset = "0x40")]
	public float selfExplosionCooldown;

	[Token(Token = "0x40048E0")]
	[FieldOffset(Offset = "0x44")]
	public bool explodeFootballPlayers;

	[Token(Token = "0x40048E1")]
	[FieldOffset(Offset = "0x48")]
	public LayerMask checkLayer;

	[Token(Token = "0x40048E2")]
	[FieldOffset(Offset = "0x4C")]
	public float explosionRadius;

	[Token(Token = "0x40048E3")]
	[FieldOffset(Offset = "0x50")]
	private bool inCooldown;

	[Token(Token = "0x40048E4")]
	[FieldOffset(Offset = "0x58")]
	private GameObject lastObjectToCauseExplosion;

	[Token(Token = "0x40048E5")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PlayAudioClipSetting _playAudioOnExplode;

	[Token(Token = "0x6003EFF")]
	[Address(RVA = "0x1617EDC", Offset = "0x1617EDC", VA = "0x1617EDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F00")]
	[Address(RVA = "0x161801C", Offset = "0x161801C", VA = "0x161801C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003F01")]
	[Address(RVA = "0x1618560", Offset = "0x1618560", VA = "0x1618560")]
	private IEnumerator WaitForCooldown()
	{
		return null;
	}

	[Token(Token = "0x6003F02")]
	[Address(RVA = "0x16185D4", Offset = "0x16185D4", VA = "0x16185D4")]
	public BombControllerAddon()
	{
	}
}
