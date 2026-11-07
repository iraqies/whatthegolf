using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200068B")]
public class SingleObjectWave : FrogKingBaseWave
{
	[Token(Token = "0x200068C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E80", Offset = "0x40E80")]
	private sealed class _003CWaveRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x20")]
		public SingleObjectWave _003C_003E4__this;

		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x28")]
		public SHMUPFrogKing frogKing;

		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _003Cgo_003E5__2;

		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x38")]
		private float _003Ctimer_003E5__3;

		[Token(Token = "0x1700035F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DFA")]
			[Address(RVA = "0x1850990", Offset = "0x1850990", VA = "0x1850990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000360")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DFC")]
			[Address(RVA = "0x18509D8", Offset = "0x18509D8", VA = "0x18509D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x18505BC", Offset = "0x18505BC", VA = "0x18505BC")]
		[DebuggerHidden]
		public _003CWaveRoutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x18505E8", Offset = "0x18505E8", VA = "0x18505E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x18505EC", Offset = "0x18505EC", VA = "0x18505EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0x1850990", Offset = "0x1850990", VA = "0x1850990", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x1850998", Offset = "0x1850998", VA = "0x1850998", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x18509D8", Offset = "0x18509D8", VA = "0x18509D8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200068D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E90", Offset = "0x40E90")]
	private sealed class _003CFollowBoss_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400220F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002210")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002211")]
		[FieldOffset(Offset = "0x20")]
		public Transform trans;

		[Token(Token = "0x4002212")]
		[FieldOffset(Offset = "0x28")]
		public Transform frogKing;

		[Token(Token = "0x4002213")]
		[FieldOffset(Offset = "0x30")]
		public SingleObjectWave _003C_003E4__this;

		[Token(Token = "0x4002214")]
		[FieldOffset(Offset = "0x38")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x4002215")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 _003Coffset_003E5__3;

		[Token(Token = "0x17000361")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E00")]
			[Address(RVA = "0x185056C", Offset = "0x185056C", VA = "0x185056C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000362")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E02")]
			[Address(RVA = "0x18505B4", Offset = "0x18505B4", VA = "0x18505B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x185042C", Offset = "0x185042C", VA = "0x185042C")]
		[DebuggerHidden]
		public _003CFollowBoss_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x1850458", Offset = "0x1850458", VA = "0x1850458", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x185045C", Offset = "0x185045C", VA = "0x185045C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x185056C", Offset = "0x185056C", VA = "0x185056C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x1850574", Offset = "0x1850574", VA = "0x1850574", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x18505B4", Offset = "0x18505B4", VA = "0x18505B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002200")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> ObjectPrefab;

	[Token(Token = "0x4002201")]
	[FieldOffset(Offset = "0x50")]
	public Vector2 SpawnRangeX;

	[Token(Token = "0x4002202")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 ScaleMod;

	[Token(Token = "0x4002203")]
	[FieldOffset(Offset = "0x60")]
	public float WaveDuration;

	[Token(Token = "0x4002204")]
	[FieldOffset(Offset = "0x64")]
	public float zOffset;

	[Token(Token = "0x4002205")]
	[FieldOffset(Offset = "0x68")]
	public SHMUPController PlayerBoat;

	[Token(Token = "0x4002206")]
	[FieldOffset(Offset = "0x70")]
	public bool StopWaveOncePlyerHasPassed;

	[Token(Token = "0x4002207")]
	[FieldOffset(Offset = "0x74")]
	public float FollowBossTime;

	[Token(Token = "0x4002208")]
	[FieldOffset(Offset = "0x78")]
	private List<GameObject> currentObjects;

	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x16B301C", Offset = "0x16B301C", VA = "0x16B301C", Slot = "4")]
	public override IEnumerator WaveRoutine(SHMUPFrogKing frogKing)
	{
		return null;
	}

	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x16B3094", Offset = "0x16B3094", VA = "0x16B3094")]
	private IEnumerator FollowBoss(Transform trans, Transform frogKing)
	{
		return null;
	}

	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x16B311C", Offset = "0x16B311C", VA = "0x16B311C", Slot = "5")]
	public override void OnSinkReset()
	{
	}

	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0x16B32D4", Offset = "0x16B32D4", VA = "0x16B32D4")]
	public SingleObjectWave()
	{
	}
}
