using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace MusicGolf
{
	[Token(Token = "0x20010B7")]
	public class BeatObjectSequencer : MonoBehaviour
	{
		[Token(Token = "0x20010B8")]
		private class BeatEvent
		{
			[Token(Token = "0x4005813")]
			[FieldOffset(Offset = "0x10")]
			public BeatEventType Type;

			[Token(Token = "0x4005814")]
			[FieldOffset(Offset = "0x18")]
			public BeatObject BeatObject;

			[Token(Token = "0x6004AEF")]
			[Address(RVA = "0x17730AC", Offset = "0x17730AC", VA = "0x17730AC")]
			public BeatEvent()
			{
			}
		}

		[Token(Token = "0x20010B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B14", Offset = "0x47B14")]
		private sealed class _003CStart_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005815")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005816")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005817")]
			[FieldOffset(Offset = "0x20")]
			public BeatObjectSequencer _003C_003E4__this;

			[Token(Token = "0x4005818")]
			[FieldOffset(Offset = "0x28")]
			private double _003CnextBeatTime_003E5__2;

			[Token(Token = "0x4005819")]
			[FieldOffset(Offset = "0x30")]
			private int _003Cbeat_003E5__3;

			[Token(Token = "0x400581A")]
			[FieldOffset(Offset = "0x34")]
			private int _003CscheduledBeat_003E5__4;

			[Token(Token = "0x170007E8")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004AF3")]
				[Address(RVA = "0x177305C", Offset = "0x177305C", VA = "0x177305C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007E9")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004AF5")]
				[Address(RVA = "0x17730A4", Offset = "0x17730A4", VA = "0x17730A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004AF0")]
			[Address(RVA = "0x1772990", Offset = "0x1772990", VA = "0x1772990")]
			[DebuggerHidden]
			public _003CStart_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004AF1")]
			[Address(RVA = "0x17729BC", Offset = "0x17729BC", VA = "0x17729BC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004AF2")]
			[Address(RVA = "0x17729C0", Offset = "0x17729C0", VA = "0x17729C0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004AF3")]
			[Address(RVA = "0x177305C", Offset = "0x177305C", VA = "0x177305C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004AF4")]
			[Address(RVA = "0x1773064", Offset = "0x1773064", VA = "0x1773064", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004AF5")]
			[Address(RVA = "0x17730A4", Offset = "0x17730A4", VA = "0x17730A4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400580D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int totalBeats;

		[Token(Token = "0x400580E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private double timePerBeat;

		[Token(Token = "0x400580F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private uint musicState;

		[Token(Token = "0x4005810")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private uint musicStateOnLevelFail;

		[Token(Token = "0x4005811")]
		[FieldOffset(Offset = "0x30")]
		private List<BeatEvent>[] eventsOnBeat;

		[Token(Token = "0x4005812")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<BeatObject> activeObjects;

		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x160D410", Offset = "0x160D410", VA = "0x160D410")]
		private void Level_OnFail(GolfBallController arg1, string arg2, Level.State arg3)
		{
		}

		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x160D46C", Offset = "0x160D46C", VA = "0x160D46C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x160D768", Offset = "0x160D768", VA = "0x160D768")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x160D7DC", Offset = "0x160D7DC", VA = "0x160D7DC")]
		public BeatObjectSequencer()
		{
		}
	}
}
