using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001342")]
	public class HammerThrowingAudio : MonoBehaviour
	{
		[Token(Token = "0x2001343")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48BE0", Offset = "0x48BE0")]
		private sealed class _003CAcceleratingStartCoroutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006717")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006718")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006719")]
			[FieldOffset(Offset = "0x20")]
			public HammerThrowingAudio _003C_003E4__this;

			[Token(Token = "0x400671A")]
			[FieldOffset(Offset = "0x28")]
			private float _003Celapsed_003E5__2;

			[Token(Token = "0x17000A20")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60059E7")]
				[Address(RVA = "0x17B9B40", Offset = "0x17B9B40", VA = "0x17B9B40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A21")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60059E9")]
				[Address(RVA = "0x17B9B88", Offset = "0x17B9B88", VA = "0x17B9B88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60059E4")]
			[Address(RVA = "0x17B9A0C", Offset = "0x17B9A0C", VA = "0x17B9A0C")]
			[DebuggerHidden]
			public _003CAcceleratingStartCoroutine_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60059E5")]
			[Address(RVA = "0x17B9A38", Offset = "0x17B9A38", VA = "0x17B9A38", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60059E6")]
			[Address(RVA = "0x17B9A3C", Offset = "0x17B9A3C", VA = "0x17B9A3C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60059E7")]
			[Address(RVA = "0x17B9B40", Offset = "0x17B9B40", VA = "0x17B9B40", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60059E8")]
			[Address(RVA = "0x17B9B48", Offset = "0x17B9B48", VA = "0x17B9B48", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60059E9")]
			[Address(RVA = "0x17B9B88", Offset = "0x17B9B88", VA = "0x17B9B88", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400670F")]
		[FieldOffset(Offset = "0x18")]
		public SpinningBowlerPuppet bowler;

		[Token(Token = "0x4006710")]
		[FieldOffset(Offset = "0x20")]
		public PlayAudioClipsByFrequency clipPlayer;

		[Token(Token = "0x4006711")]
		[FieldOffset(Offset = "0x28")]
		public MinMax frequencyRange;

		[Token(Token = "0x4006712")]
		[FieldOffset(Offset = "0x30")]
		public MinMax modulationRange;

		[Token(Token = "0x4006713")]
		[FieldOffset(Offset = "0x38")]
		public float accelerateOverTime;

		[Token(Token = "0x4006714")]
		[FieldOffset(Offset = "0x40")]
		public DropPropOnShoot propDropper;

		[Token(Token = "0x4006715")]
		[FieldOffset(Offset = "0x48")]
		public ClipSettingsCollection shootSfx;

		[Token(Token = "0x4006716")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine acceleratingStartRoutine;

		[Token(Token = "0x60059DD")]
		[Address(RVA = "0x14C1880", Offset = "0x14C1880", VA = "0x14C1880")]
		private void Start()
		{
		}

		[Token(Token = "0x60059DE")]
		[Address(RVA = "0x14C1BAC", Offset = "0x14C1BAC", VA = "0x14C1BAC")]
		private void OnDroppedProp(Vector3 obj)
		{
		}

		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x14C1BF4", Offset = "0x14C1BF4", VA = "0x14C1BF4")]
		private void StopWhoosh()
		{
		}

		[Token(Token = "0x60059E0")]
		[Address(RVA = "0x14C1C10", Offset = "0x14C1C10", VA = "0x14C1C10")]
		private void StartWhoosh()
		{
		}

		[Token(Token = "0x60059E1")]
		[Address(RVA = "0x14C1CB8", Offset = "0x14C1CB8", VA = "0x14C1CB8")]
		private IEnumerator AcceleratingStartCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60059E2")]
		[Address(RVA = "0x14C1D2C", Offset = "0x14C1D2C", VA = "0x14C1D2C")]
		public HammerThrowingAudio()
		{
		}

		[Token(Token = "0x60059E3")]
		[Address(RVA = "0x14C1DCC", Offset = "0x14C1DCC", VA = "0x14C1DCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72128", Offset = "0x72128")]
		private void _003CStart_003Eb__8_0(Vector3 v)
		{
		}
	}
}
