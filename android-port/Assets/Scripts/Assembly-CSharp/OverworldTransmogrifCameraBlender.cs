using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200099A")]
public class OverworldTransmogrifCameraBlender : GolfBehaviour
{
	[Token(Token = "0x200099B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42598", Offset = "0x42598")]
	private sealed class _003CDoCameraBlend_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40034E7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40034E8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40034E9")]
		[FieldOffset(Offset = "0x20")]
		public OverworldTransmogrifCameraBlender _003C_003E4__this;

		[Token(Token = "0x40034EA")]
		[FieldOffset(Offset = "0x28")]
		private float _003Ctotal_003E5__2;

		[Token(Token = "0x40034EB")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CinTime_003E5__3;

		[Token(Token = "0x40034EC")]
		[FieldOffset(Offset = "0x30")]
		private float _003CzoomTime_003E5__4;

		[Token(Token = "0x40034ED")]
		[FieldOffset(Offset = "0x34")]
		private float _003CoutTime_003E5__5;

		[Token(Token = "0x170004AC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002D1C")]
			[Address(RVA = "0x181E548", Offset = "0x181E548", VA = "0x181E548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004AD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D1E")]
			[Address(RVA = "0x181E590", Offset = "0x181E590", VA = "0x181E590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x181E27C", Offset = "0x181E27C", VA = "0x181E27C")]
		[DebuggerHidden]
		public _003CDoCameraBlend_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0x181E2A8", Offset = "0x181E2A8", VA = "0x181E2A8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x181E2AC", Offset = "0x181E2AC", VA = "0x181E2AC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x181E548", Offset = "0x181E548", VA = "0x181E548", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x181E550", Offset = "0x181E550", VA = "0x181E550", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x181E590", Offset = "0x181E590", VA = "0x181E590", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40034E3")]
	[FieldOffset(Offset = "0x20")]
	public OverworldCameraSettings inTrans;

	[Token(Token = "0x40034E4")]
	[FieldOffset(Offset = "0x28")]
	public OverworldCameraSettings inTransZoomed;

	[Token(Token = "0x40034E5")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine current;

	[Token(Token = "0x40034E6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private OverworldCamera overworldCamera;

	[Token(Token = "0x6002D11")]
	[Address(RVA = "0x15CE14C", Offset = "0x15CE14C", VA = "0x15CE14C", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002D12")]
	[Address(RVA = "0x15CE1DC", Offset = "0x15CE1DC", VA = "0x15CE1DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D13")]
	[Address(RVA = "0x15CE294", Offset = "0x15CE294", VA = "0x15CE294")]
	private void Instance_OnTransmoGriffed1(Transmogrif grif)
	{
	}

	[Token(Token = "0x6002D14")]
	[Address(RVA = "0x15CE33C", Offset = "0x15CE33C", VA = "0x15CE33C")]
	private IEnumerator DoCameraBlend()
	{
		return null;
	}

	[Token(Token = "0x6002D15")]
	[Address(RVA = "0x15CE3B0", Offset = "0x15CE3B0", VA = "0x15CE3B0")]
	public OverworldTransmogrifCameraBlender()
	{
	}

	[Token(Token = "0x6002D16")]
	[Address(RVA = "0x15CE3B8", Offset = "0x15CE3B8", VA = "0x15CE3B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683C4", Offset = "0x683C4")]
	private void _003CDoCameraBlend_003Eb__7_0(float t)
	{
	}

	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x15CE3EC", Offset = "0x15CE3EC", VA = "0x15CE3EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683D4", Offset = "0x683D4")]
	private void _003CDoCameraBlend_003Eb__7_1(float t)
	{
	}

	[Token(Token = "0x6002D18")]
	[Address(RVA = "0x15CE420", Offset = "0x15CE420", VA = "0x15CE420")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x683E4", Offset = "0x683E4")]
	private void _003CDoCameraBlend_003Eb__7_2(float t)
	{
	}
}
