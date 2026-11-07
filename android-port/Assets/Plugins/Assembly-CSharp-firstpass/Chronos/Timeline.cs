using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002A9")]
	[DisallowMultipleComponent]
	public class Timeline : TimelineEffector
	{
		[Serializable]
		[Token(Token = "0x20002AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x342A0", Offset = "0x342A0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4001166")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4001167")]
			[FieldOffset(Offset = "0x8")]
			public static Func<IAreaClock, bool> _003C_003E9__54_0;

			[Token(Token = "0x60011CF")]
			[Address(RVA = "0x1356F40", Offset = "0x1356F40", VA = "0x1356F40")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60011D0")]
			[Address(RVA = "0x1356F48", Offset = "0x1356F48", VA = "0x1356F48")]
			internal bool _003CReleaseFromAll_003Eb__54_0(IAreaClock ac)
			{
				return default;
			}
		}

		[Token(Token = "0x20002AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x342B0", Offset = "0x342B0")]
		private sealed class _003CWaitingForSeconds_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001168")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001169")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400116A")]
			[FieldOffset(Offset = "0x20")]
			public Timeline _003C_003E4__this;

			[Token(Token = "0x400116B")]
			[FieldOffset(Offset = "0x28")]
			public float seconds;

			[Token(Token = "0x400116C")]
			[FieldOffset(Offset = "0x2C")]
			private float _003Cstart_003E5__2;

			[Token(Token = "0x17000230")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60011D4")]
				[Address(RVA = "0x1357000", Offset = "0x1357000", VA = "0x1357000", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000231")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60011D6")]
				[Address(RVA = "0x1357048", Offset = "0x1357048", VA = "0x1357048", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60011D1")]
			[Address(RVA = "0x1356F54", Offset = "0x1356F54", VA = "0x1356F54")]
			[DebuggerHidden]
			public _003CWaitingForSeconds_003Ed__85(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60011D2")]
			[Address(RVA = "0x1356F80", Offset = "0x1356F80", VA = "0x1356F80", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60011D3")]
			[Address(RVA = "0x1356F84", Offset = "0x1356F84", VA = "0x1356F84", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x1357000", Offset = "0x1357000", VA = "0x1357000", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x1357008", Offset = "0x1357008", VA = "0x1357008", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60011D6")]
			[Address(RVA = "0x1357048", Offset = "0x1357048", VA = "0x1357048", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001152")]
		protected internal const float DefaultRecordingDuration = 30f;

		[Token(Token = "0x4001153")]
		[FieldOffset(Offset = "0x78")]
		protected internal float lastTimeScale;

		[Token(Token = "0x4001154")]
		[FieldOffset(Offset = "0x80")]
		protected Queue<float> previousDeltaTimes;

		[Token(Token = "0x4001155")]
		[FieldOffset(Offset = "0x88")]
		protected List<Occurrence> occurrences;

		[Token(Token = "0x4001156")]
		[FieldOffset(Offset = "0x90")]
		protected HashSet<Occurrence> handledOccurrences;

		[Token(Token = "0x4001157")]
		[FieldOffset(Offset = "0x98")]
		protected Occurrence nextForwardOccurrence;

		[Token(Token = "0x4001158")]
		[FieldOffset(Offset = "0xA0")]
		protected Occurrence nextBackwardOccurrence;

		[Token(Token = "0x4001159")]
		[FieldOffset(Offset = "0xA8")]
		protected internal List<IAreaClock> areaClocks;

		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0xB0")]
		protected internal List<TimelineChild> children;

		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TimelineMode _mode;

		[Token(Token = "0x400115C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string _globalClockKey;

		[Token(Token = "0x400115D")]
		[FieldOffset(Offset = "0xC8")]
		private Clock _clock;

		[Token(Token = "0x400115E")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x37394", Offset = "0x37394")]
		private float timeScale__BackingField;

		[Token(Token = "0x400115F")]
		[FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x373A4", Offset = "0x373A4")]
		private float deltaTime__BackingField;

		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x373B4", Offset = "0x373B4")]
		private float fixedDeltaTime__BackingField;

		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x0")]
		public static int smoothingDeltas;

		[Token(Token = "0x4001162")]
		[FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x373C4", Offset = "0x373C4")]
		private float time__BackingField;

		[Token(Token = "0x4001163")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x373D4", Offset = "0x373D4")]
		private float unscaledTime__BackingField;

		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x373E4", Offset = "0x373E4")]
		private bool _rewindable;

		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _recordingDuration;

		[Token(Token = "0x17000222")]
		protected override Timeline timeline
		{
			[Token(Token = "0x6001194")]
			[Address(RVA = "0x131EF58", Offset = "0x131EF58", VA = "0x131EF58", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000223")]
		public TimelineMode mode
		{
			[Token(Token = "0x6001195")]
			[Address(RVA = "0x131EF5C", Offset = "0x131EF5C", VA = "0x131EF5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x131EF64", Offset = "0x131EF64", VA = "0x131EF64")]
			set
			{
			}
		}

		[Token(Token = "0x17000224")]
		public string globalClockKey
		{
			[Token(Token = "0x6001197")]
			[Address(RVA = "0x131EF70", Offset = "0x131EF70", VA = "0x131EF70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001198")]
			[Address(RVA = "0x131EF78", Offset = "0x131EF78", VA = "0x131EF78")]
			set
			{
			}
		}

		[Token(Token = "0x17000225")]
		public Clock clock
		{
			[Token(Token = "0x6001199")]
			[Address(RVA = "0x131E180", Offset = "0x131E180", VA = "0x131E180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000226")]
		public float timeScale
		{
			[Token(Token = "0x600119A")]
			[Address(RVA = "0x131EF80", Offset = "0x131EF80", VA = "0x131EF80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B8CC", Offset = "0x3B8CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600119B")]
			[Address(RVA = "0x131EF88", Offset = "0x131EF88", VA = "0x131EF88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B8DC", Offset = "0x3B8DC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000227")]
		public float deltaTime
		{
			[Token(Token = "0x600119C")]
			[Address(RVA = "0x131EF90", Offset = "0x131EF90", VA = "0x131EF90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B8EC", Offset = "0x3B8EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600119D")]
			[Address(RVA = "0x131EF98", Offset = "0x131EF98", VA = "0x131EF98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B8FC", Offset = "0x3B8FC")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000228")]
		public float fixedDeltaTime
		{
			[Token(Token = "0x600119E")]
			[Address(RVA = "0x131EFA0", Offset = "0x131EFA0", VA = "0x131EFA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B90C", Offset = "0x3B90C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600119F")]
			[Address(RVA = "0x131EFA8", Offset = "0x131EFA8", VA = "0x131EFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B91C", Offset = "0x3B91C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000229")]
		public float smoothDeltaTime
		{
			[Token(Token = "0x60011A0")]
			[Address(RVA = "0x131EFB0", Offset = "0x131EFB0", VA = "0x131EFB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700022A")]
		public float time
		{
			[Token(Token = "0x60011A1")]
			[Address(RVA = "0x131F024", Offset = "0x131F024", VA = "0x131F024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B92C", Offset = "0x3B92C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011A2")]
			[Address(RVA = "0x131F02C", Offset = "0x131F02C", VA = "0x131F02C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B93C", Offset = "0x3B93C")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x1700022B")]
		public float unscaledTime
		{
			[Token(Token = "0x60011A3")]
			[Address(RVA = "0x131F034", Offset = "0x131F034", VA = "0x131F034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B94C", Offset = "0x3B94C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011A4")]
			[Address(RVA = "0x131F03C", Offset = "0x131F03C", VA = "0x131F03C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B95C", Offset = "0x3B95C")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700022C")]
		public TimeState state
		{
			[Token(Token = "0x60011A5")]
			[Address(RVA = "0x131F044", Offset = "0x131F044", VA = "0x131F044")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700022D")]
		public bool rewindable
		{
			[Token(Token = "0x60011C8")]
			[Address(RVA = "0x1320600", Offset = "0x1320600", VA = "0x1320600")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011C9")]
			[Address(RVA = "0x1320608", Offset = "0x1320608", VA = "0x1320608")]
			set
			{
			}
		}

		[Token(Token = "0x1700022E")]
		public float recordingDuration
		{
			[Token(Token = "0x60011CA")]
			[Address(RVA = "0x1320624", Offset = "0x1320624", VA = "0x1320624")]
			get
			{
				return default;
			}
			[Token(Token = "0x60011CB")]
			[Address(RVA = "0x132062C", Offset = "0x132062C", VA = "0x132062C")]
			set
			{
			}
		}

		[Token(Token = "0x1700022F")]
		public float availableRewindDuration
		{
			[Token(Token = "0x60011CC")]
			[Address(RVA = "0x1320740", Offset = "0x1320740", VA = "0x1320740")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600118F")]
		[Address(RVA = "0x131DE44", Offset = "0x131DE44", VA = "0x131DE44")]
		public Timeline()
		{
		}

		[Token(Token = "0x6001190")]
		[Address(RVA = "0x131E0CC", Offset = "0x131E0CC", VA = "0x131E0CC", Slot = "6")]
		protected override void OnStartOrReEnable()
		{
		}

		[Token(Token = "0x6001191")]
		[Address(RVA = "0x131E3A4", Offset = "0x131E3A4", VA = "0x131E3A4", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6001192")]
		[Address(RVA = "0x131EC38", Offset = "0x131EC38", VA = "0x131EC38", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6001193")]
		[Address(RVA = "0x131ED84", Offset = "0x131ED84", VA = "0x131ED84", Slot = "11")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x131F084", Offset = "0x131F084", VA = "0x131F084", Slot = "12")]
		protected virtual Clock FindClock()
		{
			return null;
		}

		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x131F344", Offset = "0x131F344", VA = "0x131F344", Slot = "13")]
		public virtual void ReleaseFrom(IAreaClock areaClock)
		{
		}

		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x131F404", Offset = "0x131F404", VA = "0x131F404", Slot = "14")]
		public virtual void ReleaseFromAll()
		{
		}

		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x131F654", Offset = "0x131F654", VA = "0x131F654", Slot = "15")]
		protected virtual void TriggerEvents()
		{
		}

		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x131F8B8", Offset = "0x131F8B8", VA = "0x131F8B8", Slot = "16")]
		protected virtual void RecordSmoothing()
		{
		}

		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x131EA64", Offset = "0x131EA64", VA = "0x131EA64")]
		protected void TriggerForwardOccurrences()
		{
		}

		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x131EB2C", Offset = "0x131EB2C", VA = "0x131EB2C")]
		protected void TriggerBackwardOccurrences()
		{
		}

		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x131FBBC", Offset = "0x131FBBC", VA = "0x131FBBC")]
		protected Occurrence OccurrenceAfter(float time, params Occurrence[] ignored)
		{
			return null;
		}

		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x131F9AC", Offset = "0x131F9AC", VA = "0x131F9AC")]
		protected Occurrence OccurrenceAfter(float time, IEnumerable<Occurrence> ignored)
		{
			return null;
		}

		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x131FBC0", Offset = "0x131FBC0", VA = "0x131FBC0")]
		protected Occurrence OccurrenceBefore(float time, params Occurrence[] ignored)
		{
			return null;
		}

		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x131FAB4", Offset = "0x131FAB4", VA = "0x131FAB4")]
		protected Occurrence OccurrenceBefore(float time, IEnumerable<Occurrence> ignored)
		{
			return null;
		}

		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x131FBC4", Offset = "0x131FBC4", VA = "0x131FBC4", Slot = "17")]
		protected virtual void PlaceOccurence(Occurrence occurrence, float time)
		{
		}

		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x131FC84", Offset = "0x131FC84", VA = "0x131FC84", Slot = "18")]
		public virtual Occurrence Schedule(float time, bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x131FD28", Offset = "0x131FD28", VA = "0x131FD28")]
		public Occurrence Do(bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		[Token(Token = "0x60011B4")]
		[Address(RVA = "0x131FD3C", Offset = "0x131FD3C", VA = "0x131FD3C")]
		public Occurrence Plan(float delay, bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x131FDB0", Offset = "0x131FDB0", VA = "0x131FDB0")]
		public Occurrence Memory(float delay, bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		[Token(Token = "0x60011B6")]
		public Occurrence Schedule<T>(float time, bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		[Token(Token = "0x60011B7")]
		public Occurrence Do<T>(bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		[Token(Token = "0x60011B8")]
		public Occurrence Plan<T>(float delay, bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		[Token(Token = "0x60011B9")]
		public Occurrence Memory<T>(float delay, bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x131FE24", Offset = "0x131FE24", VA = "0x131FE24")]
		public Occurrence Schedule(float time, bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x131FEC8", Offset = "0x131FEC8", VA = "0x131FEC8")]
		public Occurrence Do(bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x131FF60", Offset = "0x131FF60", VA = "0x131FF60")]
		public Occurrence Plan(float delay, bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		[Token(Token = "0x60011BD")]
		[Address(RVA = "0x131FFF8", Offset = "0x131FFF8", VA = "0x131FFF8")]
		public Occurrence Memory(float delay, bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		[Token(Token = "0x60011BE")]
		[Address(RVA = "0x1320090", Offset = "0x1320090", VA = "0x1320090")]
		public Occurrence Schedule(float time, ForwardAction forward)
		{
			return null;
		}

		[Token(Token = "0x60011BF")]
		[Address(RVA = "0x1320120", Offset = "0x1320120", VA = "0x1320120")]
		public Occurrence Plan(float delay, ForwardAction forward)
		{
			return null;
		}

		[Token(Token = "0x60011C0")]
		[Address(RVA = "0x13201A4", Offset = "0x13201A4", VA = "0x13201A4")]
		public Occurrence Memory(float delay, ForwardAction forward)
		{
			return null;
		}

		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x1320228", Offset = "0x1320228", VA = "0x1320228")]
		public void Cancel(Occurrence occurrence)
		{
		}

		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x13203F4", Offset = "0x13203F4", VA = "0x13203F4")]
		public bool TryCancel(Occurrence occurrence)
		{
			return default;
		}

		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x1320474", Offset = "0x1320474", VA = "0x1320474")]
		public void Reschedule(Occurrence occurrence, float time)
		{
		}

		[Token(Token = "0x60011C4")]
		[Address(RVA = "0x1320498", Offset = "0x1320498", VA = "0x1320498")]
		public void Postpone(Occurrence occurrence, float delay)
		{
		}

		[Token(Token = "0x60011C5")]
		[Address(RVA = "0x13204C4", Offset = "0x13204C4", VA = "0x13204C4")]
		public void Prepone(Occurrence occurrence, float delay)
		{
		}

		[Token(Token = "0x60011C6")]
		[Address(RVA = "0x13204F0", Offset = "0x13204F0", VA = "0x13204F0")]
		public Coroutine WaitForSeconds(float seconds)
		{
			return null;
		}

		[Token(Token = "0x60011C7")]
		[Address(RVA = "0x132057C", Offset = "0x132057C", VA = "0x132057C")]
		protected IEnumerator WaitingForSeconds(float seconds)
		{
			return null;
		}
	}
}
