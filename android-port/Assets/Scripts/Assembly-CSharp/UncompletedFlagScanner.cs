using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AD9")]
public class UncompletedFlagScanner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000ADA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43348", Offset = "0x43348")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003C8C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003C8D")]
		[FieldOffset(Offset = "0x8")]
		public static Func<OverworldGoal, bool> _003C_003E9__11_0;

		[Token(Token = "0x4003C8E")]
		[FieldOffset(Offset = "0x10")]
		public static Func<OverworldGoal, bool> _003C_003E9__11_1;

		[Token(Token = "0x4003C8F")]
		[FieldOffset(Offset = "0x18")]
		public static Func<OverworldGoal, bool> _003C_003E9__11_2;

		[Token(Token = "0x60033DC")]
		[Address(RVA = "0x1871688", Offset = "0x1871688", VA = "0x1871688")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60033DD")]
		[Address(RVA = "0x1871690", Offset = "0x1871690", VA = "0x1871690")]
		internal bool _003CMoveCameraRoutine_003Eb__11_0(OverworldGoal g)
		{
			return default;
		}

		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x18716F0", Offset = "0x18716F0", VA = "0x18716F0")]
		internal bool _003CMoveCameraRoutine_003Eb__11_1(OverworldGoal g)
		{
			return default;
		}

		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x1871750", Offset = "0x1871750", VA = "0x1871750")]
		internal bool _003CMoveCameraRoutine_003Eb__11_2(OverworldGoal g)
		{
			return default;
		}
	}

	[Token(Token = "0x2000ADB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43358", Offset = "0x43358")]
	private sealed class _003CMoveCameraRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003C90")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003C91")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003C92")]
		[FieldOffset(Offset = "0x20")]
		public UncompletedFlagScanner _003C_003E4__this;

		[Token(Token = "0x4003C93")]
		[FieldOffset(Offset = "0x28")]
		public OverworldBall2D ball;

		[Token(Token = "0x4003C94")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 collisionPoint;

		[Token(Token = "0x4003C95")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _003ColdPos_003E5__2;

		[Token(Token = "0x4003C96")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 _003CgoalPos_003E5__3;

		[Token(Token = "0x4003C97")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _003CballOffset_003E5__4;

		[Token(Token = "0x4003C98")]
		[FieldOffset(Offset = "0x60")]
		private float _003CstartSize_003E5__5;

		[Token(Token = "0x4003C99")]
		[FieldOffset(Offset = "0x68")]
		private FlagScannerEffect _003Ceffect_003E5__6;

		[Token(Token = "0x4003C9A")]
		[FieldOffset(Offset = "0x70")]
		private float _003Ctimer_003E5__7;

		[Token(Token = "0x4003C9B")]
		[FieldOffset(Offset = "0x74")]
		private int _003CtestIndex_003E5__8;

		[Token(Token = "0x1700055A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60033E3")]
			[Address(RVA = "0x1872128", Offset = "0x1872128", VA = "0x1872128", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700055B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60033E5")]
			[Address(RVA = "0x1872170", Offset = "0x1872170", VA = "0x1872170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x18717B0", Offset = "0x18717B0", VA = "0x18717B0")]
		[DebuggerHidden]
		public _003CMoveCameraRoutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60033E1")]
		[Address(RVA = "0x18717DC", Offset = "0x18717DC", VA = "0x18717DC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60033E2")]
		[Address(RVA = "0x18717E0", Offset = "0x18717E0", VA = "0x18717E0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60033E3")]
		[Address(RVA = "0x1872128", Offset = "0x1872128", VA = "0x1872128", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60033E4")]
		[Address(RVA = "0x1872130", Offset = "0x1872130", VA = "0x1872130", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60033E5")]
		[Address(RVA = "0x1872170", Offset = "0x1872170", VA = "0x1872170", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003C83")]
	[FieldOffset(Offset = "0x18")]
	public float StayDuration;

	[Token(Token = "0x4003C84")]
	[FieldOffset(Offset = "0x1C")]
	public float ZoomedSize;

	[Token(Token = "0x4003C85")]
	[FieldOffset(Offset = "0x20")]
	public float PushAwayDistance;

	[Token(Token = "0x4003C86")]
	[FieldOffset(Offset = "0x24")]
	public float MoveMod;

	[Token(Token = "0x4003C87")]
	[FieldOffset(Offset = "0x28")]
	public Material ScannerEffect;

	[Token(Token = "0x4003C88")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection FoundFlagClip;

	[Token(Token = "0x4003C89")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection NoFlagsLeftClip;

	[Token(Token = "0x4003C8A")]
	[FieldOffset(Offset = "0x40")]
	private List<OverworldGoal> allGoals;

	[Token(Token = "0x4003C8B")]
	[FieldOffset(Offset = "0x48")]
	private bool routineRunning;

	[Token(Token = "0x60033D7")]
	[Address(RVA = "0x173A8E8", Offset = "0x173A8E8", VA = "0x173A8E8")]
	public void Init(List<OverworldGoal> goals)
	{
	}

	[Token(Token = "0x60033D8")]
	[Address(RVA = "0x173A8F0", Offset = "0x173A8F0", VA = "0x173A8F0")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x60033D9")]
	[Address(RVA = "0x173AA98", Offset = "0x173AA98", VA = "0x173AA98")]
	private IEnumerator MoveCameraRoutine(OverworldBall2D ball, Vector3 collisionPoint)
	{
		return null;
	}

	[Token(Token = "0x60033DA")]
	[Address(RVA = "0x173AB34", Offset = "0x173AB34", VA = "0x173AB34")]
	public UncompletedFlagScanner()
	{
	}
}
