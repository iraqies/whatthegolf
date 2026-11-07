using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000695")]
public class WaveyTrail : MonoBehaviour
{
	[Token(Token = "0x2000696")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40EF0", Offset = "0x40EF0")]
	private sealed class _003CDelayedTrailClear_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002253")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002254")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002255")]
		[FieldOffset(Offset = "0x20")]
		public WaveyTrail _003C_003E4__this;

		[Token(Token = "0x1700036B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E2F")]
			[Address(RVA = "0x18773F0", Offset = "0x18773F0", VA = "0x18773F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700036C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E31")]
			[Address(RVA = "0x1877438", Offset = "0x1877438", VA = "0x1877438", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x18772EC", Offset = "0x18772EC", VA = "0x18772EC")]
		[DebuggerHidden]
		public _003CDelayedTrailClear_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x1877318", Offset = "0x1877318", VA = "0x1877318", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x187731C", Offset = "0x187731C", VA = "0x187731C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x18773F0", Offset = "0x18773F0", VA = "0x18773F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x18773F8", Offset = "0x18773F8", VA = "0x18773F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x1877438", Offset = "0x1877438", VA = "0x1877438", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400224D")]
	[FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x400224E")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 MoveRange;

	[Token(Token = "0x400224F")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 Axis;

	[Token(Token = "0x4002250")]
	[FieldOffset(Offset = "0x30")]
	public SHMUPController Player;

	[Token(Token = "0x4002251")]
	[FieldOffset(Offset = "0x38")]
	private TrailRenderer trail;

	[Token(Token = "0x4002252")]
	[FieldOffset(Offset = "0x40")]
	private Transform cachedTransform;

	[Token(Token = "0x6001E27")]
	[Address(RVA = "0x1751160", Offset = "0x1751160", VA = "0x1751160")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E28")]
	[Address(RVA = "0x175125C", Offset = "0x175125C", VA = "0x175125C")]
	private void OnSinkReset()
	{
	}

	[Token(Token = "0x6001E29")]
	[Address(RVA = "0x17512FC", Offset = "0x17512FC", VA = "0x17512FC")]
	private IEnumerator DelayedTrailClear()
	{
		return null;
	}

	[Token(Token = "0x6001E2A")]
	[Address(RVA = "0x1751370", Offset = "0x1751370", VA = "0x1751370")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E2B")]
	[Address(RVA = "0x1751460", Offset = "0x1751460", VA = "0x1751460")]
	public WaveyTrail()
	{
	}
}
