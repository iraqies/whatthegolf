using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

namespace SaloonPiano
{
	[Token(Token = "0x2001094")]
	public class SaloonPiano : MonoBehaviour
	{
		[Token(Token = "0x2001095")]
		public class Note
		{
			[Token(Token = "0x4005748")]
			[FieldOffset(Offset = "0x10")]
			public MusicPiece.NoteData noteData;

			[Token(Token = "0x4005749")]
			[FieldOffset(Offset = "0x18")]
			public NoteTarget noteTarget;

			[Token(Token = "0x400574A")]
			[FieldOffset(Offset = "0x20")]
			public bool isActive;

			[Token(Token = "0x6004A4F")]
			[Address(RVA = "0x1839550", Offset = "0x1839550", VA = "0x1839550")]
			public Note()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2001096")]
		private class NoteVisual
		{
			[Token(Token = "0x400574B")]
			[FieldOffset(Offset = "0x10")]
			public int position;

			[Token(Token = "0x400574C")]
			[FieldOffset(Offset = "0x18")]
			public GameObject root;

			[Token(Token = "0x400574D")]
			[FieldOffset(Offset = "0x20")]
			public float timer;

			[Token(Token = "0x6004A50")]
			[Address(RVA = "0x1839558", Offset = "0x1839558", VA = "0x1839558")]
			public NoteVisual()
			{
			}
		}

		[Token(Token = "0x2001097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A24", Offset = "0x47A24")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x400574E")]
			[FieldOffset(Offset = "0x10")]
			public Note node;

			[Token(Token = "0x400574F")]
			[FieldOffset(Offset = "0x18")]
			public SaloonPiano _003C_003E4__this;

			[Token(Token = "0x6004A51")]
			[Address(RVA = "0x1838ACC", Offset = "0x1838ACC", VA = "0x1838ACC")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6004A52")]
			[Address(RVA = "0x1838AD4", Offset = "0x1838AD4", VA = "0x1838AD4")]
			internal void _003CAwake_003Eb__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2001098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A34", Offset = "0x47A34")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005750")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005751")]
			[FieldOffset(Offset = "0x8")]
			public static Action<AudioSource> _003C_003E9__35_0;

			[Token(Token = "0x6004A54")]
			[Address(RVA = "0x1838A80", Offset = "0x1838A80", VA = "0x1838A80")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004A55")]
			[Address(RVA = "0x1838A88", Offset = "0x1838A88", VA = "0x1838A88")]
			internal void _003CHandleHit_003Eb__35_0(AudioSource a)
			{
			}
		}

		[Token(Token = "0x2001099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A44", Offset = "0x47A44")]
		private sealed class _003CStart_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005752")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005753")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005754")]
			[FieldOffset(Offset = "0x20")]
			public SaloonPiano _003C_003E4__this;

			[Token(Token = "0x4005755")]
			[FieldOffset(Offset = "0x28")]
			private int _003ClastBeat_003E5__2;

			[Token(Token = "0x4005756")]
			[FieldOffset(Offset = "0x2C")]
			private float _003CtimePerBeat_003E5__3;

			[Token(Token = "0x170007D4")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004A59")]
				[Address(RVA = "0x1839330", Offset = "0x1839330", VA = "0x1839330", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007D5")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004A5B")]
				[Address(RVA = "0x1839378", Offset = "0x1839378", VA = "0x1839378", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004A56")]
			[Address(RVA = "0x1838CC4", Offset = "0x1838CC4", VA = "0x1838CC4")]
			[DebuggerHidden]
			public _003CStart_003Ed__36(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004A57")]
			[Address(RVA = "0x1838CF0", Offset = "0x1838CF0", VA = "0x1838CF0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004A58")]
			[Address(RVA = "0x1838CF4", Offset = "0x1838CF4", VA = "0x1838CF4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004A59")]
			[Address(RVA = "0x1839330", Offset = "0x1839330", VA = "0x1839330", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004A5A")]
			[Address(RVA = "0x1839338", Offset = "0x1839338", VA = "0x1839338", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004A5B")]
			[Address(RVA = "0x1839378", Offset = "0x1839378", VA = "0x1839378", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200109A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A54", Offset = "0x47A54")]
		private sealed class _003CUpdateVisuals_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005757")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005758")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005759")]
			[FieldOffset(Offset = "0x20")]
			public SaloonPiano _003C_003E4__this;

			[Token(Token = "0x170007D6")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004A5F")]
				[Address(RVA = "0x1839500", Offset = "0x1839500", VA = "0x1839500", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007D7")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004A61")]
				[Address(RVA = "0x1839548", Offset = "0x1839548", VA = "0x1839548", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004A5C")]
			[Address(RVA = "0x1839380", Offset = "0x1839380", VA = "0x1839380")]
			[DebuggerHidden]
			public _003CUpdateVisuals_003Ed__37(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004A5D")]
			[Address(RVA = "0x18393AC", Offset = "0x18393AC", VA = "0x18393AC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004A5E")]
			[Address(RVA = "0x18393B0", Offset = "0x18393B0", VA = "0x18393B0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004A5F")]
			[Address(RVA = "0x1839500", Offset = "0x1839500", VA = "0x1839500", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004A60")]
			[Address(RVA = "0x1839508", Offset = "0x1839508", VA = "0x1839508", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004A61")]
			[Address(RVA = "0x1839548", Offset = "0x1839548", VA = "0x1839548", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200109B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47A64", Offset = "0x47A64")]
		private sealed class _003CAdjustSpeed_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400575A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400575B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400575C")]
			[FieldOffset(Offset = "0x20")]
			public SaloonPiano _003C_003E4__this;

			[Token(Token = "0x170007D8")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004A65")]
				[Address(RVA = "0x1838C74", Offset = "0x1838C74", VA = "0x1838C74", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007D9")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004A67")]
				[Address(RVA = "0x1838CBC", Offset = "0x1838CBC", VA = "0x1838CBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004A62")]
			[Address(RVA = "0x1838AF8", Offset = "0x1838AF8", VA = "0x1838AF8")]
			[DebuggerHidden]
			public _003CAdjustSpeed_003Ed__38(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004A63")]
			[Address(RVA = "0x1838B24", Offset = "0x1838B24", VA = "0x1838B24", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004A64")]
			[Address(RVA = "0x1838B28", Offset = "0x1838B28", VA = "0x1838B28", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004A65")]
			[Address(RVA = "0x1838C74", Offset = "0x1838C74", VA = "0x1838C74", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004A66")]
			[Address(RVA = "0x1838C7C", Offset = "0x1838C7C", VA = "0x1838C7C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004A67")]
			[Address(RVA = "0x1838CBC", Offset = "0x1838CBC", VA = "0x1838CBC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005728")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform notesRoot;

		[Token(Token = "0x4005729")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve speedCurve;

		[Token(Token = "0x400572A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MusicPiece piece;

		[Token(Token = "0x400572B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float notesMaxY;

		[Token(Token = "0x400572C")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float noteVolume;

		[Token(Token = "0x400572D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioMixerGroup outputGroup;

		[Token(Token = "0x400572E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioClip endChord;

		[Token(Token = "0x400572F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip inactiveTargetSound;

		[Token(Token = "0x4005730")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioClip hitSound;

		[Token(Token = "0x4005731")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip hitWrongSound;

		[Token(Token = "0x4005732")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int maxNumberOfPerfectRounds;

		[Token(Token = "0x4005733")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int numberOfAudioSources;

		[Token(Token = "0x4005734")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float minSpeed;

		[Token(Token = "0x4005735")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float maxSpeed;

		[Token(Token = "0x4005736")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float crazySpeedBoost;

		[Token(Token = "0x4005737")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float maxSpeedChange;

		[Token(Token = "0x4005738")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private NoteTarget noteTargetPrefab;

		[Token(Token = "0x4005739")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ParticleSystem smokeParticleSystem;

		[Token(Token = "0x400573A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float visualDuration;

		[Token(Token = "0x400573B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private NoteVisual[] visuals;

		[Token(Token = "0x400573C")]
		[FieldOffset(Offset = "0x98")]
		private List<Note>[] notesOnBeat;

		[Token(Token = "0x400573D")]
		[FieldOffset(Offset = "0xA0")]
		private List<Note> notes;

		[Token(Token = "0x400573E")]
		[FieldOffset(Offset = "0xA8")]
		private HashSet<Note> hitNotes;

		[Token(Token = "0x400573F")]
		[FieldOffset(Offset = "0xB0")]
		private AudioSource[] audioSources;

		[Token(Token = "0x4005740")]
		[FieldOffset(Offset = "0xB8")]
		private int audioSourceIndex;

		[Token(Token = "0x4005741")]
		[FieldOffset(Offset = "0xBC")]
		private float speed;

		[Token(Token = "0x4005742")]
		[FieldOffset(Offset = "0xC0")]
		private float targetSpeed;

		[Token(Token = "0x4005743")]
		[FieldOffset(Offset = "0xC4")]
		private float time;

		[Token(Token = "0x4005744")]
		[FieldOffset(Offset = "0xC8")]
		private int perfectRounds;

		[Token(Token = "0x4005745")]
		[FieldOffset(Offset = "0xD0")]
		private Level level;

		[Token(Token = "0x4005746")]
		[FieldOffset(Offset = "0xD8")]
		private int numberOfGoodNotes;

		[Token(Token = "0x4005747")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<int, NoteVisual> visualByPosition;

		[Token(Token = "0x6004A48")]
		[Address(RVA = "0x1668CE8", Offset = "0x1668CE8", VA = "0x1668CE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004A49")]
		[Address(RVA = "0x1669548", Offset = "0x1669548", VA = "0x1669548")]
		private void HandleHit(Note note)
		{
		}

		[Token(Token = "0x6004A4A")]
		[Address(RVA = "0x1669724", Offset = "0x1669724", VA = "0x1669724")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6004A4B")]
		[Address(RVA = "0x1669798", Offset = "0x1669798", VA = "0x1669798")]
		private IEnumerator UpdateVisuals()
		{
			return null;
		}

		[Token(Token = "0x6004A4C")]
		[Address(RVA = "0x166980C", Offset = "0x166980C", VA = "0x166980C")]
		private IEnumerator AdjustSpeed()
		{
			return null;
		}

		[Token(Token = "0x6004A4D")]
		[Address(RVA = "0x1669880", Offset = "0x1669880", VA = "0x1669880")]
		private void PlayClip(AudioClip clip)
		{
		}

		[Token(Token = "0x6004A4E")]
		[Address(RVA = "0x16698F8", Offset = "0x16698F8", VA = "0x16698F8")]
		public SaloonPiano()
		{
		}
	}
}
