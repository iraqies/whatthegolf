using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D9C")]
public class LivingBush : MonoBehaviour
{
	[Token(Token = "0x2000D9D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BB0", Offset = "0x44BB0")]
	private sealed class _003CSFX_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004A26")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004A27")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004A28")]
		[FieldOffset(Offset = "0x20")]
		public LivingBush _003C_003E4__this;

		[Token(Token = "0x1700068B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004003")]
			[Address(RVA = "0x17E9DE4", Offset = "0x17E9DE4", VA = "0x17E9DE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700068C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004005")]
			[Address(RVA = "0x17E9E2C", Offset = "0x17E9E2C", VA = "0x17E9E2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004000")]
		[Address(RVA = "0x17E9CDC", Offset = "0x17E9CDC", VA = "0x17E9CDC")]
		[DebuggerHidden]
		public _003CSFX_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004001")]
		[Address(RVA = "0x17E9D08", Offset = "0x17E9D08", VA = "0x17E9D08", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004002")]
		[Address(RVA = "0x17E9D0C", Offset = "0x17E9D0C", VA = "0x17E9D0C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004003")]
		[Address(RVA = "0x17E9DE4", Offset = "0x17E9DE4", VA = "0x17E9DE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004004")]
		[Address(RVA = "0x17E9DEC", Offset = "0x17E9DEC", VA = "0x17E9DEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004005")]
		[Address(RVA = "0x17E9E2C", Offset = "0x17E9E2C", VA = "0x17E9E2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004A17")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LivingBush _bush;

	[Token(Token = "0x4004A18")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _speed;

	[Token(Token = "0x4004A19")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController _controller;

	[Token(Token = "0x4004A1A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ForceMode _forceMode;

	[Token(Token = "0x4004A1B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform _shootPos;

	[Token(Token = "0x4004A1C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator _animator;

	[Token(Token = "0x4004A1D")]
	[FieldOffset(Offset = "0x48")]
	public UnityEvent OnShoot;

	[Token(Token = "0x4004A1E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int Bounce;

	[Token(Token = "0x4004A1F")]
	[FieldOffset(Offset = "0x50")]
	private bool _isHit;

	[Token(Token = "0x4004A20")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _eyes;

	[Token(Token = "0x4004A21")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private PlayAudioClipSetting _SFXOnImpact;

	[Token(Token = "0x4004A22")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PlayAudioClipSetting _SFXOnThrow;

	[Token(Token = "0x4004A23")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private PlayAudioClipSetting _SFXOnAwake;

	[Token(Token = "0x4004A24")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Transform _aimTransform;

	[Token(Token = "0x4004A25")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float _throwDelay;

	[Token(Token = "0x6003FF8")]
	[Address(RVA = "0x1534EBC", Offset = "0x1534EBC", VA = "0x1534EBC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003FF9")]
	[Address(RVA = "0x1534FC0", Offset = "0x1534FC0", VA = "0x1534FC0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003FFA")]
	[Address(RVA = "0x15354E8", Offset = "0x15354E8", VA = "0x15354E8")]
	private void WakeUp()
	{
	}

	[Token(Token = "0x6003FFB")]
	[Address(RVA = "0x1535528", Offset = "0x1535528", VA = "0x1535528")]
	private IEnumerator SFX()
	{
		return null;
	}

	[Token(Token = "0x6003FFC")]
	[Address(RVA = "0x1535448", Offset = "0x1535448", VA = "0x1535448")]
	private void Lookat(Transform t)
	{
	}

	[Token(Token = "0x6003FFD")]
	[Address(RVA = "0x153559C", Offset = "0x153559C", VA = "0x153559C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003FFE")]
	[Address(RVA = "0x15355E8", Offset = "0x15355E8", VA = "0x15355E8")]
	public LivingBush()
	{
	}
}
