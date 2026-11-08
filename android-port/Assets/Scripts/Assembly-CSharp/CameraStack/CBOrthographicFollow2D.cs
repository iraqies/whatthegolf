using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow2D : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 50f;
		[SerializeField] public float sideTrackPadding = 0.25f;
		[SerializeField] public float upperTrackPadding = 0.25f;
		[SerializeField] public float lowerTrackPadding = 0.25f;
		[SerializeField] public Vector2 offSetAxis;
		[SerializeField] public bool lockVerticalAxis;
		[SerializeField] public bool lockHorizontalAxis;
		[SerializeField] private Transform follow;
		[SerializeField] private bool autoAdjustOrthographicSize = true;
		[SerializeField] public float tweenTime = 0.1f;
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
			var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useRotated = currentCfg != null && currentCfg.useRotatedOverworldAndCameraInLevels;
			if (!useRotated)
				desktopRotation = rotation;
			if (follow != null)
			{
				transform.position = CalculatePosition();
			}
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
			if (val <= 0.01f) return;
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

		public Transform GetFollowTarget()
		{
			if (follow != null) return follow;
			if (OverworldManager2d.HasInstance && OverworldManager2d.Instance != null)
			{
				if (OverworldManager2d.Instance.cameraTarget != null)
					return follow = OverworldManager2d.Instance.cameraTarget;
				if (OverworldManager2d.Instance.ball != null)
					return follow = OverworldManager2d.Instance.ball.transform;
			}
			if (Ball != null)
				return follow = Ball.transform;
			return null;
		}

		public override void PreUpdate() { }

		public override Quaternion CalculateRotation()
		{
			var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useRotated = currentCfg != null && currentCfg.useRotatedOverworldAndCameraInLevels;
			return Quaternion.Euler(useRotated ? rotation : desktopRotation);
		}

		protected override Vector3 CalculatePosition()
		{
			if (Cameras == null || Cameras.Length == 0 || Cameras[0] == null || isInPipeIntro)
				return transform.position;

			Camera cam = Cameras[0];
			Transform target = GetFollowTarget();
			if (target == null)
				return transform.position;

			Vector3 clampedLook = Vector3.ClampMagnitude(lookAhead, 5f) * lookAheadDistance;
			Vector3 focusWorld = target.position - clampedLook;
			Vector3 vp = cam.WorldToViewportPoint(focusWorld);
			adjustedScreenPosition = new Vector2(vp.x, vp.y);

			if (!lockHorizontalAxis)
			{
				float padX = Mathf.Clamp(sideTrackPadding, 0.05f, 0.5f);
				if (adjustedScreenPosition.x < padX)
					adjustedScreenPosition.x = padX;
				if (adjustedScreenPosition.x > 1f - padX)
					adjustedScreenPosition.x = 1f - padX;
			}
			if (!lockVerticalAxis)
			{
				float padLow = Mathf.Clamp(lowerTrackPadding, 0.05f, 0.5f);
				float padUp = Mathf.Clamp(upperTrackPadding, 0.05f, 0.5f);
				if (adjustedScreenPosition.y < padLow)
					adjustedScreenPosition.y = padLow;
				if (adjustedScreenPosition.y > 1f - padUp)
					adjustedScreenPosition.y = 1f - padUp;
			}

			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 50f;
			Vector3 vpTarget = new Vector3(adjustedScreenPosition.x + offSetAxis.x, adjustedScreenPosition.y + offSetAxis.y, dist);
			Vector3 worldFromVp = cam.ViewportToWorldPoint(vpTarget);
			Vector3 camPos = transform.position;
			Vector3 desired = (camPos - worldFromVp) + target.position;
			desired.z = -dist;

			if (tweenTime > 0f)
			{
				return Vector3.SmoothDamp(camPos, desired, ref velocity, tweenTime);
			}
			velocity = Vector3.zero;
			return desired;
		}
	}
}
