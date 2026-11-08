using UnityEngine;

namespace CameraStack
{
	public class CBPerspectiveFollow2D : CameraBehaviorPerspective
	{
		[SerializeField] private Vector3 rotation;
		[SerializeField] private float distance = 15f;
		[SerializeField] private float sideTrackPadding;
		[SerializeField] private float upperTrackPadding;
		[SerializeField] private float lowerTrackPadding;
		[SerializeField] private bool lockVerticalAxis;
		private Vector2 adjustedScreenPosition;

		public override void Init() => base.Init();
		public override void PreUpdate() { }
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			var b = Ball;
			if (b == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			Vector3 targetPos = b.transform.position;
			if (lockVerticalAxis) targetPos.y = transform.position.y;
			return targetPos - (rot * Vector3.forward) * dist;
		}
	}
}
