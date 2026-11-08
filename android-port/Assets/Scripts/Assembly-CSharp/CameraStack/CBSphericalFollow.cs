using UnityEngine;

namespace CameraStack
{
	public class CBSphericalFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField] protected Transform followTarget;
		[SerializeField] protected Transform ball;
		[SerializeField] protected float distance = 15f;
		[SerializeField] protected Vector3 offset;

		public override Quaternion CalculateRotation()
		{
			Transform t = GetFollowTarget();
			if (t != null && followTarget != null && t != followTarget)
			{
				Vector3 up = (t.position - followTarget.position).normalized;
				if (up.sqrMagnitude > 0.001f)
					return Quaternion.LookRotation(-up, Vector3.forward);
			}
			return transform.rotation;
		}

		public Transform GetFollowTarget() => ball != null ? ball : (Ball != null ? Ball.transform : followTarget);
		public void SetFollowTarget(Transform target) => ball = target;

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			return t.position + offset - (rot * Vector3.forward) * dist;
		}
	}
}
