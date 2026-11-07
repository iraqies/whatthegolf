using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EA4")]
public class ScaleOnAim : BaseDailyPrizeInteractions
{
	[Token(Token = "0x2000EA5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45198", Offset = "0x45198")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4004F23")]
		[FieldOffset(Offset = "0x10")]
		public ScaleOnAim _003C_003E4__this;

		[Token(Token = "0x4004F24")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 currentScale;

		[Token(Token = "0x6004464")]
		[Address(RVA = "0x183E3D0", Offset = "0x183E3D0", VA = "0x183E3D0")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6004465")]
		[Address(RVA = "0x183E3D8", Offset = "0x183E3D8", VA = "0x183E3D8")]
		internal void _003COnShoot_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6004466")]
		[Address(RVA = "0x183E494", Offset = "0x183E494", VA = "0x183E494")]
		internal void _003COnShoot_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000EA6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x451A8", Offset = "0x451A8")]
	private sealed class _003COnShoot_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F25")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F26")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F27")]
		[FieldOffset(Offset = "0x20")]
		public ScaleOnAim _003C_003E4__this;

		[Token(Token = "0x4004F28")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		[Token(Token = "0x17000706")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600446A")]
			[Address(RVA = "0x183E80C", Offset = "0x183E80C", VA = "0x183E80C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000707")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600446C")]
			[Address(RVA = "0x183E854", Offset = "0x183E854", VA = "0x183E854", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004467")]
		[Address(RVA = "0x183E54C", Offset = "0x183E54C", VA = "0x183E54C")]
		[DebuggerHidden]
		public _003COnShoot_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004468")]
		[Address(RVA = "0x183E578", Offset = "0x183E578", VA = "0x183E578", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004469")]
		[Address(RVA = "0x183E57C", Offset = "0x183E57C", VA = "0x183E57C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600446A")]
		[Address(RVA = "0x183E80C", Offset = "0x183E80C", VA = "0x183E80C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600446B")]
		[Address(RVA = "0x183E814", Offset = "0x183E814", VA = "0x183E814", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600446C")]
		[Address(RVA = "0x183E854", Offset = "0x183E854", VA = "0x183E854", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004F1A")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve OnAimCurve;

	[Token(Token = "0x4004F1B")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve OnShootCurve;

	[Token(Token = "0x4004F1C")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 TargetScaleOnAim;

	[Token(Token = "0x4004F1D")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 TargetScaleOnShoot;

	[Token(Token = "0x4004F1E")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 orginalScale;

	[Token(Token = "0x4004F1F")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Target;

	[Token(Token = "0x4004F20")]
	[FieldOffset(Offset = "0x68")]
	public float shootTime;

	[Token(Token = "0x4004F21")]
	[FieldOffset(Offset = "0x6C")]
	public float controllerCooldown;

	[Token(Token = "0x4004F22")]
	[FieldOffset(Offset = "0x70")]
	private bool controllerCanShoot;

	[Token(Token = "0x600445F")]
	[Address(RVA = "0x167A568", Offset = "0x167A568", VA = "0x167A568")]
	private void Start()
	{
	}

	[Token(Token = "0x6004460")]
	[Address(RVA = "0x167A5AC", Offset = "0x167A5AC", VA = "0x167A5AC", Slot = "8")]
	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004461")]
	[Address(RVA = "0x167A6FC", Offset = "0x167A6FC", VA = "0x167A6FC", Slot = "6")]
	public override void OnAimNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x6004462")]
	[Address(RVA = "0x167A688", Offset = "0x167A688", VA = "0x167A688")]
	private IEnumerator OnShoot()
	{
		return null;
	}

	[Token(Token = "0x6004463")]
	[Address(RVA = "0x167A86C", Offset = "0x167A86C", VA = "0x167A86C")]
	public ScaleOnAim()
	{
	}
}
