using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000235")]
public class AnimationActions : MonoBehaviour
{
	[Token(Token = "0x2000236")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E604", Offset = "0x3E604")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody rigid;

		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x28")]
		public Transform match;

		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion startRot;

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x176C420", Offset = "0x176C420", VA = "0x176C420")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x176C428", Offset = "0x176C428", VA = "0x176C428")]
		internal void _003CActivateCarRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000237")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E614", Offset = "0x3E614")]
	private sealed class _003CActivateCarRoutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000B5A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000B5B")]
		[FieldOffset(Offset = "0x20")]
		public AnimationActions _003C_003E4__this;

		[Token(Token = "0x17000137")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x176C91C", Offset = "0x176C91C", VA = "0x176C91C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000138")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x176C964", Offset = "0x176C964", VA = "0x176C964", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x176C5D0", Offset = "0x176C5D0", VA = "0x176C5D0")]
		[DebuggerHidden]
		public _003CActivateCarRoutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x176C5FC", Offset = "0x176C5FC", VA = "0x176C5FC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x176C600", Offset = "0x176C600", VA = "0x176C600", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x176C91C", Offset = "0x176C91C", VA = "0x176C91C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x176C924", Offset = "0x176C924", VA = "0x176C924", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x176C964", Offset = "0x176C964", VA = "0x176C964", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000238")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E624", Offset = "0x3E624")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4000B5C")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody bone;

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x176C578", Offset = "0x176C578", VA = "0x176C578")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x176C580", Offset = "0x176C580", VA = "0x176C580")]
		internal bool _003CFindMatchingBone_003Eb__0(Transform r)
		{
			return default;
		}
	}

	[Token(Token = "0x4000B4B")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x4000B4C")]
	[FieldOffset(Offset = "0x20")]
	public Animator CameraController;

	[Token(Token = "0x4000B4D")]
	[FieldOffset(Offset = "0x28")]
	public Transform RagdollRigRoot;

	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x30")]
	public Transform RagdollRig;

	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x38")]
	public Transform VikeOnCarRig;

	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Car;

	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x48")]
	public GameObject FakeCar;

	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x50")]
	public ClipSettingsCollection BangClips;

	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection LiquidClips;

	[Token(Token = "0x4000B54")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection EngineStartClips;

	[Token(Token = "0x60009EA")]
	[Address(RVA = "0x1417D58", Offset = "0x1417D58", VA = "0x1417D58")]
	public void PlayBang()
	{
	}

	[Token(Token = "0x60009EB")]
	[Address(RVA = "0x1417DA0", Offset = "0x1417DA0", VA = "0x1417DA0")]
	public void PlayLiquidSound()
	{
	}

	[Token(Token = "0x60009EC")]
	[Address(RVA = "0x1417DE8", Offset = "0x1417DE8", VA = "0x1417DE8")]
	public void PlayEngineStart()
	{
	}

	[Token(Token = "0x60009ED")]
	[Address(RVA = "0x1417E30", Offset = "0x1417E30", VA = "0x1417E30")]
	public void ActivateCar()
	{
	}

	[Token(Token = "0x60009EE")]
	[Address(RVA = "0x1417EAC", Offset = "0x1417EAC", VA = "0x1417EAC")]
	private IEnumerator ActivateCarRoutine()
	{
		return null;
	}

	[Token(Token = "0x60009EF")]
	[Address(RVA = "0x1417F20", Offset = "0x1417F20", VA = "0x1417F20")]
	private Transform FindMatchingBone(Rigidbody bone, Transform otherRig)
	{
		return null;
	}

	[Token(Token = "0x60009F0")]
	[Address(RVA = "0x1418038", Offset = "0x1418038", VA = "0x1418038")]
	public AnimationActions()
	{
	}
}
