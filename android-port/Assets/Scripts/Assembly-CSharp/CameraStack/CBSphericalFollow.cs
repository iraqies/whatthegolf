using UnityEngine;

namespace CameraStack
{
	public class CBSphericalFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField]
		protected Transform followTarget;

		[SerializeField]
		protected Transform ball;

		[SerializeField]
		protected float distance;

		[SerializeField]
		protected Vector3 offset;

		public override Quaternion CalculateRotation()
		{
			return default;
		}

		public Transform GetFollowTarget()
		{
			return null;
		}

		public void SetFollowTarget(Transform target)
		{
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}
	}
}
