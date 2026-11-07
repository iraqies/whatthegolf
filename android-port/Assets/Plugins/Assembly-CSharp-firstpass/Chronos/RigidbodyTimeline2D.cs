using UnityEngine;

namespace Chronos
{
	public class RigidbodyTimeline2D : RigidbodyTimeline<Rigidbody2D, RigidbodyTimeline2D.Snapshot>
	{
		public struct Snapshot
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector2 velocity;

			public float angularVelocity;

			public float drag;

			public float angularDrag;

			public float lastPositiveTimeScale;

			public static Snapshot Lerp(Snapshot from, Snapshot to, float t)
			{
				return default;
			}
		}

		protected override bool bodyIsManual
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override float bodyMass
		{
			set
			{
			}
		}

		protected override Vector3 bodyVelocity
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		protected override Vector3 bodyAngularVelocity
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		protected override float bodyDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override float bodyAngularDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RigidbodyType2D bodyType { get; set; }

		protected override bool isManual => false;

		public float gravityScale { get; set; }

		public Vector2 velocity
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float angularVelocity
		{
			set
			{
			}
		}

		public RigidbodyTimeline2D(Timeline timeline, Rigidbody2D component)
			: base((Timeline)null, (Rigidbody2D)null)
		{
		}

		public override void CopyProperties(Rigidbody2D source)
		{
		}

		public override void FixedUpdate()
		{
		}

		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return default;
		}

		protected override Snapshot CopySnapshot()
		{
			return default;
		}

		protected override void ApplySnapshot(Snapshot snapshot)
		{
		}

		protected override void WakeUp()
		{
		}

		public void AddForce(Vector2 force, ForceMode2D mode = ForceMode2D.Force)
		{
		}
	}
}
