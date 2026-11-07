using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000634")]
public class BossPlayerEgg : MonoBehaviour
{
	[Token(Token = "0x2000635")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40AC0", Offset = "0x40AC0")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002023")]
		[FieldOffset(Offset = "0x10")]
		public BossPlayerEgg _003C_003E4__this;

		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startScale;

		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x1776AFC", Offset = "0x1776AFC", VA = "0x1776AFC")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x1776B04", Offset = "0x1776B04", VA = "0x1776B04")]
		internal void _003CStart_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000636")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40AD0", Offset = "0x40AD0")]
	private sealed class _003CStart_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002025")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002026")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002027")]
		[FieldOffset(Offset = "0x20")]
		public BossPlayerEgg _003C_003E4__this;

		[Token(Token = "0x4002028")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x1700031D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C54")]
			[Address(RVA = "0x1777130", Offset = "0x1777130", VA = "0x1777130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700031E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C56")]
			[Address(RVA = "0x1777178", Offset = "0x1777178", VA = "0x1777178", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x1776BD4", Offset = "0x1776BD4", VA = "0x1776BD4")]
		[DebuggerHidden]
		public _003CStart_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x1776C00", Offset = "0x1776C00", VA = "0x1776C00", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x1776C04", Offset = "0x1776C04", VA = "0x1776C04", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x1777130", Offset = "0x1777130", VA = "0x1777130", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x1777138", Offset = "0x1777138", VA = "0x1777138", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x1777178", Offset = "0x1777178", VA = "0x1777178", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002015")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController PlayerController;

	[Token(Token = "0x4002016")]
	[FieldOffset(Offset = "0x20")]
	public float FinalSize;

	[Token(Token = "0x4002017")]
	[FieldOffset(Offset = "0x24")]
	public float HatchTime;

	[Token(Token = "0x4002018")]
	[FieldOffset(Offset = "0x28")]
	public float ShakeDuration;

	[Token(Token = "0x4002019")]
	[FieldOffset(Offset = "0x2C")]
	public float ShakeSpeed;

	[Token(Token = "0x400201A")]
	[FieldOffset(Offset = "0x30")]
	public float ShakeAmount;

	[Token(Token = "0x400201B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject CrackedEgg;

	[Token(Token = "0x400201C")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent OnHatchEvent;

	[Token(Token = "0x400201D")]
	[FieldOffset(Offset = "0x48")]
	public bool UseEggHeightOnHatch;

	[Token(Token = "0x400201E")]
	[FieldOffset(Offset = "0x4C")]
	public float OverrideHatchHeight;

	[Token(Token = "0x400201F")]
	[FieldOffset(Offset = "0x50")]
	public AudioClipSettings HatchSound;

	[Token(Token = "0x4002020")]
	[FieldOffset(Offset = "0x58")]
	public AudioSource ShakeSound;

	[Token(Token = "0x4002021")]
	[FieldOffset(Offset = "0x60")]
	public AudioSource GrowSound;

	[Token(Token = "0x4002022")]
	[FieldOffset(Offset = "0x68")]
	public Animator RobotFaceAnimator;

	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x16FF240", Offset = "0x16FF240", VA = "0x16FF240")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0x16FF2B4", Offset = "0x16FF2B4", VA = "0x16FF2B4")]
	public BossPlayerEgg()
	{
	}
}
