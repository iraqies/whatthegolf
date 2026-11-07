using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField]
		private Transform followOverride;

		[SerializeField]
		private Vector3 rotation;

		[SerializeField]
		private float distance;

		[SerializeField]
		private float leftSideTrackPadding;

		[SerializeField]
		private float rightSideTrackPadding;

		[SerializeField]
		private float upperTrackPadding;

		[SerializeField]
		private float lowerTrackPadding;

		[SerializeField]
		private bool lockVerticalAxis;

		[SerializeField]
		private bool lockHorizontalAxis;

		[SerializeField]
		private bool shouldCenterOnStart;

		[SerializeField]
		private float desktopOrthographicSize;

		[SerializeField]
		private Vector3 desktopRotation;

		private Transform follow;

		private Vector2 adjustedScreenPosition;

		public override void Init()
		{
		}

		public override void PreUpdate()
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

		public void SetFollowTarget(Transform target)
		{
		}

		public Transform GetFollowTarget()
		{
			return null;
		}
	}
}
