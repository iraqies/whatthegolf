using System.Collections.Generic;
using UnityEngine;

namespace Chronos
{
	public abstract class RecorderTimeline<TComponent, TSnapshot> : ComponentTimeline<TComponent>, IRecorder where TComponent : Component
	{
		public delegate TSnapshot SnapshotModifier(TSnapshot snapshot, float time);

		protected List<TSnapshot> snapshots;

		protected List<float> times;

		protected int capacity;

		protected float recordingTimer;

		protected float lastTimeScale;

		protected bool canRewind;

		protected TSnapshot laterSnapshot;

		protected float laterTime;

		protected TSnapshot earlierSnapshot;

		protected float earlierTime;

		protected TSnapshot interpolatedSnapshot;

		public bool exhaustedRewind => false;

		public float availableRewindDuration => 0f;

		public RecorderTimeline(Timeline timeline, TComponent component)
			: base((Timeline)null, (TComponent)null)
		{
		}

		public override void OnStartOrReEnable()
		{
		}

		public override void Update()
		{
		}

		protected void Progress()
		{
		}

		public void Record()
		{
		}

		protected void Rewind()
		{
		}

		protected abstract TSnapshot LerpSnapshots(TSnapshot from, TSnapshot to, float t);

		protected abstract TSnapshot CopySnapshot();

		protected abstract void ApplySnapshot(TSnapshot snapshot);

		protected bool TryFindEarlierSnapshot(bool pop)
		{
			return false;
		}

		public override void Reset()
		{
		}

		public virtual void ModifySnapshots(SnapshotModifier modifier)
		{
		}

		internal static int EstimateMemoryUsage(float duration, float interval)
		{
			return 0;
		}

		public int EstimateMemoryUsage()
		{
			return 0;
		}
	}
}
