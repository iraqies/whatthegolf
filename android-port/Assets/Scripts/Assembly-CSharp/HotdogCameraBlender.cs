using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20002FB")]
public class HotdogCameraBlender : GolfBehaviour
{
	[Token(Token = "0x20002FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EDDC", Offset = "0x3EDDC")]
	private sealed class _003CShowHoleRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001088")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001089")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400108A")]
		[FieldOffset(Offset = "0x20")]
		public HotdogCameraBlender _003C_003E4__this;

		[Token(Token = "0x170001A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000DCD")]
			[Address(RVA = "0x17BFAD4", Offset = "0x17BFAD4", VA = "0x17BFAD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x17BFB1C", Offset = "0x17BFB1C", VA = "0x17BFB1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x17BF900", Offset = "0x17BF900", VA = "0x17BF900")]
		[DebuggerHidden]
		public _003CShowHoleRoutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x17BF92C", Offset = "0x17BF92C", VA = "0x17BF92C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x17BF930", Offset = "0x17BF930", VA = "0x17BF930", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x17BFAD4", Offset = "0x17BFAD4", VA = "0x17BFAD4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x17BFADC", Offset = "0x17BFADC", VA = "0x17BFADC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x17BFB1C", Offset = "0x17BFB1C", VA = "0x17BFB1C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x20")]
	public OverworldCameraSettings CameraSettings;

	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x28")]
	public List<SpriteRenderer> backgroundRenderers;

	[Token(Token = "0x400107B")]
	[FieldOffset(Offset = "0x30")]
	public Color baseBackground;

	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x40")]
	public Color endBackground;

	[Token(Token = "0x400107D")]
	[FieldOffset(Offset = "0x50")]
	public Transform center;

	[Token(Token = "0x400107E")]
	[FieldOffset(Offset = "0x58")]
	private Coroutine current;

	[Token(Token = "0x400107F")]
	[FieldOffset(Offset = "0x60")]
	private float lastPct;

	[Token(Token = "0x4001080")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private OverworldButton2D door;

	[Token(Token = "0x4001081")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Animator animationController;

	[Token(Token = "0x4001082")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x4001083")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private float zoomOut;

	[Token(Token = "0x4001084")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float duration;

	[Token(Token = "0x4001085")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UnityEvent AllGoalsAreDoneFromStart;

	[Token(Token = "0x4001086")]
	[FieldOffset(Offset = "0x90")]
	private Coroutine holeRoutine;

	[Token(Token = "0x4001087")]
	[FieldOffset(Offset = "0x98")]
	private bool hasShownHoleRoutine;

	[Token(Token = "0x6000DC3")]
	[Address(RVA = "0x14DA2D0", Offset = "0x14DA2D0", VA = "0x14DA2D0")]
	private bool checkIfDone()
	{
		return default;
	}

	[Token(Token = "0x6000DC4")]
	[Address(RVA = "0x14DA38C", Offset = "0x14DA38C", VA = "0x14DA38C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x14DA498", Offset = "0x14DA498", VA = "0x14DA498")]
	private void OnDoorOpen()
	{
	}

	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x14DA440", Offset = "0x14DA440", VA = "0x14DA440")]
	private void ShowHoleInstant()
	{
	}

	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x14DA58C", Offset = "0x14DA58C", VA = "0x14DA58C")]
	private IEnumerator ShowHoleRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x14DA600", Offset = "0x14DA600", VA = "0x14DA600")]
	private void InterruptRoutine(bool show)
	{
	}

	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x14DA6D4", Offset = "0x14DA6D4", VA = "0x14DA6D4")]
	public HotdogCameraBlender()
	{
	}
}
