using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ABB")]
public class OverworldMouth : MonoBehaviour
{
	[Token(Token = "0x2000ABC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43018", Offset = "0x43018")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4003BD3")]
		[FieldOffset(Offset = "0x10")]
		public OverworldMouth _003C_003E4__this;

		[Token(Token = "0x4003BD4")]
		[FieldOffset(Offset = "0x18")]
		public OverworldBall2D ball;

		[Token(Token = "0x4003BD5")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 ballStart;

		[Token(Token = "0x600335D")]
		[Address(RVA = "0x181AF08", Offset = "0x181AF08", VA = "0x181AF08")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x600335E")]
		[Address(RVA = "0x181AF10", Offset = "0x181AF10", VA = "0x181AF10")]
		internal void _003CEat_003Eb__0(float t)
		{
		}

		[Token(Token = "0x600335F")]
		[Address(RVA = "0x181B078", Offset = "0x181B078", VA = "0x181B078")]
		internal void _003CEat_003Eb__1(float t)
		{
		}

		[Token(Token = "0x6003360")]
		[Address(RVA = "0x181B144", Offset = "0x181B144", VA = "0x181B144")]
		internal void _003CEat_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x2000ABD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43028", Offset = "0x43028")]
	private sealed class _003CEat_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003BD6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003BD7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003BD8")]
		[FieldOffset(Offset = "0x20")]
		public OverworldMouth _003C_003E4__this;

		[Token(Token = "0x4003BD9")]
		[FieldOffset(Offset = "0x28")]
		public OverworldBall2D ball;

		[Token(Token = "0x4003BDA")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		[Token(Token = "0x1700054F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003364")]
			[Address(RVA = "0x181B7E0", Offset = "0x181B7E0", VA = "0x181B7E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000550")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003366")]
			[Address(RVA = "0x181B828", Offset = "0x181B828", VA = "0x181B828", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003361")]
		[Address(RVA = "0x181B2A4", Offset = "0x181B2A4", VA = "0x181B2A4")]
		[DebuggerHidden]
		public _003CEat_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003362")]
		[Address(RVA = "0x181B2D0", Offset = "0x181B2D0", VA = "0x181B2D0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003363")]
		[Address(RVA = "0x181B2D4", Offset = "0x181B2D4", VA = "0x181B2D4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003364")]
		[Address(RVA = "0x181B7E0", Offset = "0x181B7E0", VA = "0x181B7E0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003365")]
		[Address(RVA = "0x181B7E8", Offset = "0x181B7E8", VA = "0x181B7E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003366")]
		[Address(RVA = "0x181B828", Offset = "0x181B828", VA = "0x181B828", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003BC5")]
	[FieldOffset(Offset = "0x18")]
	public Transform leftMouth;

	[Token(Token = "0x4003BC6")]
	[FieldOffset(Offset = "0x20")]
	public Transform rightMouth;

	[Token(Token = "0x4003BC7")]
	[FieldOffset(Offset = "0x28")]
	public Transform leftMouthInPos;

	[Token(Token = "0x4003BC8")]
	[FieldOffset(Offset = "0x30")]
	public Transform rightMouthInPos;

	[Token(Token = "0x4003BC9")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve closeCurve;

	[Token(Token = "0x4003BCA")]
	[FieldOffset(Offset = "0x40")]
	public ShortcutTunnelEntry tunnelEntry;

	[Token(Token = "0x4003BCB")]
	[FieldOffset(Offset = "0x48")]
	public float animationTime;

	[Token(Token = "0x4003BCC")]
	[FieldOffset(Offset = "0x4C")]
	private float nextEatTime;

	[Token(Token = "0x4003BCD")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 rightMouthOutPosition;

	[Token(Token = "0x4003BCE")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 leftMouthOutPosition;

	[Token(Token = "0x4003BCF")]
	[FieldOffset(Offset = "0x68")]
	public Animator SuckerAnimator;

	[Token(Token = "0x4003BD0")]
	[FieldOffset(Offset = "0x70")]
	public Animator FlagAnimator;

	[Token(Token = "0x4003BD1")]
	[FieldOffset(Offset = "0x78")]
	public float delaySFX;

	[Token(Token = "0x4003BD2")]
	[FieldOffset(Offset = "0x80")]
	public ClipSettingsCollection EatSFX;

	[Token(Token = "0x6003359")]
	[Address(RVA = "0x15C57DC", Offset = "0x15C57DC", VA = "0x15C57DC")]
	private void Start()
	{
	}

	[Token(Token = "0x600335A")]
	[Address(RVA = "0x15C582C", Offset = "0x15C582C", VA = "0x15C582C")]
	private IEnumerator Eat(OverworldBall2D ball)
	{
		return null;
	}

	[Token(Token = "0x600335B")]
	[Address(RVA = "0x15C58A4", Offset = "0x15C58A4", VA = "0x15C58A4")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600335C")]
	[Address(RVA = "0x15C5A04", Offset = "0x15C5A04", VA = "0x15C5A04")]
	public OverworldMouth()
	{
	}
}
