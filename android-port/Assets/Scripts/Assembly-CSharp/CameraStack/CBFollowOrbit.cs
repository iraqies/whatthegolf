using UnityEngine;

namespace CameraStack
{
	public class CBFollowOrbit : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] private float distance = 14f;
		[SerializeField] private Vector3 positionOffset;

		public Transform FollowTarget
		{
			get => GetFollowTarget();
			set => followTarget = value;
		}

		public override void Init() => base.Init();

		public override Quaternion CalculateRotation()
		{
			Transform f = GetFollowTarget();
			if (f != null && orbitTarget != null)
			{
				Vector3 dir = (orbitTarget.position - f.position).normalized;
				if (dir.sqrMagnitude > 0.001f)
					return Quaternion.LookRotation(dir, Vector3.up);
			}
			return transform.rotation;
		}

		protected override Vector3 CalculatePosition()
		{
			Transform f = GetFollowTarget();
			if (f == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 14f;
			return f.position + positionOffset - (rot * Vector3.forward) * dist;
		}

		public void SetOrbitTarget(Transform newOrbitTarget) => orbitTarget = newOrbitTarget;
		public void SetFollowTarget(Transform newFollowTarget) => followTarget = newFollowTarget;
		public override string ToString() => name;

		public Transform GetFollowTarget()
		{
			if (followTarget != null) return followTarget;
			var b = Ball;
			return b != null ? b.transform : orbitTarget;
		}
	}
}
