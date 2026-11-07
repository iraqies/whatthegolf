using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D61")]
public class BikeEnterGoop : MonoBehaviour
{
	[Token(Token = "0x2000D62")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44918", Offset = "0x44918")]
	private sealed class _003CEndSlideCR_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40048D5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40048D6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40048D7")]
		[FieldOffset(Offset = "0x20")]
		public BikeEnterGoop _003C_003E4__this;

		[Token(Token = "0x40048D8")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _003CstartPos_003E5__2;

		[Token(Token = "0x17000667")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003EFC")]
			[Address(RVA = "0x17732B4", Offset = "0x17732B4", VA = "0x17732B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000668")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003EFE")]
			[Address(RVA = "0x17732FC", Offset = "0x17732FC", VA = "0x17732FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x17730B4", Offset = "0x17730B4", VA = "0x17730B4")]
		[DebuggerHidden]
		public _003CEndSlideCR_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x17730E0", Offset = "0x17730E0", VA = "0x17730E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x17730E4", Offset = "0x17730E4", VA = "0x17730E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003EFC")]
		[Address(RVA = "0x17732B4", Offset = "0x17732B4", VA = "0x17732B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0x17732BC", Offset = "0x17732BC", VA = "0x17732BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x17732FC", Offset = "0x17732FC", VA = "0x17732FC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40048C7")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 _direction;

	[Token(Token = "0x40048C8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GolfBallController _controller;

	[Token(Token = "0x40048C9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody _rigidBody;

	[Token(Token = "0x40048CA")]
	[FieldOffset(Offset = "0x38")]
	private bool _isSliding;

	[Token(Token = "0x40048CB")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _speedWhenSliding;

	[Token(Token = "0x40048CC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _speedMagniture;

	[Token(Token = "0x40048CD")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AudioSource _SlimeLoop;

	[Token(Token = "0x40048CE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _useTriggerExitInstead;

	[Token(Token = "0x40048CF")]
	[FieldOffset(Offset = "0x51")]
	private bool _exitingSlime;

	[Token(Token = "0x40048D0")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private double _extraSlideTime;

	[Token(Token = "0x40048D1")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _force;

	[Token(Token = "0x40048D2")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool isball;

	[Token(Token = "0x40048D3")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ParticleSystem _slideSystem;

	[Token(Token = "0x40048D4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool _noSpinWhenSliding;

	[Token(Token = "0x6003EEE")]
	[Address(RVA = "0x16106AC", Offset = "0x16106AC", VA = "0x16106AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6003EEF")]
	[Address(RVA = "0x161076C", Offset = "0x161076C", VA = "0x161076C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003EF0")]
	[Address(RVA = "0x161077C", Offset = "0x161077C", VA = "0x161077C")]
	private void StartSlime(Collider other)
	{
	}

	[Token(Token = "0x6003EF1")]
	[Address(RVA = "0x16108D0", Offset = "0x16108D0", VA = "0x16108D0")]
	private void EndSlime(Collider other)
	{
	}

	[Token(Token = "0x6003EF2")]
	[Address(RVA = "0x1610A40", Offset = "0x1610A40", VA = "0x1610A40")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6003EF3")]
	[Address(RVA = "0x1610A54", Offset = "0x1610A54", VA = "0x1610A54")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003EF4")]
	[Address(RVA = "0x16109CC", Offset = "0x16109CC", VA = "0x16109CC")]
	private IEnumerator EndSlideCR()
	{
		return null;
	}

	[Token(Token = "0x6003EF5")]
	[Address(RVA = "0x1610BF8", Offset = "0x1610BF8", VA = "0x1610BF8")]
	private void UpdateVelocity(float damper = 1f)
	{
	}

	[Token(Token = "0x6003EF6")]
	[Address(RVA = "0x1610C90", Offset = "0x1610C90", VA = "0x1610C90")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003EF7")]
	[Address(RVA = "0x1610D04", Offset = "0x1610D04", VA = "0x1610D04")]
	public BikeEnterGoop()
	{
	}

	[Token(Token = "0x6003EF8")]
	[Address(RVA = "0x1610D38", Offset = "0x1610D38", VA = "0x1610D38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C60C", Offset = "0x6C60C")]
	private bool _003CStart_003Eb__8_0()
	{
		return default;
	}
}
