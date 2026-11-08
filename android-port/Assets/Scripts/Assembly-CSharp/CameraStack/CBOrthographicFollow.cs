using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField] private Transform followOverride;
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 15f;
		[SerializeField] private float leftSideTrackPadding;
		[SerializeField] private float rightSideTrackPadding;
		[SerializeField] private float upperTrackPadding;
		[SerializeField] private float lowerTrackPadding;
		[SerializeField] private bool lockVerticalAxis;
		[SerializeField] private bool lockHorizontalAxis;
		[SerializeField] private bool shouldCenterOnStart;
		[SerializeField] private float desktopOrthographicSize;
		[SerializeField] private Vector3 desktopRotation;
		private Transform follow;
		private Vector2 adjustedScreenPosition;

		public override void Init()
		{
			base.Init();
			if (followOverride != null) follow = followOverride;
		}

		public override void PreUpdate() { }
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			Vector3 desired = t.position - (rot * Vector3.forward) * dist;
			if (lockHorizontalAxis) desired.x = transform.position.x;
			if (lockVerticalAxis) desired.y = transform.position.y;
			return Vector3.Lerp(transform.position, desired, Time.unscaledDeltaTime * 8f);
		}

		public void SetFollowTarget(Transform target) => follow = target;

		public Transform GetFollowTarget()
		{
			if (follow != null) return follow;
			if (followOverride != null) return followOverride;
			var b = Ball;
			return b != null ? b.transform : null;
		}
	}
}
