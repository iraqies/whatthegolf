using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200021C")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E4A0", Offset = "0x3E4A0")]
public class CinemachineCameraShake : MonoBehaviour
{
	[Token(Token = "0x200021D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E508", Offset = "0x3E508")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x10")]
		public CinemachineCameraShake _003C_003E4__this;

		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x18")]
		public float amplitudeGain;

		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x1C")]
		public float frequencyGain;

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1786C84", Offset = "0x1786C84", VA = "0x1786C84")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1786C8C", Offset = "0x1786C8C", VA = "0x1786C8C")]
		internal void _003CShakeRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200021E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E518", Offset = "0x3E518")]
	private sealed class _003CShakeRoutine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x20")]
		public CinemachineCameraShake _003C_003E4__this;

		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x28")]
		public float amplitudeGain;

		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x2C")]
		public float frequencyGain;

		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x17000127")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1786E98", Offset = "0x1786E98", VA = "0x1786E98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000128")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x1786EE0", Offset = "0x1786EE0", VA = "0x1786EE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1786D08", Offset = "0x1786D08", VA = "0x1786D08")]
		[DebuggerHidden]
		public _003CShakeRoutine_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1786D34", Offset = "0x1786D34", VA = "0x1786D34", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1786D38", Offset = "0x1786D38", VA = "0x1786D38", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x1786E98", Offset = "0x1786E98", VA = "0x1786E98", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1786EA0", Offset = "0x1786EA0", VA = "0x1786EA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1786EE0", Offset = "0x1786EE0", VA = "0x1786EE0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x18")]
	private CinemachineBasicMultiChannelPerlin noise;

	[Token(Token = "0x600096A")]
	[Address(RVA = "0x189D7CC", Offset = "0x189D7CC", VA = "0x189D7CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600096B")]
	[Address(RVA = "0x189D84C", Offset = "0x189D84C", VA = "0x189D84C")]
	public void Shake(float amplitudeGain, float frequencyGain, float duration)
	{
	}

	[Token(Token = "0x600096C")]
	[Address(RVA = "0x189D8EC", Offset = "0x189D8EC", VA = "0x189D8EC")]
	private IEnumerator ShakeRoutine(float amplitudeGain, float frequencyGain, float duration)
	{
		return null;
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0x189D984", Offset = "0x189D984", VA = "0x189D984")]
	public CinemachineCameraShake()
	{
	}
}
