using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000648")]
public class BossStageController : MonoBehaviour
{
	[Token(Token = "0x2000649")]
	public enum StageToPlayEnum
	{
		[Token(Token = "0x4002091")]
		All = 0,
		[Token(Token = "0x4002092")]
		ChaseStage = 1,
		[Token(Token = "0x4002093")]
		BoatStage = 2,
		[Token(Token = "0x4002094")]
		BoatStageWithoutIntro = 3,
		[Token(Token = "0x4002095")]
		InsideFrogStage = 4,
		[Token(Token = "0x4002096")]
		FinalStage = 5
	}

	[Token(Token = "0x200064A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40BC0", Offset = "0x40BC0")]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002097")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002098")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002099")]
		[FieldOffset(Offset = "0x20")]
		public BossStageController _003C_003E4__this;

		[Token(Token = "0x1700032B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x177A330", Offset = "0x177A330", VA = "0x177A330", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700032C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001CBB")]
			[Address(RVA = "0x177A378", Offset = "0x177A378", VA = "0x177A378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x1779D58", Offset = "0x1779D58", VA = "0x1779D58")]
		[DebuggerHidden]
		public _003CStart_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x1779D84", Offset = "0x1779D84", VA = "0x1779D84", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x1779D88", Offset = "0x1779D88", VA = "0x1779D88", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x177A330", Offset = "0x177A330", VA = "0x177A330", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x177A338", Offset = "0x177A338", VA = "0x177A338", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x177A378", Offset = "0x177A378", VA = "0x177A378", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400208B")]
	[FieldOffset(Offset = "0x18")]
	public FinalBoss FirstStage;

	[Token(Token = "0x400208C")]
	[FieldOffset(Offset = "0x20")]
	public BossSHMUP SecondStage;

	[Token(Token = "0x400208D")]
	[FieldOffset(Offset = "0x28")]
	public BossFrogKingInside ThirdStage;

	[Token(Token = "0x400208E")]
	[FieldOffset(Offset = "0x30")]
	public FrogKingLastStage FourthStage;

	[Token(Token = "0x400208F")]
	[FieldOffset(Offset = "0x38")]
	public StageToPlayEnum StageToPlay;

	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x1700A34", Offset = "0x1700A34", VA = "0x1700A34")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x1700AA8", Offset = "0x1700AA8", VA = "0x1700AA8")]
	public BossStageController()
	{
	}
}
