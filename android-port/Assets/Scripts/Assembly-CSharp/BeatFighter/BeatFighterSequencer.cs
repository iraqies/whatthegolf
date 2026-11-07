using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace BeatFighter
{
	[Token(Token = "0x20010E8")]
	public class BeatFighterSequencer : MonoBehaviour
	{
		[Token(Token = "0x20010E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47BD4", Offset = "0x47BD4")]
		private sealed class _003CStart_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005925")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005926")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005927")]
			[FieldOffset(Offset = "0x20")]
			public BeatFighterSequencer _003C_003E4__this;

			[Token(Token = "0x17000802")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004BBE")]
				[Address(RVA = "0x1772940", Offset = "0x1772940", VA = "0x1772940", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000803")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004BC0")]
				[Address(RVA = "0x1772988", Offset = "0x1772988", VA = "0x1772988", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004BBB")]
			[Address(RVA = "0x17721D8", Offset = "0x17721D8", VA = "0x17721D8")]
			[DebuggerHidden]
			public _003CStart_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004BBC")]
			[Address(RVA = "0x1772204", Offset = "0x1772204", VA = "0x1772204", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004BBD")]
			[Address(RVA = "0x1772208", Offset = "0x1772208", VA = "0x1772208", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004BBE")]
			[Address(RVA = "0x1772940", Offset = "0x1772940", VA = "0x1772940", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004BBF")]
			[Address(RVA = "0x1772948", Offset = "0x1772948", VA = "0x1772948", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004BC0")]
			[Address(RVA = "0x1772988", Offset = "0x1772988", VA = "0x1772988", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005912")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BeatTrack track;

		[Token(Token = "0x4005913")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform indicatorsRoot;

		[Token(Token = "0x4005914")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BeatFighterShooter shooter;

		[Token(Token = "0x4005915")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActionIndicator actionIndicatorPrefab;

		[Token(Token = "0x4005916")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int numberOfAudioSources;

		[Token(Token = "0x4005917")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioSource loopAudioSource;

		[Token(Token = "0x4005918")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private double timeBeforeStart;

		[Token(Token = "0x4005919")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioClip failClip;

		[Token(Token = "0x400591A")]
		[FieldOffset(Offset = "0x58")]
		private NoteOnBeat[] notesOnBeat;

		[Token(Token = "0x400591B")]
		[FieldOffset(Offset = "0x60")]
		private List<AttackObject> attackObjects;

		[Token(Token = "0x400591C")]
		[FieldOffset(Offset = "0x68")]
		private AudioSource[] audioSources;

		[Token(Token = "0x400591D")]
		[FieldOffset(Offset = "0x70")]
		private int audioSourceIndex;

		[Token(Token = "0x400591E")]
		[FieldOffset(Offset = "0x78")]
		private double startTime;

		[Token(Token = "0x400591F")]
		[FieldOffset(Offset = "0x80")]
		private double time;

		[Token(Token = "0x4005920")]
		[FieldOffset(Offset = "0x88")]
		private double timePerBeat;

		[Token(Token = "0x4005921")]
		[FieldOffset(Offset = "0x90")]
		private Level level;

		[Token(Token = "0x4005922")]
		[FieldOffset(Offset = "0x98")]
		private BeatTrackAction playerAction;

		[Token(Token = "0x4005923")]
		[FieldOffset(Offset = "0xA0")]
		private float playerActionBeat;

		[Token(Token = "0x4005924")]
		[FieldOffset(Offset = "0xA4")]
		private float beat;

		[Token(Token = "0x170007FF")]
		public float TimePerBeat
		{
			[Token(Token = "0x6004BB7")]
			[Address(RVA = "0x160D230", Offset = "0x160D230", VA = "0x160D230")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000800")]
		public double Time
		{
			[Token(Token = "0x6004BB8")]
			[Address(RVA = "0x160D23C", Offset = "0x160D23C", VA = "0x160D23C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000801")]
		public double BeatTime
		{
			[Token(Token = "0x6004BB9")]
			[Address(RVA = "0x160D248", Offset = "0x160D248", VA = "0x160D248")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004BB3")]
		[Address(RVA = "0x160D08C", Offset = "0x160D08C", VA = "0x160D08C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6004BB4")]
		[Address(RVA = "0x160D100", Offset = "0x160D100", VA = "0x160D100")]
		public void PushPlayerAction(BeatTrackAction action)
		{
		}

		[Token(Token = "0x6004BB5")]
		[Address(RVA = "0x160D110", Offset = "0x160D110", VA = "0x160D110")]
		private void MoveTargets()
		{
		}

		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0x160D1B8", Offset = "0x160D1B8", VA = "0x160D1B8")]
		private void PlayClip(AudioClip clip)
		{
		}

		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x160D264", Offset = "0x160D264", VA = "0x160D264")]
		public BeatFighterSequencer()
		{
		}
	}
}
