using UnityEngine;

namespace CameraStack
{
	public class CBPerspectiveFollow2D : CameraBehaviorPerspective
	{
		[SerializeField] private Vector3 rotation = new Vector3(90f, 0f, 0f);
		[SerializeField] private float distance = 100f;
		[SerializeField] private float sideTrackPadding = 0.25f;
		[SerializeField] private float upperTrackPadding = 0.25f;
		[SerializeField] private float lowerTrackPadding = 0.25f;
		[SerializeField] private bool lockVerticalAxis;
		private Vector2 adjustedScreenPosition;

		public override void Init()
		{
			base.Init();
			if (Ball != null)
			{
				transform.position = Ball.transform.position - transform.forward * distance;
			}
		}

		public override void PreUpdate() => base.PreUpdate();
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			if (Cameras == null || Cameras.Length == 0 || Cameras[0] == null || Ball == null)
				return transform.position;

			Camera cam = Cameras[0];
			float sw = cam.targetTexture != null ? cam.targetTexture.width : (cam.pixelWidth > 0 ? cam.pixelWidth : Screen.width);
			float sh = cam.targetTexture != null ? cam.targetTexture.height : (cam.pixelHeight > 0 ? cam.pixelHeight : Screen.height);
			if (sw <= 0f) sw = 576f;
			if (sh <= 0f) sh = 1280f;

			Vector3 sp = cam.WorldToScreenPoint(Ball.transform.position);
			adjustedScreenPosition = new Vector2(sp.x / sw, sp.y / sh);
			if (adjustedScreenPosition.y < sideTrackPadding)
				adjustedScreenPosition.y = sideTrackPadding;
			if (adjustedScreenPosition.y > 1f - sideTrackPadding)
				adjustedScreenPosition.y = 1f - sideTrackPadding;

			if (!lockVerticalAxis)
			{
				if (adjustedScreenPosition.y < lowerTrackPadding)
					adjustedScreenPosition.y = lowerTrackPadding;
				if (adjustedScreenPosition.y > 1f - upperTrackPadding)
					adjustedScreenPosition.y = 1f - upperTrackPadding;
			}

			Vector3 worldPt = cam.ScreenToWorldPoint(new Vector3(adjustedScreenPosition.x * sw, adjustedScreenPosition.y * sh, distance));
			return (transform.position - worldPt) + Ball.transform.position;
		}
	}
}
