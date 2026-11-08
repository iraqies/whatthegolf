using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow2D : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 15f;
		[SerializeField] public float sideTrackPadding = 0.2f;
		[SerializeField] public float upperTrackPadding = 0.2f;
		[SerializeField] public float lowerTrackPadding = 0.2f;
		[SerializeField] public Vector2 offSetAxis;
		[SerializeField] public bool lockVerticalAxis;
		[SerializeField] public bool lockHorizontalAxis;
		[SerializeField] private Transform follow;
		[SerializeField] private bool autoAdjustOrthographicSize;
		[SerializeField] public float tweenTime = 0.15f;
		[SerializeField] private Vector3 desktopRotation;
		public Vector3 lookAhead;
		public bool isInPipeIntro;
		private Vector3 velocity;
		private Vector3 currentPosition;
		private Vector2 adjustedScreenPosition;
		public float lookAheadDistance;
		private bool _hasPos;

		public override void Init()
		{
			base.Init();
			currentPosition = transform.position;
			_hasPos = true;
		}

		public void SetFollowTarget(Transform newTarget) => follow = newTarget;

		public void SetPadding(float side, float upper, float lower)
		{
			sideTrackPadding = side;
			upperTrackPadding = upper;
			lowerTrackPadding = lower;
		}

		public void SetOrthoSize(float val)
		{
			if (val <= 0.01f) return;
			orthographicSize = val;
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null && c.orthographic)
						c.orthographicSize = orthographicSize;
				}
			}
		}

		public float GetOrthoSize() => orthographicSize > 0.01f ? orthographicSize : 8f;

		public Transform GetFollowTarget()
		{
			if (follow != null) return follow;
			if (OverworldManager2d.HasInstance)
			{
				var ow = OverworldManager2d.Instance;
				if (ow.cameraTarget != null) return ow.cameraTarget;
				if (ow.ball != null) return ow.ball.transform;
			}
			var b = Ball;
			return b != null ? b.transform : null;
		}

		public override void PreUpdate() { }

		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			Vector3 targetPos = t.position + new Vector3(offSetAxis.x, offSetAxis.y, 0f) + lookAhead;
			if (lockHorizontalAxis && _hasPos) targetPos.x = currentPosition.x;
			if (lockVerticalAxis && _hasPos) targetPos.y = currentPosition.y;
			Vector3 desired = targetPos - (rot * Vector3.forward) * dist;
			if (!_hasPos)
			{
				currentPosition = desired;
				_hasPos = true;
			}
			else
			{
				float st = Mathf.Max(0.05f, tweenTime);
				currentPosition = Vector3.SmoothDamp(currentPosition, desired, ref velocity, st, Mathf.Infinity, Time.unscaledDeltaTime);
			}
			return currentPosition;
		}
	}
}
