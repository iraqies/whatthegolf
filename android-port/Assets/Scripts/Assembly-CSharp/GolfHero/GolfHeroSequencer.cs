using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GolfHero
{
	[Token(Token = "0x20010D5")]
	public class GolfHeroSequencer : MonoBehaviour
	{
		[Token(Token = "0x20010D6")]
		private class Note
		{
			[Token(Token = "0x40058BE")]
			[FieldOffset(Offset = "0x10")]
			public int beat;

			[Token(Token = "0x40058BF")]
			[FieldOffset(Offset = "0x18")]
			public MusicPieceNote noteData;

			[Token(Token = "0x40058C0")]
			[FieldOffset(Offset = "0x20")]
			public NoteTarget noteTarget;

			[Token(Token = "0x40058C1")]
			[FieldOffset(Offset = "0x28")]
			public LineRenderer line;

			[Token(Token = "0x6004B72")]
			[Address(RVA = "0x17B5DE0", Offset = "0x17B5DE0", VA = "0x17B5DE0")]
			public Note()
			{
			}
		}

		[Token(Token = "0x20010D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47BA4", Offset = "0x47BA4")]
		private sealed class _003CStartSequencer_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40058C2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40058C3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40058C4")]
			[FieldOffset(Offset = "0x20")]
			public GolfHeroSequencer _003C_003E4__this;

			[Token(Token = "0x40058C5")]
			[FieldOffset(Offset = "0x28")]
			private int _003ClastBeat_003E5__2;

			[Token(Token = "0x170007FA")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B76")]
				[Address(RVA = "0x17B5D90", Offset = "0x17B5D90", VA = "0x17B5D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007FB")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B78")]
				[Address(RVA = "0x17B5DD8", Offset = "0x17B5DD8", VA = "0x17B5DD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004B73")]
			[Address(RVA = "0x17B5814", Offset = "0x17B5814", VA = "0x17B5814")]
			[DebuggerHidden]
			public _003CStartSequencer_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B74")]
			[Address(RVA = "0x17B5840", Offset = "0x17B5840", VA = "0x17B5840", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B75")]
			[Address(RVA = "0x17B5844", Offset = "0x17B5844", VA = "0x17B5844", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004B76")]
			[Address(RVA = "0x17B5D90", Offset = "0x17B5D90", VA = "0x17B5D90", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004B77")]
			[Address(RVA = "0x17B5D98", Offset = "0x17B5D98", VA = "0x17B5D98", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004B78")]
			[Address(RVA = "0x17B5DD8", Offset = "0x17B5DD8", VA = "0x17B5DD8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40058A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool playAudioClips;

		[Token(Token = "0x40058AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MusicPiece piece;

		[Token(Token = "0x40058AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform notesRoot;

		[Token(Token = "0x40058AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GolfHeroShooter shooter;

		[Token(Token = "0x40058AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NoteTarget noteTargetPrefab;

		[Token(Token = "0x40058AE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int numberOfAudioSources;

		[Token(Token = "0x40058AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioSource loopAudioSource;

		[Token(Token = "0x40058B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private double timeBeforeStart;

		[Token(Token = "0x40058B1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Camera visualsCamera;

		[Token(Token = "0x40058B2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color[] colors;

		[Token(Token = "0x40058B3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ClipSettingsCollection sfxOnFail;

		[Token(Token = "0x40058B4")]
		[FieldOffset(Offset = "0x70")]
		private List<Note>[] notesOnBeat;

		[Token(Token = "0x40058B5")]
		[FieldOffset(Offset = "0x78")]
		private List<Note> notes;

		[Token(Token = "0x40058B6")]
		[FieldOffset(Offset = "0x80")]
		private AudioSource[] audioSources;

		[Token(Token = "0x40058B7")]
		[FieldOffset(Offset = "0x88")]
		private int audioSourceIndex;

		[Token(Token = "0x40058B8")]
		[FieldOffset(Offset = "0x90")]
		private double startTime;

		[Token(Token = "0x40058B9")]
		[FieldOffset(Offset = "0x98")]
		private double time;

		[Token(Token = "0x40058BA")]
		[FieldOffset(Offset = "0xA0")]
		private double timePerBeat;

		[Token(Token = "0x40058BB")]
		[FieldOffset(Offset = "0xA8")]
		private double pausedTime;

		[Token(Token = "0x40058BC")]
		[FieldOffset(Offset = "0xB0")]
		private Level level;

		[Token(Token = "0x40058BD")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56220", Offset = "0x56220")]
		private bool IsRunning__BackingField;

		[Token(Token = "0x170007F6")]
		public bool IsRunning
		{
			[Token(Token = "0x6004B64")]
			[Address(RVA = "0x14A0F60", Offset = "0x14A0F60", VA = "0x14A0F60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F9F4", Offset = "0x6F9F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004B65")]
			[Address(RVA = "0x14A0F68", Offset = "0x14A0F68", VA = "0x14A0F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FA04", Offset = "0x6FA04")]
			private set
			{
			}
		}

		[Token(Token = "0x170007F7")]
		public float TimePerBeat
		{
			[Token(Token = "0x6004B6E")]
			[Address(RVA = "0x14A1BFC", Offset = "0x14A1BFC", VA = "0x14A1BFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170007F8")]
		public double Time
		{
			[Token(Token = "0x6004B6F")]
			[Address(RVA = "0x14A1C08", Offset = "0x14A1C08", VA = "0x14A1C08")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170007F9")]
		public double BeatTime
		{
			[Token(Token = "0x6004B70")]
			[Address(RVA = "0x14A0ECC", Offset = "0x14A0ECC", VA = "0x14A0ECC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004B66")]
		[Address(RVA = "0x14A0F70", Offset = "0x14A0F70", VA = "0x14A0F70")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B67")]
		[Address(RVA = "0x14A16B0", Offset = "0x14A16B0", VA = "0x14A16B0")]
		private void OnLevelStart()
		{
		}

		[Token(Token = "0x6004B68")]
		[Address(RVA = "0x14A17C8", Offset = "0x14A17C8", VA = "0x14A17C8")]
		private void OnFail(GolfBallController arg1, string arg2, Level.State arg3)
		{
		}

		[Token(Token = "0x6004B69")]
		[Address(RVA = "0x14A1094", Offset = "0x14A1094", VA = "0x14A1094")]
		private void Init()
		{
		}

		[Token(Token = "0x6004B6A")]
		[Address(RVA = "0x14A1754", Offset = "0x14A1754", VA = "0x14A1754")]
		public IEnumerator StartSequencer()
		{
			return null;
		}

		[Token(Token = "0x6004B6B")]
		[Address(RVA = "0x14A183C", Offset = "0x14A183C", VA = "0x14A183C")]
		private bool CheckIfPaused()
		{
			return default;
		}

		[Token(Token = "0x6004B6C")]
		[Address(RVA = "0x14A18DC", Offset = "0x14A18DC", VA = "0x14A18DC")]
		private void MoveTargets()
		{
		}

		[Token(Token = "0x6004B6D")]
		[Address(RVA = "0x14A1B78", Offset = "0x14A1B78", VA = "0x14A1B78")]
		private void PlayClip(AudioClip clip)
		{
		}

		[Token(Token = "0x6004B71")]
		[Address(RVA = "0x14A1C14", Offset = "0x14A1C14", VA = "0x14A1C14")]
		public GolfHeroSequencer()
		{
		}
	}
}
