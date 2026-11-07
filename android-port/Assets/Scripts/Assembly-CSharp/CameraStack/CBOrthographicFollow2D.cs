using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow2D : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField]
		private Vector3 rotation;

		[SerializeField]
		private float distance;

		[SerializeField]
		public float sideTrackPadding;

		[SerializeField]
		public float upperTrackPadding;

		[SerializeField]
		public float lowerTrackPadding;

		[SerializeField]
		public Vector2 offSetAxis;

		[SerializeField]
		public bool lockVerticalAxis;

		[SerializeField]
		public bool lockHorizontalAxis;

		[SerializeField]
		private Transform follow;

		[SerializeField]
		private bool autoAdjustOrthographicSize;

		[SerializeField]
		public float tweenTime;

		[SerializeField]
		private Vector3 desktopRotation;

		public Vector3 lookAhead;

		public bool isInPipeIntro;

		private Vector3 velocity;

		private Vector3 currentPosition;

		private Vector2 adjustedScreenPosition;

		public float lookAheadDistance;

		public override void Init()
		{
		}

		public void SetFollowTarget(Transform newTarget)
		{
		}

		public void SetPadding(float side, float upper, float lower)
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
