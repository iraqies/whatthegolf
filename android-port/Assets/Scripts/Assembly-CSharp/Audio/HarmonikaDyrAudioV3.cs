using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace Audio
{
	[Token(Token = "0x2001376")]
	public class HarmonikaDyrAudioV3 : MonoBehaviour
	{
		[Token(Token = "0x2001377")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48D44", Offset = "0x48D44")]
		private sealed class _003CDelayedInit_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006878")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006879")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400687A")]
			[FieldOffset(Offset = "0x20")]
			public HarmonikaDyrAudioV3 _003C_003E4__this;

			[Token(Token = "0x17000A46")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005AF0")]
				[Address(RVA = "0x17BA1A8", Offset = "0x17BA1A8", VA = "0x17BA1A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A47")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005AF2")]
				[Address(RVA = "0x17BA1F0", Offset = "0x17BA1F0", VA = "0x17BA1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005AED")]
			[Address(RVA = "0x17B9FC4", Offset = "0x17B9FC4", VA = "0x17B9FC4")]
			[DebuggerHidden]
			public _003CDelayedInit_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005AEE")]
			[Address(RVA = "0x17B9FF0", Offset = "0x17B9FF0", VA = "0x17B9FF0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005AEF")]
			[Address(RVA = "0x17B9FF4", Offset = "0x17B9FF4", VA = "0x17B9FF4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005AF0")]
			[Address(RVA = "0x17BA1A8", Offset = "0x17BA1A8", VA = "0x17BA1A8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005AF1")]
			[Address(RVA = "0x17BA1B0", Offset = "0x17BA1B0", VA = "0x17BA1B0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005AF2")]
			[Address(RVA = "0x17BA1F0", Offset = "0x17BA1F0", VA = "0x17BA1F0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001378")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48D54", Offset = "0x48D54")]
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			[Token(Token = "0x400687B")]
			[FieldOffset(Offset = "0x10")]
			public float pitch;

			[Token(Token = "0x6005AF3")]
			[Address(RVA = "0x17B9F9C", Offset = "0x17B9F9C", VA = "0x17B9F9C")]
			public _003C_003Ec__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6005AF4")]
			[Address(RVA = "0x17B9FA4", Offset = "0x17B9FA4", VA = "0x17B9FA4")]
			internal void _003CUpdate_003Eb__0(AudioSource s)
			{
			}
		}

		[Token(Token = "0x400686C")]
		[FieldOffset(Offset = "0x18")]
		public HarmonikaDyrShooter harmonika;

		[Token(Token = "0x400686D")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip clipOut;

		[Token(Token = "0x400686E")]
		[FieldOffset(Offset = "0x28")]
		public AudioMixerGroup mixerGroup;

		[Token(Token = "0x400686F")]
		[FieldOffset(Offset = "0x30")]
		public int fullStretchNoteAmount;

		[Token(Token = "0x4006870")]
		[FieldOffset(Offset = "0x34")]
		public int baseNote;

		[Token(Token = "0x4006871")]
		[FieldOffset(Offset = "0x38")]
		public MusicMathUtils.Scale scale;

		[Token(Token = "0x4006872")]
		[FieldOffset(Offset = "0x3C")]
		private int randomBase;

		[Token(Token = "0x4006873")]
		[FieldOffset(Offset = "0x40")]
		private float currDistance;

		[Token(Token = "0x4006874")]
		[FieldOffset(Offset = "0x44")]
		private int lastNote;

		[Token(Token = "0x4006875")]
		[FieldOffset(Offset = "0x48")]
		private ScheduleAudio scheduler;

		[Token(Token = "0x4006876")]
		[FieldOffset(Offset = "0x50")]
		private bool init;

		[Token(Token = "0x4006877")]
		[FieldOffset(Offset = "0x54")]
		private float lastDist;

		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0x14C481C", Offset = "0x14C481C", VA = "0x14C481C")]
		private void Start()
		{
		}

		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0x14C4898", Offset = "0x14C4898", VA = "0x14C4898")]
		private IEnumerator DelayedInit()
		{
			return null;
		}

		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0x14C490C", Offset = "0x14C490C", VA = "0x14C490C")]
		private int ReturnNote(int index)
		{
			return default;
		}

		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0x14C4A00", Offset = "0x14C4A00", VA = "0x14C4A00")]
		private void Update()
		{
		}

		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0x14C4E00", Offset = "0x14C4E00", VA = "0x14C4E00")]
		public HarmonikaDyrAudioV3()
		{
		}
	}
}
