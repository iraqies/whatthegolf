using UnityEngine;

namespace Chronos
{
	public abstract class RigidbodyTimeline<TComponent, TSnapshot> : RecorderTimeline<TComponent, TSnapshot> where TComponent : Component
	{
		protected float lastPositiveTimeScale;

		protected TSnapshot zeroSnapshot;

		protected float zeroTime;

		protected Vector3 zeroDestination;

		protected abstract bool bodyIsManual { get; set; }

		protected abstract float bodyMass { set; }

		protected abstract Vector3 bodyVelocity { get; set; }

		protected abstract Vector3 bodyAngularVelocity { get; set; }

		protected abstract float bodyDrag { get; set; }

		protected abstract float bodyAngularDrag { get; set; }

		protected abstract bool isManual { get; }

		public float mass
		{
			set
			{
			}
		}

		public float drag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float angularDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RigidbodyTimeline(Timeline timeline, TComponent component)
			: base(timeline, component)
		{
		}

		public override void Update()
		{
		}

		public override void Reset()
		{
		}

		public override void ModifySnapshots(SnapshotModifier modifier)
		{
		}

		protected abstract void WakeUp();

		protected virtual Vector2 AdjustForce(Vector2 force)
		{
			return default;
		}

		protected virtual Vector3 AdjustForce(Vector3 force)
		{
			return default;
		}

		protected bool AssertForwardProperty(string property, Severity severity)
		{
			return false;
		}

		protected bool AssertForwardForce(Severity severity)
		{
			return false;
		}
	}
}
