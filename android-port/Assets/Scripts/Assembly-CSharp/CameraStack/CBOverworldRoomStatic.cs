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
		public override void Init() => base.Init();
		public void SetFollowTarget(Transform newTarget) => follow = newTarget;
		public void SetOrthoSize(float val) => orthographicSize = val;
		public float GetOrthoSize() => orthographicSize > 0.01f ? orthographicSize : 8f;
		public Transform GetFollowTarget() => follow != null ? follow : transform;
		public override void PreUpdate() { }
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);

		protected override Vector3 CalculatePosition()
		{
			Transform t = GetFollowTarget();
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			return t.position - (rot * Vector3.forward) * dist;
		}
	}
}
