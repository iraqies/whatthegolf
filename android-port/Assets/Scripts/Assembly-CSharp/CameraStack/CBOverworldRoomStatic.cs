using UnityEngine;

namespace CameraStack
{
	public class CBOverworldRoomStatic : CameraBehaviorOrthographic
	{
		[SerializeField]
		private Vector3 rotation;

		[SerializeField]
		private float smoothTime;

		[SerializeField]
		private float distance;

		[SerializeField]
		private bool lockVerticalAxis;

		[SerializeField]
		private bool lockHorizontalAxis;

		[SerializeField]
		private Transform follow;

		private Vector3 camVelocity;

		[SerializeField]
		private Vector3 desktopRotation;

		private Vector2 adjustedScreenPosition;

		public override void Init()
		{
		}

		public void SetFollowTarget(Transform newTarget)
		{
		}

		public void SetOrthoSize(float val)
		{
		}

		public float GetOrthoSize()
		{
			return 0f;
		}

		public Transform GetFollowTarget()
		{
			return null;
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
	}
}
