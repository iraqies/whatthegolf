using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000995")]
public class OverworldCableCameraBlender : GolfBehaviour
{
	[Token(Token = "0x2000996")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42588", Offset = "0x42588")]
	private sealed class _003CEndCamera_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40034D2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40034D4")]
		[FieldOffset(Offset = "0x20")]
		public OverworldCableCameraBlender _003C_003E4__this;

		[Token(Token = "0x170004AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002CF6")]
			[Address(RVA = "0x180EC5C", Offset = "0x180EC5C", VA = "0x180EC5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002CF8")]
			[Address(RVA = "0x180ECA4", Offset = "0x180ECA4", VA = "0x180ECA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x180EB3C", Offset = "0x180EB3C", VA = "0x180EB3C")]
		[DebuggerHidden]
		public _003CEndCamera_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x180EB68", Offset = "0x180EB68", VA = "0x180EB68", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x180EB6C", Offset = "0x180EB6C", VA = "0x180EB6C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x180EC5C", Offset = "0x180EC5C", VA = "0x180EC5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x180EC64", Offset = "0x180EC64", VA = "0x180EC64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x180ECA4", Offset = "0x180ECA4", VA = "0x180ECA4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40034CF")]
	[FieldOffset(Offset = "0x20")]
	public OverworldCameraSettings inCable;

	[Token(Token = "0x40034D0")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine current;

	[Token(Token = "0x40034D1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<OverworldMainButton> cables;

	[Token(Token = "0x6002CEB")]
	[Address(RVA = "0x15ADE8C", Offset = "0x15ADE8C", VA = "0x15ADE8C", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002CEC")]
	[Address(RVA = "0x15ADF38", Offset = "0x15ADF38", VA = "0x15ADF38")]
	private void Start()
	{
	}

	[Token(Token = "0x6002CED")]
	[Address(RVA = "0x15AE21C", Offset = "0x15AE21C", VA = "0x15AE21C")]
	private void Cable_OnEnteredCable1(OverworldMainButton cable)
	{
	}

	[Token(Token = "0x6002CEE")]
	[Address(RVA = "0x15AE3C8", Offset = "0x15AE3C8", VA = "0x15AE3C8")]
	private void Cable_OnExitedCable(OverworldMainDoorRobot cable)
	{
	}

	[Token(Token = "0x6002CEF")]
	[Address(RVA = "0x15AE4EC", Offset = "0x15AE4EC", VA = "0x15AE4EC")]
	private IEnumerator EndCamera()
	{
		return null;
	}

	[Token(Token = "0x6002CF0")]
	[Address(RVA = "0x15AE560", Offset = "0x15AE560", VA = "0x15AE560")]
	public OverworldCableCameraBlender()
	{
	}

	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x15AE568", Offset = "0x15AE568", VA = "0x15AE568")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682B4", Offset = "0x682B4")]
	private void _003CCable_OnEnteredCable1_003Eb__5_0(float t)
	{
	}

	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x15AE660", Offset = "0x15AE660", VA = "0x15AE660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x682C4", Offset = "0x682C4")]
	private void _003CEndCamera_003Eb__7_0(float t)
	{
	}
}
