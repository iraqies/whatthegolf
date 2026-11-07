using UnityEngine;

namespace CameraStack
{
	public class CBFollowOrbit : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField]
		protected Transform orbitTarget;

		[SerializeField]
		protected Transform followTarget;

		[SerializeField]
		private float distance;

		[SerializeField]
		private Vector3 positionOffset;

		public Transform FollowTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Init()
		{
		}

		public override Quaternion CalculateRotation()
		{
			return default;
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		public void SetOrbitTarget(Transform newOrbitTarget)
		{
		}

		public void SetFollowTarget(Transform newFollowTarget)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public Transform GetFollowTarget()
		{
			return null;
		}
	}
}
