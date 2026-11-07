using UnityEngine;
using UnityEngine.AI;

namespace Chronos
{
	public class RigidbodyTimeline3D : RigidbodyTimeline<Rigidbody, RigidbodyTimeline3D.Snapshot>
	{
		public struct Snapshot
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 velocity;

			public Vector3 angularVelocity;

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

		public bool isKinematic { get; set; }

		protected override bool isManual => false;

		public bool useGravity { get; set; }

		public Vector3 velocity
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector3 angularVelocity
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public RigidbodyTimeline3D(Timeline timeline, Rigidbody component)
			: base((Timeline)null, (Rigidbody)null)
		{
		}

		public override void CopyProperties(Rigidbody source)
		{
		}

		public override void FixedUpdate()
		{
		}

		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return default;
		}

		private NavMeshAgent GetNavMeshAgentOverride()
		{
			return null;
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

		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}

		public void AddRelativeTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}
	}
}
