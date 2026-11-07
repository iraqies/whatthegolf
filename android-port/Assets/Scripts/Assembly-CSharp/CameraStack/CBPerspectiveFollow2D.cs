using UnityEngine;

namespace CameraStack
{
	public class CBPerspectiveFollow2D : CameraBehaviorPerspective
	{
		[SerializeField]
		private Vector3 rotation;

		[SerializeField]
		private float distance;

		[SerializeField]
		private float sideTrackPadding;

		[SerializeField]
		private float upperTrackPadding;

		[SerializeField]
		private float lowerTrackPadding;

		[SerializeField]
		private bool lockVerticalAxis;

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
	}
}
