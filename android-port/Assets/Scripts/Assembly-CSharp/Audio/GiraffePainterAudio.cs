using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200133F")]
	public class GiraffePainterAudio : MonoBehaviour
	{
		[Token(Token = "0x2001340")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48BC0", Offset = "0x48BC0")]
		private sealed class _003CDelayedPlay_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006708")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006709")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400670A")]
			[FieldOffset(Offset = "0x20")]
			public float duration;

			[Token(Token = "0x400670B")]
			[FieldOffset(Offset = "0x28")]
			public GiraffePainterAudio _003C_003E4__this;

			[Token(Token = "0x17000A1C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60059D4")]
				[Address(RVA = "0x17B4678", Offset = "0x17B4678", VA = "0x17B4678", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A1D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60059D6")]
				[Address(RVA = "0x17B46C0", Offset = "0x17B46C0", VA = "0x17B46C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60059D1")]
			[Address(RVA = "0x17B4584", Offset = "0x17B4584", VA = "0x17B4584")]
			[DebuggerHidden]
			public _003CDelayedPlay_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60059D2")]
			[Address(RVA = "0x17B45B0", Offset = "0x17B45B0", VA = "0x17B45B0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60059D3")]
			[Address(RVA = "0x17B45B4", Offset = "0x17B45B4", VA = "0x17B45B4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60059D4")]
			[Address(RVA = "0x17B4678", Offset = "0x17B4678", VA = "0x17B4678", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60059D5")]
			[Address(RVA = "0x17B4680", Offset = "0x17B4680", VA = "0x17B4680", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60059D6")]
			[Address(RVA = "0x17B46C0", Offset = "0x17B46C0", VA = "0x17B46C0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001341")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48BD0", Offset = "0x48BD0")]
		private sealed class _003CRedoPoseSequence_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400670C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400670D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400670E")]
			[FieldOffset(Offset = "0x20")]
			public GiraffePainterAudio _003C_003E4__this;

			[Token(Token = "0x17000A1E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60059DA")]
				[Address(RVA = "0x17B47F8", Offset = "0x17B47F8", VA = "0x17B47F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A1F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60059DC")]
				[Address(RVA = "0x17B4840", Offset = "0x17B4840", VA = "0x17B4840", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60059D7")]
			[Address(RVA = "0x17B46C8", Offset = "0x17B46C8", VA = "0x17B46C8")]
			[DebuggerHidden]
			public _003CRedoPoseSequence_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60059D8")]
			[Address(RVA = "0x17B46F4", Offset = "0x17B46F4", VA = "0x17B46F4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60059D9")]
			[Address(RVA = "0x17B46F8", Offset = "0x17B46F8", VA = "0x17B46F8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60059DA")]
			[Address(RVA = "0x17B47F8", Offset = "0x17B47F8", VA = "0x17B47F8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60059DB")]
			[Address(RVA = "0x17B4800", Offset = "0x17B4800", VA = "0x17B4800", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60059DC")]
			[Address(RVA = "0x17B4840", Offset = "0x17B4840", VA = "0x17B4840", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40066FD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isSprayCan;

		[Token(Token = "0x40066FE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GiraffePainterController painter;

		[Token(Token = "0x40066FF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4006700")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float sourcePlayDelay;

		[Token(Token = "0x4006701")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ClipSettingsCollection autoCompleteSfx;

		[Token(Token = "0x4006702")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClipSettingsCollection newPoseReadySfx;

		[Token(Token = "0x4006703")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ClipSettingsCollection failPoseSfx;

		[Token(Token = "0x4006704")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClipSettingsCollection shakeCanSfx;

		[Token(Token = "0x4006705")]
		[FieldOffset(Offset = "0x58")]
		private bool didChangePose;

		[Token(Token = "0x4006706")]
		[FieldOffset(Offset = "0x5C")]
		private GiraffePainterController.PaintStateEnum state;

		[Token(Token = "0x4006707")]
		[FieldOffset(Offset = "0x60")]
		private GolfGoal goal;

		[Token(Token = "0x60059C7")]
		[Address(RVA = "0x148A400", Offset = "0x148A400", VA = "0x148A400")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059C8")]
		[Address(RVA = "0x148A7FC", Offset = "0x148A7FC", VA = "0x148A7FC")]
		private void OnAnyComplete()
		{
		}

		[Token(Token = "0x60059C9")]
		[Address(RVA = "0x148A850", Offset = "0x148A850", VA = "0x148A850")]
		private void OnGoal(string obj)
		{
		}

		[Token(Token = "0x60059CA")]
		[Address(RVA = "0x148A8F4", Offset = "0x148A8F4", VA = "0x148A8F4")]
		private void Instance_OnLevelWillUnload()
		{
		}

		[Token(Token = "0x60059CB")]
		[Address(RVA = "0x148A998", Offset = "0x148A998", VA = "0x148A998")]
		private void OnRedoPose()
		{
		}

		[Token(Token = "0x60059CC")]
		[Address(RVA = "0x148AA88", Offset = "0x148AA88", VA = "0x148AA88")]
		private void OnNewPose()
		{
		}

		[Token(Token = "0x60059CD")]
		[Address(RVA = "0x148AB10", Offset = "0x148AB10", VA = "0x148AB10")]
		private void OnChangeState(GiraffePainterController.PaintStateEnum newState)
		{
		}

		[Token(Token = "0x60059CE")]
		[Address(RVA = "0x148ABFC", Offset = "0x148ABFC", VA = "0x148ABFC")]
		private IEnumerator DelayedPlay(float duration)
		{
			return null;
		}

		[Token(Token = "0x60059CF")]
		[Address(RVA = "0x148AA14", Offset = "0x148AA14", VA = "0x148AA14")]
		private IEnumerator RedoPoseSequence()
		{
			return null;
		}

		[Token(Token = "0x60059D0")]
		[Address(RVA = "0x148AC80", Offset = "0x148AC80", VA = "0x148AC80")]
		public GiraffePainterAudio()
		{
		}
	}
}
