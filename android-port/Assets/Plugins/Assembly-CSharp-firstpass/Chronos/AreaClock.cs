using System.Collections.Generic;
using UnityEngine;

namespace Chronos
{
	public abstract class AreaClock<TCollider, TVector> : Clock, IAreaClock
	{
		protected Dictionary<Timeline, Vector3> within;

		protected HashSet<Timeline> outOfBounds;

		protected TCollider collider;

		[SerializeField]
		private AreaClockMode _mode;

		[SerializeField]
		private AnimationCurve _curve;

		[SerializeField]
		private TVector _center;

		[SerializeField]
		private float _padding;

		[SerializeField]
		private ClockBlend _innerBlend;

		public AreaClockMode mode
		{
			get
			{
				return AreaClockMode.Instant;
			}
			set
			{
			}
		}

		public AnimationCurve curve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TVector center
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float padding
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ClockBlend innerBlend
		{
			get
			{
				return ClockBlend.Multiplicative;
			}
			set
			{
			}
		}

		public AreaClock()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void Capture(Timeline timeline, Vector3 entry)
		{
		}

		public virtual void Release(Timeline timeline)
		{
		}

		public virtual void ReleaseAll()
		{
		}

		float IAreaClock.TimeScale(Timeline timeline)
		{
			return 0f;
		}

		protected virtual float DistanceFromEntryTimeScale(Vector3 entry, Vector3 position)
		{
			return 0f;
		}

		protected abstract float PointToEdgeTimeScale(Vector3 position);

		public abstract bool ContainsPoint(Vector3 point);

		public virtual void CacheComponents()
		{
		}
	}
}
