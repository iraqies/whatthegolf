using UnityEngine;

namespace CameraStack
{
	public class CBOverworldRoomStatic : CameraBehaviorOrthographic
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float smoothTime = 0.2f;
		[SerializeField] private float distance = 15f;
		[SerializeField] private bool lockVerticalAxis;
		[SerializeField] private bool lockHorizontalAxis;
		[SerializeField] private Transform follow;
		private Vector3 camVelocity;
		[SerializeField] private Vector3 desktopRotation;
		private Vector2 adjustedScreenPosition;

		public Transform roomCenter { get => follow; set => follow = value; }

		public override void Init()
		{
			base.Init();
			if (follow != null)
				transform.position = CalculatePosition();
		}

		public void SetFollowTarget(Transform newTarget) => follow = newTarget;
		public void SetOrthoSize(float val) => orthographicSize = val;
		public float GetOrthoSize() => orthographicSize > 0.01f ? orthographicSize : 8f;
		public Transform GetFollowTarget() => follow != null ? follow : transform;

		public override void PreUpdate()
		{
			if (follow != null)
			{
				Vector3 targetPos = Vector3.SmoothDamp(transform.position, follow.position, ref camVelocity, smoothTime);
				targetPos.z = distance;
				transform.position = targetPos;
			}
			if (Cameras != null && Cameras.Length > 0 && Cameras[0] != null)
			{
				Cameras[0].orthographicSize = Mathf.MoveTowards(Cameras[0].orthographicSize, GetOrthoSize(), Time.deltaTime * 3.5f);
			}
		}

		public override Quaternion CalculateRotation()
		{
			bool useRotated = Core.PlatformSettings.IsMobile;
			if (Core.PlatformSettings.Instance != null && Core.PlatformSettings.Instance.GetCurrent() != null)
				useRotated = Core.PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;
			return Quaternion.Euler(useRotated ? rotation : desktopRotation);
		}

		protected override Vector3 CalculatePosition()
		{
			if (follow != null)
			{
				Vector3 pos = follow.position;
				pos.z = distance;
				return pos;
			}
			return transform.position;
		}
	}
}
