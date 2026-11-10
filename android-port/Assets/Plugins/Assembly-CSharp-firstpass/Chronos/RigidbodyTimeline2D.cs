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
			get => component != null && component.bodyType != RigidbodyType2D.Dynamic;
			set { if (component != null) component.isKinematic = value; }
		}

		protected override float bodyMass
		{
			set { if (component != null) component.mass = value; }
		}

		protected override Vector3 bodyVelocity
		{
			get => component != null ? (Vector3)component.velocity : Vector3.zero;
			set { if (component != null) component.velocity = value; }
		}

		protected override Vector3 bodyAngularVelocity
		{
			get => component != null ? new Vector3(0f, 0f, component.angularVelocity) : Vector3.zero;
			set { if (component != null) component.angularVelocity = value.z; }
		}

		protected override float bodyDrag
		{
			get => component != null ? component.drag : 0f;
			set { if (component != null) component.drag = value; }
		}

		protected override float bodyAngularDrag
		{
			get => component != null ? component.angularDrag : 0f;
			set { if (component != null) component.angularDrag = value; }
		}

		public RigidbodyType2D bodyType
		{
			get => component != null ? component.bodyType : RigidbodyType2D.Dynamic;
			set { if (component != null) component.bodyType = value; }
		}

		protected override bool isManual => bodyIsManual;

		public float gravityScale
		{
			get => component != null ? component.gravityScale : 1f;
			set { if (component != null) component.gravityScale = value; }
		}

		public Vector2 velocity
		{
			get => component != null ? component.velocity : Vector2.zero;
			set { if (component != null) component.velocity = value; }
		}

		public float angularVelocity
		{
			get => component != null ? component.angularVelocity : 0f;
			set { if (component != null) component.angularVelocity = value; }
		}

		public RigidbodyTimeline2D(Timeline timeline, Rigidbody2D component)
			: base(timeline, component)
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
			if (component != null) component.WakeUp();
		}

		public void AddForce(Vector2 force, ForceMode2D mode = ForceMode2D.Force)
		{
			if (component != null) component.AddForce(force, mode);
		}
	}
}
