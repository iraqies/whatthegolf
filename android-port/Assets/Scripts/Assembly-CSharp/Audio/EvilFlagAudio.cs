using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001371")]
	public class EvilFlagAudio : MonoBehaviour
	{
		[Token(Token = "0x2001372")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48D34", Offset = "0x48D34")]
		private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400683C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400683D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400683E")]
			[FieldOffset(Offset = "0x20")]
			public EvilFlagAudio _003C_003E4__this;

			[Token(Token = "0x17000A44")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005AD7")]
				[Address(RVA = "0x17A0620", Offset = "0x17A0620", VA = "0x17A0620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A45")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005AD9")]
				[Address(RVA = "0x17A0668", Offset = "0x17A0668", VA = "0x17A0668", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005AD4")]
			[Address(RVA = "0x17A0540", Offset = "0x17A0540", VA = "0x17A0540")]
			[DebuggerHidden]
			public _003CStart_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005AD5")]
			[Address(RVA = "0x17A056C", Offset = "0x17A056C", VA = "0x17A056C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005AD6")]
			[Address(RVA = "0x17A0570", Offset = "0x17A0570", VA = "0x17A0570", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005AD7")]
			[Address(RVA = "0x17A0620", Offset = "0x17A0620", VA = "0x17A0620", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005AD8")]
			[Address(RVA = "0x17A0628", Offset = "0x17A0628", VA = "0x17A0628", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005AD9")]
			[Address(RVA = "0x17A0668", Offset = "0x17A0668", VA = "0x17A0668", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006833")]
		[FieldOffset(Offset = "0x18")]
		public ClipSettingsCollection SFX_OnStop_NoHit;

		[Token(Token = "0x4006834")]
		[FieldOffset(Offset = "0x20")]
		public ClipSettingsCollection SFX_OnSlide_Start;

		[Token(Token = "0x4006835")]
		[FieldOffset(Offset = "0x28")]
		public ClipSettingsCollection SFX_OnHitFlag;

		[Token(Token = "0x4006836")]
		[FieldOffset(Offset = "0x30")]
		public ScheduleHarmonics scheduleHarmonics;

		[Token(Token = "0x4006837")]
		[FieldOffset(Offset = "0x38")]
		public Rigidbody rigid;

		[Token(Token = "0x4006838")]
		[FieldOffset(Offset = "0x40")]
		private bool canPlay;

		[Token(Token = "0x4006839")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 lastVelocity;

		[Token(Token = "0x400683A")]
		[FieldOffset(Offset = "0x50")]
		private bool moving;

		[Token(Token = "0x400683B")]
		[FieldOffset(Offset = "0x51")]
		private bool hitFlag;

		[Token(Token = "0x6005AD0")]
		[Address(RVA = "0x1449638", Offset = "0x1449638", VA = "0x1449638")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0x14496AC", Offset = "0x14496AC", VA = "0x14496AC")]
		public void HitFlag()
		{
		}

		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0x1449778", Offset = "0x1449778", VA = "0x1449778")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0x1449B3C", Offset = "0x1449B3C", VA = "0x1449B3C")]
		public EvilFlagAudio()
		{
		}
	}
}
