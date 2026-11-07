using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DDB")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x44D40", Offset = "0x44D40")]
public class SingingHoleFan : MonoBehaviour
{
	[Token(Token = "0x2000DDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44DA8", Offset = "0x44DA8")]
	private sealed class _003CScaleUpCR_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004B80")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004B81")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004B82")]
		[FieldOffset(Offset = "0x20")]
		public SingingHoleFan _003C_003E4__this;

		[Token(Token = "0x170006BA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600414F")]
			[Address(RVA = "0x18503DC", Offset = "0x18503DC", VA = "0x18503DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006BB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004151")]
			[Address(RVA = "0x1850424", Offset = "0x1850424", VA = "0x1850424", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600414C")]
		[Address(RVA = "0x184FE50", Offset = "0x184FE50", VA = "0x184FE50")]
		[DebuggerHidden]
		public _003CScaleUpCR_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600414D")]
		[Address(RVA = "0x184FE7C", Offset = "0x184FE7C", VA = "0x184FE7C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600414E")]
		[Address(RVA = "0x184FE80", Offset = "0x184FE80", VA = "0x184FE80", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600414F")]
		[Address(RVA = "0x18503DC", Offset = "0x18503DC", VA = "0x18503DC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004150")]
		[Address(RVA = "0x18503E4", Offset = "0x18503E4", VA = "0x18503E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004151")]
		[Address(RVA = "0x1850424", Offset = "0x1850424", VA = "0x1850424", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004B6B")]
	[FieldOffset(Offset = "0x18")]
	public List<int> beats;

	[Token(Token = "0x4004B6C")]
	[FieldOffset(Offset = "0x20")]
	public float durationIn;

	[Token(Token = "0x4004B6D")]
	[FieldOffset(Offset = "0x24")]
	public float speedMod;

	[Token(Token = "0x4004B6E")]
	[FieldOffset(Offset = "0x28")]
	public float durationOut;

	[Token(Token = "0x4004B6F")]
	[FieldOffset(Offset = "0x2C")]
	public float audiosourceDelay;

	[Token(Token = "0x4004B70")]
	[FieldOffset(Offset = "0x30")]
	public float to;

	[Token(Token = "0x4004B71")]
	[FieldOffset(Offset = "0x38")]
	public GameObject fan;

	[Token(Token = "0x4004B72")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem nodeParticles;

	[Token(Token = "0x4004B73")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem windParticles;

	[Token(Token = "0x4004B74")]
	[FieldOffset(Offset = "0x50")]
	private AudioSource audioSrc;

	[Token(Token = "0x4004B75")]
	[FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurveIn;

	[Token(Token = "0x4004B76")]
	[FieldOffset(Offset = "0x60")]
	public AnimationCurve animationCurveOut;

	[Token(Token = "0x4004B77")]
	[FieldOffset(Offset = "0x68")]
	public int beatCount;

	[Token(Token = "0x4004B78")]
	[FieldOffset(Offset = "0x6C")]
	public float stayOpenDuration;

	[Token(Token = "0x4004B79")]
	[FieldOffset(Offset = "0x70")]
	private int timeFloor;

	[Token(Token = "0x4004B7A")]
	[FieldOffset(Offset = "0x74")]
	private int ptimeFloor;

	[Token(Token = "0x4004B7B")]
	[FieldOffset(Offset = "0x78")]
	private float time;

	[Token(Token = "0x4004B7C")]
	[FieldOffset(Offset = "0x80")]
	public GameObject flag;

	[Token(Token = "0x4004B7D")]
	[FieldOffset(Offset = "0x88")]
	public float flagHeight;

	[Token(Token = "0x4004B7E")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 flagStartPosition;

	[Token(Token = "0x4004B7F")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Animator _mouthAnimator;

	[Token(Token = "0x6004142")]
	[Address(RVA = "0x16B2960", Offset = "0x16B2960", VA = "0x16B2960")]
	private void Start()
	{
	}

	[Token(Token = "0x6004143")]
	[Address(RVA = "0x16B2A30", Offset = "0x16B2A30", VA = "0x16B2A30")]
	private void Update()
	{
	}

	[Token(Token = "0x6004144")]
	[Address(RVA = "0x16B2B40", Offset = "0x16B2B40", VA = "0x16B2B40")]
	private IEnumerator ScaleUpCR()
	{
		return null;
	}

	[Token(Token = "0x6004145")]
	[Address(RVA = "0x16B2BB4", Offset = "0x16B2BB4", VA = "0x16B2BB4")]
	public SingingHoleFan()
	{
	}

	[Token(Token = "0x6004146")]
	[Address(RVA = "0x16B2BD8", Offset = "0x16B2BD8", VA = "0x16B2BD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D304", Offset = "0x6D304")]
	private void _003CScaleUpCR_003Eb__23_0(float t)
	{
	}

	[Token(Token = "0x6004147")]
	[Address(RVA = "0x16B2C84", Offset = "0x16B2C84", VA = "0x16B2C84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D314", Offset = "0x6D314")]
	private void _003CScaleUpCR_003Eb__23_1(float t)
	{
	}

	[Token(Token = "0x6004148")]
	[Address(RVA = "0x16B2D30", Offset = "0x16B2D30", VA = "0x16B2D30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D324", Offset = "0x6D324")]
	private void _003CScaleUpCR_003Eb__23_2(float t)
	{
	}

	[Token(Token = "0x6004149")]
	[Address(RVA = "0x16B2DF4", Offset = "0x16B2DF4", VA = "0x16B2DF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D334", Offset = "0x6D334")]
	private void _003CScaleUpCR_003Eb__23_3(float t)
	{
	}

	[Token(Token = "0x600414A")]
	[Address(RVA = "0x16B2EA0", Offset = "0x16B2EA0", VA = "0x16B2EA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D344", Offset = "0x6D344")]
	private void _003CScaleUpCR_003Eb__23_4(float t)
	{
	}

	[Token(Token = "0x600414B")]
	[Address(RVA = "0x16B2F58", Offset = "0x16B2F58", VA = "0x16B2F58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6D354", Offset = "0x6D354")]
	private void _003CScaleUpCR_003Eb__23_5(float t)
	{
	}
}
