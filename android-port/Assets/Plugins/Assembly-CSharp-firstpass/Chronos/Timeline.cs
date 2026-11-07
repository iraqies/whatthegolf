using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chronos
{
	[DisallowMultipleComponent]
	public class Timeline : TimelineEffector
	{
		protected internal const float DefaultRecordingDuration = 30f;

		protected internal float lastTimeScale;

		protected Queue<float> previousDeltaTimes;

		protected List<Occurrence> occurrences;

		protected HashSet<Occurrence> handledOccurrences;

		protected Occurrence nextForwardOccurrence;

		protected Occurrence nextBackwardOccurrence;

		protected internal List<IAreaClock> areaClocks;

		protected internal List<TimelineChild> children;

		[SerializeField]
		private TimelineMode _mode;

		[SerializeField]
		private string _globalClockKey;

		private Clock _clock;

		public static int smoothingDeltas;

		[SerializeField]
		private bool _rewindable;

		[SerializeField]
		private float _recordingDuration;

		protected override Timeline timeline => null;

		public TimelineMode mode
		{
			get
			{
				return TimelineMode.Local;
			}
			set
			{
			}
		}

		public string globalClockKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Clock clock => null;

		public float timeScale { get; protected set; }

		public float deltaTime { get; protected set; }

		public float fixedDeltaTime { get; protected set; }

		public float smoothDeltaTime => 0f;

		public float time { get; protected internal set; }

		public float unscaledTime { get; protected set; }

		public TimeState state => TimeState.Accelerated;

		public bool rewindable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float recordingDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float availableRewindDuration => 0f;

		protected override void OnStartOrReEnable()
		{
		}

		protected override void Update()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void Reset()
		{
		}

		protected virtual Clock FindClock()
		{
			return null;
		}

		public virtual void ReleaseFrom(IAreaClock areaClock)
		{
		}

		public virtual void ReleaseFromAll()
		{
		}

		protected virtual void TriggerEvents()
		{
		}

		protected virtual void RecordSmoothing()
		{
		}

		protected void TriggerForwardOccurrences()
		{
		}

		protected void TriggerBackwardOccurrences()
		{
		}

		protected Occurrence OccurrenceAfter(float time, params Occurrence[] ignored)
		{
			return null;
		}

		protected Occurrence OccurrenceAfter(float time, IEnumerable<Occurrence> ignored)
		{
			return null;
		}

		protected Occurrence OccurrenceBefore(float time, params Occurrence[] ignored)
		{
			return null;
		}

		protected Occurrence OccurrenceBefore(float time, IEnumerable<Occurrence> ignored)
		{
			return null;
		}

		protected virtual void PlaceOccurence(Occurrence occurrence, float time)
		{
		}

		public virtual Occurrence Schedule(float time, bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		public Occurrence Do(bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		public Occurrence Plan(float delay, bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		public Occurrence Memory(float delay, bool repeatable, Occurrence occurrence)
		{
			return null;
		}

		public Occurrence Schedule<T>(float time, bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		public Occurrence Do<T>(bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		public Occurrence Plan<T>(float delay, bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		public Occurrence Memory<T>(float delay, bool repeatable, ForwardFunc<T> forward, BackwardFunc<T> backward)
		{
			return null;
		}

		public Occurrence Schedule(float time, bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		public Occurrence Do(bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		public Occurrence Plan(float delay, bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		public Occurrence Memory(float delay, bool repeatable, ForwardAction forward, BackwardAction backward)
		{
			return null;
		}

		public Occurrence Schedule(float time, ForwardAction forward)
		{
			return null;
		}

		public Occurrence Plan(float delay, ForwardAction forward)
		{
			return null;
		}

		public Occurrence Memory(float delay, ForwardAction forward)
		{
			return null;
		}

		public void Cancel(Occurrence occurrence)
		{
		}

		public bool TryCancel(Occurrence occurrence)
		{
			return false;
		}

		public void Reschedule(Occurrence occurrence, float time)
		{
		}

		public void Postpone(Occurrence occurrence, float delay)
		{
		}

		public void Prepone(Occurrence occurrence, float delay)
		{
		}

		public Coroutine WaitForSeconds(float seconds)
		{
			return null;
		}

		protected IEnumerator WaitingForSeconds(float seconds)
		{
			return null;
		}
	}
}
