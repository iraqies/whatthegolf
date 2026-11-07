using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006EF")]
public class FPGFlyingOuterLimit : MonoBehaviour
{
	[Token(Token = "0x20006F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x411D0", Offset = "0x411D0")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x10")]
		public float startDensity;

		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x18")]
		public FPGFlyingOuterLimit _003C_003E4__this;

		[Token(Token = "0x6002005")]
		[Address(RVA = "0x17A20E0", Offset = "0x17A20E0", VA = "0x17A20E0")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6002006")]
		[Address(RVA = "0x17A20E8", Offset = "0x17A20E8", VA = "0x17A20E8")]
		internal void _003CRepositioningRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002007")]
		[Address(RVA = "0x17A2134", Offset = "0x17A2134", VA = "0x17A2134")]
		internal void _003CRepositioningRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x20006F1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x411E0", Offset = "0x411E0")]
	private sealed class _003CRepositioningRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002469")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400246B")]
		[FieldOffset(Offset = "0x20")]
		public FPGFlyingOuterLimit _003C_003E4__this;

		[Token(Token = "0x400246C")]
		[FieldOffset(Offset = "0x28")]
		public Transform player;

		[Token(Token = "0x400246D")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x170003B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600200B")]
			[Address(RVA = "0x17A2440", Offset = "0x17A2440", VA = "0x17A2440", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600200D")]
			[Address(RVA = "0x17A2488", Offset = "0x17A2488", VA = "0x17A2488", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002008")]
		[Address(RVA = "0x17A2180", Offset = "0x17A2180", VA = "0x17A2180")]
		[DebuggerHidden]
		public _003CRepositioningRoutine_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002009")]
		[Address(RVA = "0x17A21AC", Offset = "0x17A21AC", VA = "0x17A21AC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600200A")]
		[Address(RVA = "0x17A21B0", Offset = "0x17A21B0", VA = "0x17A21B0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600200B")]
		[Address(RVA = "0x17A2440", Offset = "0x17A2440", VA = "0x17A2440", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600200C")]
		[Address(RVA = "0x17A2448", Offset = "0x17A2448", VA = "0x17A2448", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600200D")]
		[Address(RVA = "0x17A2488", Offset = "0x17A2488", VA = "0x17A2488", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002463")]
	[FieldOffset(Offset = "0x18")]
	public float FogCoverDensity;

	[Token(Token = "0x4002464")]
	[FieldOffset(Offset = "0x1C")]
	public float RepositionHeight;

	[Token(Token = "0x4002465")]
	[FieldOffset(Offset = "0x20")]
	public float LerpTime;

	[Token(Token = "0x4002466")]
	[FieldOffset(Offset = "0x24")]
	private bool routineRunning;

	[Token(Token = "0x6002002")]
	[Address(RVA = "0x1457C48", Offset = "0x1457C48", VA = "0x1457C48")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002003")]
	[Address(RVA = "0x1457D30", Offset = "0x1457D30", VA = "0x1457D30")]
	private IEnumerator RepositioningRoutine(Transform player)
	{
		return null;
	}

	[Token(Token = "0x6002004")]
	[Address(RVA = "0x1457DA8", Offset = "0x1457DA8", VA = "0x1457DA8")]
	public FPGFlyingOuterLimit()
	{
	}
}
