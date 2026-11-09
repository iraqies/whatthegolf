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
			get => component != null && component.isKinematic;
			set { if (component != null) component.isKinematic = value; }
		}

		protected override float bodyMass
		{
			set { if (component != null) component.mass = value; }
		}

		protected override Vector3 bodyVelocity
		{
			get => component != null ? component.velocity : Vector3.zero;
			set { if (component != null) component.velocity = value; }
		}

		protected override Vector3 bodyAngularVelocity
		{
			get => component != null ? component.angularVelocity : Vector3.zero;
			set { if (component != null) component.angularVelocity = value; }
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

		public bool isKinematic
		{
			get => component != null && component.isKinematic;
			set { if (component != null) component.isKinematic = value; }
		}

		protected override bool isManual => isKinematic;

		public bool useGravity
		{
			get => component != null && component.useGravity;
			set { if (component != null) component.useGravity = value; }
		}

		public Vector3 velocity
		{
			get => component != null ? component.velocity : Vector3.zero;
			set { if (component != null) component.velocity = value; }
		}

		public Vector3 angularVelocity
		{
			get => component != null ? component.angularVelocity : Vector3.zero;
			set { if (component != null) component.angularVelocity = value; }
		}

		public RigidbodyTimeline3D(Timeline timeline, Rigidbody component)
			: base(timeline, component)
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
			if (component != null) component.WakeUp();
		}

		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
			if (component != null) component.AddForce(force, mode);
		}

		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
			if (component != null) component.AddForceAtPosition(force, position, mode);
		}

		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
			if (component != null) component.AddTorque(torque, mode);
		}

		public void AddRelativeTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
			if (component != null) component.AddRelativeTorque(torque, mode);
		}
	}
}
