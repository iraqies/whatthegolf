using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000976")]
public class OverworldCable : MonoBehaviour
{
	[Token(Token = "0x2000977")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42410", Offset = "0x42410")]
	private sealed class _003CSetEnableColorRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40033F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40033F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40033F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool instant;

		[Token(Token = "0x40033F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverworldCable _003C_003E4__this;

		[Token(Token = "0x40033F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<Vector3> OnMove;

		[Token(Token = "0x40033F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _003CtotalDist_003E5__2;

		[Token(Token = "0x40033F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _003CcurrentDist_003E5__3;

		[Token(Token = "0x40033FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x40033FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _003Cstart_003E5__5;

		[Token(Token = "0x40033FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 _003Cend_003E5__6;

		[Token(Token = "0x40033FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 _003Cdir_003E5__7;

		[Token(Token = "0x40033FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _003Clength_003E5__8;

		[Token(Token = "0x40033FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _003Cd_003E5__9;

		[Token(Token = "0x17000499")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002C2E")]
			[Address(RVA = "0x180EAEC", Offset = "0x180EAEC", VA = "0x180EAEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700049A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002C30")]
			[Address(RVA = "0x180EB34", Offset = "0x180EB34", VA = "0x180EB34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002C2B")]
		[Address(RVA = "0x180E520", Offset = "0x180E520", VA = "0x180E520")]
		[DebuggerHidden]
		public _003CSetEnableColorRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002C2C")]
		[Address(RVA = "0x180E54C", Offset = "0x180E54C", VA = "0x180E54C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002C2D")]
		[Address(RVA = "0x180E550", Offset = "0x180E550", VA = "0x180E550", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002C2E")]
		[Address(RVA = "0x180EAEC", Offset = "0x180EAEC", VA = "0x180EAEC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002C2F")]
		[Address(RVA = "0x180EAF4", Offset = "0x180EAF4", VA = "0x180EAF4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002C30")]
		[Address(RVA = "0x180EB34", Offset = "0x180EB34", VA = "0x180EB34", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40033E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LineRenderer line;

	[Token(Token = "0x40033E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LineRenderer lineFill;

	[Token(Token = "0x40033E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material OffMaterial;

	[Token(Token = "0x40033EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material OnMaterial;

	[Token(Token = "0x40033EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float Speed;

	[Token(Token = "0x40033EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float LineOnMoveSpeed;

	[Token(Token = "0x40033ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ParticleSystem Particles;

	[Token(Token = "0x40033EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Action<float> OnMoveNormalized;

	[Token(Token = "0x40033EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool isOn;

	[Token(Token = "0x40033F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float offsetTimer;

	[Token(Token = "0x40033F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float offsetStartDamper;

	[Token(Token = "0x40033F2")]
	private const float zOffset = -0.1f;

	[Token(Token = "0x6002C26")]
	[Address(RVA = "0x15ADC38", Offset = "0x15ADC38", VA = "0x15ADC38")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C27")]
	[Address(RVA = "0x15ADCCC", Offset = "0x15ADCCC", VA = "0x15ADCCC")]
	public void Toggle(bool state)
	{
	}

	[Token(Token = "0x6002C28")]
	[Address(RVA = "0x15ADD4C", Offset = "0x15ADD4C", VA = "0x15ADD4C")]
	public IEnumerator SetEnableColorRoutine([Optional] Action<Vector3> OnMove, bool instant = false)
	{
		return null;
	}

	[Token(Token = "0x6002C29")]
	[Address(RVA = "0x15ADDD4", Offset = "0x15ADDD4", VA = "0x15ADDD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C2A")]
	[Address(RVA = "0x15ADE74", Offset = "0x15ADE74", VA = "0x15ADE74")]
	public OverworldCable()
	{
	}
}
