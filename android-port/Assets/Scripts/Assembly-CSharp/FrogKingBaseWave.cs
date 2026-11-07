using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000684")]
public abstract class FrogKingBaseWave : MonoBehaviour
{
	[Token(Token = "0x2000685")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E30", Offset = "0x40E30")]
	private sealed class _003CFrogKingSpawnWaveRoutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021DB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021DC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021DD")]
		[FieldOffset(Offset = "0x20")]
		public FrogKingBaseWave _003C_003E4__this;

		[Token(Token = "0x17000357")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0x17A9F64", Offset = "0x17A9F64", VA = "0x17A9F64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000358")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x17A9FAC", Offset = "0x17A9FAC", VA = "0x17A9FAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DD3")]
		[Address(RVA = "0x17A9DCC", Offset = "0x17A9DCC", VA = "0x17A9DCC")]
		[DebuggerHidden]
		public _003CFrogKingSpawnWaveRoutine_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DD4")]
		[Address(RVA = "0x17A9DF8", Offset = "0x17A9DF8", VA = "0x17A9DF8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x17A9DFC", Offset = "0x17A9DFC", VA = "0x17A9DFC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x17A9F64", Offset = "0x17A9F64", VA = "0x17A9F64", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0x17A9F6C", Offset = "0x17A9F6C", VA = "0x17A9F6C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0x17A9FAC", Offset = "0x17A9FAC", VA = "0x17A9FAC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000686")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40E40", Offset = "0x40E40")]
	private sealed class _003CWaveAnimationsRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40021DE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40021DF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40021E0")]
		[FieldOffset(Offset = "0x20")]
		public FrogKingBaseWave _003C_003E4__this;

		[Token(Token = "0x17000359")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0x17AA10C", Offset = "0x17AA10C", VA = "0x17AA10C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700035A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0x17AA154", Offset = "0x17AA154", VA = "0x17AA154", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x17A9FB4", Offset = "0x17A9FB4", VA = "0x17A9FB4")]
		[DebuggerHidden]
		public _003CWaveAnimationsRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0x17A9FE0", Offset = "0x17A9FE0", VA = "0x17A9FE0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0x17A9FE4", Offset = "0x17A9FE4", VA = "0x17A9FE4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0x17AA10C", Offset = "0x17AA10C", VA = "0x17AA10C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x17AA114", Offset = "0x17AA114", VA = "0x17AA114", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x17AA154", Offset = "0x17AA154", VA = "0x17AA154", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40021D4")]
	[FieldOffset(Offset = "0x18")]
	public AudioEventAsset sfxOneshotOnSpawn;

	[Token(Token = "0x40021D5")]
	[FieldOffset(Offset = "0x20")]
	public float oneshotDelay;

	[Token(Token = "0x40021D6")]
	[FieldOffset(Offset = "0x28")]
	public Animator FrogKingAnimator;

	[Token(Token = "0x40021D7")]
	[FieldOffset(Offset = "0x30")]
	public float FrogKingSpawnAnimationTime;

	[Token(Token = "0x40021D8")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4E4DC", Offset = "0x4E4DC")]
	public float Weight;

	[Token(Token = "0x40021D9")]
	[FieldOffset(Offset = "0x38")]
	public string AnimatorStateName;

	[Token(Token = "0x40021DA")]
	[FieldOffset(Offset = "0x40")]
	public float TimeSpentInAnimation;

	[Token(Token = "0x6001DCD")]
	public abstract IEnumerator WaveRoutine(SHMUPFrogKing frogKing);

	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x1475474", Offset = "0x1475474", VA = "0x1475474", Slot = "5")]
	public virtual void OnSinkReset()
	{
	}

	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x14754C4", Offset = "0x14754C4", VA = "0x14754C4")]
	public IEnumerator FrogKingSpawnWaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001DD0")]
	[Address(RVA = "0x1475538", Offset = "0x1475538", VA = "0x1475538")]
	public IEnumerator WaveAnimationsRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001DD1")]
	[Address(RVA = "0x14755AC", Offset = "0x14755AC", VA = "0x14755AC")]
	public bool TryPlayOneshot(AudioEventAsset oneshot, Vector3 pos)
	{
		return default;
	}

	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0x14756B0", Offset = "0x14756B0", VA = "0x14756B0")]
	protected FrogKingBaseWave()
	{
	}
}
