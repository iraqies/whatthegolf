using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBOrthographicFollow : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[SerializeField] private Transform followOverride;
		[SerializeField] private Vector3 rotation = new Vector3(0f, 0f, 90f);
		[SerializeField] private float distance = 100f;
		[SerializeField] private float leftSideTrackPadding = 0.25f;
		[SerializeField] private float rightSideTrackPadding = 0.25f;
		[SerializeField] private float upperTrackPadding = 0.25f;
		[SerializeField] private float lowerTrackPadding = 0.25f;
		[SerializeField] private bool lockVerticalAxis;
		[SerializeField] private bool lockHorizontalAxis;
		[SerializeField] private bool shouldCenterOnStart = true;
		[SerializeField] private float desktopOrthographicSize = 45f;
		[SerializeField] private Vector3 desktopRotation = new Vector3(90f, 90f, 0f);
		private Transform follow;
		private Vector2 adjustedScreenPosition;

		public override void Init()
		{
			if (followOverride != null)
				follow = followOverride;
			else if (Ball != null)
				follow = Ball.transform;
			base.Init();
			if (follow != null)
			{
				if (shouldCenterOnStart)
				{
					transform.position = follow.position - transform.forward * distance;
				}
				else
				{
					Vector3 pos = transform.position;
					pos.y = follow.position.y - transform.forward.y * distance;
					transform.position = pos;
				}
			}
			var cfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			if (CameraManager.Instance != null && cfg != null && !cfg.useRotatedOverworldAndCameraInLevels)
			{
				orthographicSize = desktopOrthographicSize;
			}
		}

		public override void PreUpdate() { }

		public override Quaternion CalculateRotation()
		{
			var cfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
			bool useRot = cfg == null || cfg.useRotatedOverworldAndCameraInLevels;
			return Quaternion.Euler(useRot ? rotation : desktopRotation);
		}

		protected override Vector3 CalculatePosition()
		{
			if (Cameras == null || Cameras.Length == 0 || Cameras[0] == null || follow == null)
				return transform.position;
			Camera cam = Cameras[0];
			float sw = cam.targetTexture != null ? cam.targetTexture.width : (cam.pixelWidth > 0 ? cam.pixelWidth : Screen.width);
			float sh = cam.targetTexture != null ? cam.targetTexture.height : (cam.pixelHeight > 0 ? cam.pixelHeight : Screen.height);
			if (sw <= 0f) sw = 576f;
			if (sh <= 0f) sh = 1280f;

			Vector3 sp = cam.WorldToScreenPoint(follow.position);
			adjustedScreenPosition = new Vector2(sp.x / sw, sp.y / sh);
			if (!lockHorizontalAxis)
			{
				if (adjustedScreenPosition.x < leftSideTrackPadding)
					adjustedScreenPosition.x = leftSideTrackPadding;
				if (adjustedScreenPosition.x > 1f - rightSideTrackPadding)
					adjustedScreenPosition.x = 1f - rightSideTrackPadding;
			}
			if (!lockVerticalAxis)
			{
				if (adjustedScreenPosition.y < lowerTrackPadding)
					adjustedScreenPosition.y = lowerTrackPadding;
				if (adjustedScreenPosition.y > 1f - upperTrackPadding)
					adjustedScreenPosition.y = 1f - upperTrackPadding;
			}
			Vector3 worldPt = cam.ScreenToWorldPoint(new Vector3(adjustedScreenPosition.x * sw, adjustedScreenPosition.y * sh, distance));
			return (transform.position - worldPt) + follow.position;
		}

		public void SetFollowTarget(Transform target) => follow = target;

		public Transform GetFollowTarget() => follow != null ? follow : followOverride;
	}
}
