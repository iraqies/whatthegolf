using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D98")]
public class LerpScale : MonoBehaviour
{
	[Token(Token = "0x2000D99")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B90", Offset = "0x44B90")]
	private sealed class _003CStartScaling_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004A07")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004A08")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004A09")]
		[FieldOffset(Offset = "0x20")]
		public LerpScale _003C_003E4__this;

		[Token(Token = "0x4004A0A")]
		[FieldOffset(Offset = "0x28")]
		public float endValue;

		[Token(Token = "0x4004A0B")]
		[FieldOffset(Offset = "0x2C")]
		public float duration;

		[Token(Token = "0x4004A0C")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x4004A0D")]
		[FieldOffset(Offset = "0x34")]
		private float _003CstartValue_003E5__3;

		[Token(Token = "0x4004A0E")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _003CstartScale_003E5__4;

		[Token(Token = "0x17000689")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003FEF")]
			[Address(RVA = "0x17D0B90", Offset = "0x17D0B90", VA = "0x17D0B90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700068A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003FF1")]
			[Address(RVA = "0x17D0BD8", Offset = "0x17D0BD8", VA = "0x17D0BD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003FEC")]
		[Address(RVA = "0x17D09E4", Offset = "0x17D09E4", VA = "0x17D09E4")]
		[DebuggerHidden]
		public _003CStartScaling_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003FED")]
		[Address(RVA = "0x17D0A10", Offset = "0x17D0A10", VA = "0x17D0A10", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003FEE")]
		[Address(RVA = "0x17D0A14", Offset = "0x17D0A14", VA = "0x17D0A14", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003FEF")]
		[Address(RVA = "0x17D0B90", Offset = "0x17D0B90", VA = "0x17D0B90", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003FF0")]
		[Address(RVA = "0x17D0B98", Offset = "0x17D0B98", VA = "0x17D0B98", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003FF1")]
		[Address(RVA = "0x17D0BD8", Offset = "0x17D0BD8", VA = "0x17D0BD8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40049FF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject objectToScale;

	[Token(Token = "0x4004A00")]
	[FieldOffset(Offset = "0x20")]
	public float scaleMultiplier;

	[Token(Token = "0x4004A01")]
	[FieldOffset(Offset = "0x24")]
	private float timeToLerp;

	[Token(Token = "0x4004A02")]
	[FieldOffset(Offset = "0x28")]
	private float scaleModifier;

	[Token(Token = "0x4004A03")]
	[FieldOffset(Offset = "0x2C")]
	public float scaleSpeed;

	[Token(Token = "0x4004A04")]
	[FieldOffset(Offset = "0x30")]
	public bool startOnAwake;

	[Token(Token = "0x4004A05")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4004A06")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent OnScaled;

	[Token(Token = "0x6003FE8")]
	[Address(RVA = "0x1522EC0", Offset = "0x1522EC0", VA = "0x1522EC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003FE9")]
	[Address(RVA = "0x1522F6C", Offset = "0x1522F6C", VA = "0x1522F6C")]
	public void Scale()
	{
	}

	[Token(Token = "0x6003FEA")]
	[Address(RVA = "0x1522FF8", Offset = "0x1522FF8", VA = "0x1522FF8")]
	private IEnumerator StartScaling(float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6003FEB")]
	[Address(RVA = "0x1523080", Offset = "0x1523080", VA = "0x1523080")]
	public LerpScale()
	{
	}
}
