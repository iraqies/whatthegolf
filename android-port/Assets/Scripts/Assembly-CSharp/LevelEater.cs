using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200085F")]
public class LevelEater : MonoBehaviour
{
	[Token(Token = "0x2000860")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41A08", Offset = "0x41A08")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4002D7C")]
		[FieldOffset(Offset = "0x10")]
		public LevelEater _003C_003E4__this;

		[Token(Token = "0x4002D7D")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x24")]
		public float dist;

		[Token(Token = "0x6002699")]
		[Address(RVA = "0x17D3260", Offset = "0x17D3260", VA = "0x17D3260")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600269A")]
		[Address(RVA = "0x17D3268", Offset = "0x17D3268", VA = "0x17D3268")]
		internal void _003CEatLevel_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000861")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41A18", Offset = "0x41A18")]
	private sealed class _003CEatLevel_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002D80")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002D81")]
		[FieldOffset(Offset = "0x20")]
		public LevelEater _003C_003E4__this;

		[Token(Token = "0x4002D82")]
		[FieldOffset(Offset = "0x28")]
		public float dist;

		[Token(Token = "0x17000427")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600269E")]
			[Address(RVA = "0x17D3554", Offset = "0x17D3554", VA = "0x17D3554", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000428")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60026A0")]
			[Address(RVA = "0x17D359C", Offset = "0x17D359C", VA = "0x17D359C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600269B")]
		[Address(RVA = "0x17D334C", Offset = "0x17D334C", VA = "0x17D334C")]
		[DebuggerHidden]
		public _003CEatLevel_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600269C")]
		[Address(RVA = "0x17D3378", Offset = "0x17D3378", VA = "0x17D3378", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600269D")]
		[Address(RVA = "0x17D337C", Offset = "0x17D337C", VA = "0x17D337C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600269E")]
		[Address(RVA = "0x17D3554", Offset = "0x17D3554", VA = "0x17D3554", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600269F")]
		[Address(RVA = "0x17D355C", Offset = "0x17D355C", VA = "0x17D355C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x17D359C", Offset = "0x17D359C", VA = "0x17D359C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002D71")]
	[FieldOffset(Offset = "0x18")]
	public float EatInterval;

	[Token(Token = "0x4002D72")]
	[FieldOffset(Offset = "0x1C")]
	public float EatDistance;

	[Token(Token = "0x4002D73")]
	[FieldOffset(Offset = "0x20")]
	public float EatDuration;

	[Token(Token = "0x4002D74")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve EatCurve;

	[Token(Token = "0x4002D75")]
	[FieldOffset(Offset = "0x30")]
	public List<AudioClip> MoveClips;

	[Token(Token = "0x4002D76")]
	[FieldOffset(Offset = "0x38")]
	public List<AudioClip> EatClips;

	[Token(Token = "0x4002D77")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem Particles;

	[Token(Token = "0x4002D78")]
	[FieldOffset(Offset = "0x48")]
	public float Duration;

	[Token(Token = "0x4002D79")]
	[FieldOffset(Offset = "0x4C")]
	public float Magnitude;

	[Token(Token = "0x4002D7A")]
	[FieldOffset(Offset = "0x50")]
	public float Speed;

	[Token(Token = "0x4002D7B")]
	[FieldOffset(Offset = "0x54")]
	private float timer;

	[Token(Token = "0x6002695")]
	[Address(RVA = "0x152D2C4", Offset = "0x152D2C4", VA = "0x152D2C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002696")]
	[Address(RVA = "0x152D444", Offset = "0x152D444", VA = "0x152D444")]
	private void Update()
	{
	}

	[Token(Token = "0x6002697")]
	[Address(RVA = "0x152D3C0", Offset = "0x152D3C0", VA = "0x152D3C0")]
	private IEnumerator EatLevel(float dist)
	{
		return null;
	}

	[Token(Token = "0x6002698")]
	[Address(RVA = "0x152D4F8", Offset = "0x152D4F8", VA = "0x152D4F8")]
	public LevelEater()
	{
	}
}
