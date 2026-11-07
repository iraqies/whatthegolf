using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200031D")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3EF48", Offset = "0x3EF48")]
public class SingingHole : MonoBehaviour
{
	[Token(Token = "0x200031E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EFB0", Offset = "0x3EFB0")]
	private sealed class _003CScaleUpCR_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400114C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400114D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400114E")]
		[FieldOffset(Offset = "0x20")]
		public SingingHole _003C_003E4__this;

		[Token(Token = "0x170001AF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E61")]
			[Address(RVA = "0x184FE00", Offset = "0x184FE00", VA = "0x184FE00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x184FE48", Offset = "0x184FE48", VA = "0x184FE48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x184FB34", Offset = "0x184FB34", VA = "0x184FB34")]
		[DebuggerHidden]
		public _003CScaleUpCR_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x184FB60", Offset = "0x184FB60", VA = "0x184FB60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E60")]
		[Address(RVA = "0x184FB64", Offset = "0x184FB64", VA = "0x184FB64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x184FE00", Offset = "0x184FE00", VA = "0x184FE00", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x184FE08", Offset = "0x184FE08", VA = "0x184FE08", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x184FE48", Offset = "0x184FE48", VA = "0x184FE48", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x18")]
	public List<int> beats;

	[Token(Token = "0x400113E")]
	[FieldOffset(Offset = "0x20")]
	public float durationIn;

	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0x24")]
	public float speedMod;

	[Token(Token = "0x4001140")]
	[FieldOffset(Offset = "0x28")]
	public float durationOut;

	[Token(Token = "0x4001141")]
	[FieldOffset(Offset = "0x2C")]
	public float audiosourceDelay;

	[Token(Token = "0x4001142")]
	[FieldOffset(Offset = "0x30")]
	public float to;

	[Token(Token = "0x4001143")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem particles;

	[Token(Token = "0x4001144")]
	[FieldOffset(Offset = "0x40")]
	private AudioSource audioSrc;

	[Token(Token = "0x4001145")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve animationCurveIn;

	[Token(Token = "0x4001146")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve animationCurveOut;

	[Token(Token = "0x4001147")]
	[FieldOffset(Offset = "0x58")]
	public int beatCount;

	[Token(Token = "0x4001148")]
	[FieldOffset(Offset = "0x5C")]
	public float stayOpenDuration;

	[Token(Token = "0x4001149")]
	[FieldOffset(Offset = "0x60")]
	private int timeFloor;

	[Token(Token = "0x400114A")]
	[FieldOffset(Offset = "0x64")]
	private int ptimeFloor;

	[Token(Token = "0x400114B")]
	[FieldOffset(Offset = "0x68")]
	private float time;

	[Token(Token = "0x6000E58")]
	[Address(RVA = "0x16B25B4", Offset = "0x16B25B4", VA = "0x16B25B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E59")]
	[Address(RVA = "0x16B2610", Offset = "0x16B2610", VA = "0x16B2610")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x16B2720", Offset = "0x16B2720", VA = "0x16B2720")]
	private IEnumerator ScaleUpCR()
	{
		return null;
	}

	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x16B2794", Offset = "0x16B2794", VA = "0x16B2794")]
	public SingingHole()
	{
	}

	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x16B27B8", Offset = "0x16B27B8", VA = "0x16B27B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60CCC", Offset = "0x60CCC")]
	private void _003CScaleUpCR_003Eb__17_0(float t)
	{
	}

	[Token(Token = "0x6000E5D")]
	[Address(RVA = "0x16B288C", Offset = "0x16B288C", VA = "0x16B288C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60CDC", Offset = "0x60CDC")]
	private void _003CScaleUpCR_003Eb__17_1(float t)
	{
	}
}
