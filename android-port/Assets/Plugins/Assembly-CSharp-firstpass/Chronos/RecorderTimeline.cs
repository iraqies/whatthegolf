using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002A4")]
	public abstract class RecorderTimeline<TComponent, TSnapshot> : ComponentTimeline<TComponent>, IRecorder where TComponent : Component
	{
		[Token(Token = "0x20002A5")]
		public delegate TSnapshot SnapshotModifier(TSnapshot snapshot, float time);

		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x0")]
		protected List<TSnapshot> snapshots;

		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x0")]
		protected List<float> times;

		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x0")]
		protected int capacity;

		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x0")]
		protected float recordingTimer;

		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x0")]
		protected float lastTimeScale;

		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x0")]
		protected bool canRewind;

		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x0")]
		protected TSnapshot laterSnapshot;

		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x0")]
		protected float laterTime;

		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x0")]
		protected TSnapshot earlierSnapshot;

		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x0")]
		protected float earlierTime;

		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x0")]
		protected TSnapshot interpolatedSnapshot;

		[Token(Token = "0x1700021C")]
		public bool exhaustedRewind
		{
			[Token(Token = "0x6001171")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700021D")]
		public float availableRewindDuration
		{
			[Token(Token = "0x6001172")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600116E")]
		public RecorderTimeline(Timeline timeline, TComponent component)
		{
		}

		[Token(Token = "0x600116F")]
		public override void OnStartOrReEnable()
		{
		}

		[Token(Token = "0x6001170")]
		public override void Update()
		{
		}

		[Token(Token = "0x6001173")]
		protected void Progress()
		{
		}

		[Token(Token = "0x6001174")]
		public void Record()
		{
		}

		[Token(Token = "0x6001175")]
		protected void Rewind()
		{
		}

		[Token(Token = "0x6001176")]
		protected abstract TSnapshot LerpSnapshots(TSnapshot from, TSnapshot to, float t);

		[Token(Token = "0x6001177")]
		protected abstract TSnapshot CopySnapshot();

		[Token(Token = "0x6001178")]
		protected abstract void ApplySnapshot(TSnapshot snapshot);

		[Token(Token = "0x6001179")]
		protected bool TryFindEarlierSnapshot(bool pop)
		{
			return default;
		}

		[Token(Token = "0x600117A")]
		public override void Reset()
		{
		}

		[Token(Token = "0x600117B")]
		public virtual void ModifySnapshots(SnapshotModifier modifier)
		{
		}

		[Token(Token = "0x600117C")]
		internal static int EstimateMemoryUsage(float duration, float interval)
		{
			return default;
		}

		[Token(Token = "0x600117D")]
		public int EstimateMemoryUsage()
		{
			return default;
		}
	}
}
