using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow2D : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 100f;
		[SerializeField] public float sideTrackPadding = 0.25f;
		[SerializeField] public float upperTrackPadding = 0.25f;
		[SerializeField] public float lowerTrackPadding = 0.25f;
		[SerializeField] public Vector2 offSetAxis;
		[SerializeField] public bool lockVerticalAxis;
		[SerializeField] public bool lockHorizontalAxis;
		[SerializeField] private Transform follow;
		[SerializeField] private bool autoAdjustOrthographicSize = true;
		[SerializeField] public float tweenTime;
		[SerializeField] private Vector3 desktopRotation;
		public Vector3 lookAhead;
		public bool isInPipeIntro;
		private Vector3 velocity;
		private Vector3 currentPosition;
		private Vector2 adjustedScreenPosition;
		public float lookAheadDistance;

		public override void Init()
		{
			base.Init();
			if (follow == null && Ball != null)
				follow = Ball.transform;
			if (follow != null)
				transform.position = CalculatePosition();
			var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useRotated = currentCfg == null || currentCfg.useRotatedOverworldAndCameraInLevels;
			if (!useRotated)
				desktopRotation = rotation;
			currentPosition = transform.position;
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
			orthographicSize = val;
			if (Cameras != null)
			{
				for (int i = 0; i < Cameras.Length; i++)
				{
					if (Cameras[i] != null)
						Cameras[i].orthographicSize = orthographicSize;
				}
			}
		}

		public float GetOrthoSize() => orthographicSize;

		public Transform GetFollowTarget() => follow;

		public override void PreUpdate() { }

		public override Quaternion CalculateRotation()
		{
			var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useRotated = currentCfg == null || currentCfg.useRotatedOverworldAndCameraInLevels;
			return Quaternion.Euler(useRotated ? rotation : desktopRotation);
		}

		protected override Vector3 CalculatePosition()
		{
			if (Cameras == null || Cameras.Length == 0 || Cameras[0] == null || isInPipeIntro)
				return transform.position;
			if (follow == null && Ball != null)
				follow = Ball.transform;
			if (follow == null)
				return transform.position;

			Camera cam = Cameras[0];
			Vector3 clampedLook = Vector3.ClampMagnitude(lookAhead, 5f) * lookAheadDistance;
			Vector3 focusWorld = follow.position - clampedLook;
			Vector3 vp = cam.WorldToViewportPoint(focusWorld);
			adjustedScreenPosition = new Vector2(vp.x, vp.y);

			if (!lockHorizontalAxis)
			{
				if (adjustedScreenPosition.x < sideTrackPadding)
					adjustedScreenPosition.x = sideTrackPadding;
				if (adjustedScreenPosition.x > 1f - sideTrackPadding)
					adjustedScreenPosition.x = 1f - sideTrackPadding;
			}
			if (!lockVerticalAxis)
			{
				if (adjustedScreenPosition.y < lowerTrackPadding)
					adjustedScreenPosition.y = lowerTrackPadding;
				if (adjustedScreenPosition.y > 1f - upperTrackPadding)
					adjustedScreenPosition.y = 1f - upperTrackPadding;
			}

			Vector3 vpTarget = new Vector3(adjustedScreenPosition.x + offSetAxis.x, adjustedScreenPosition.y + offSetAxis.y, distance);
			Vector3 worldFromVp = cam.ViewportToWorldPoint(vpTarget);
			Vector3 desired = (transform.position - worldFromVp) + follow.position;

			if (tweenTime > 0f && Application.isPlaying)
			{
				return Vector3.SmoothDamp(transform.position, desired, ref velocity, tweenTime);
			}
			velocity = Vector3.zero;
			return desired;
		}
	}
}
