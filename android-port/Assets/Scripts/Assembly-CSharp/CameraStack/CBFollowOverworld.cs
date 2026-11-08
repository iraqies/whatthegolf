using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBFollowOverworld : CameraBehaviorPerspective
	{
		[SerializeField] protected new GolfBallController Ball;
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] private Vector3 rotation = new Vector3(45f, 0f, 0f);
		[SerializeField] private float elevation = 15f;
		[SerializeField] private bool shouldFollow = true;
		[SerializeField] private float startSmoothTime = 0.2f;
		[SerializeField] private float continuousSmoothTime = 0.15f;
		[SerializeField] private float aimSmoothTime = 0.2f;
		[SerializeField] private float continousTrackingTimer;
		[SerializeField] private Vector2 screenPosition = new Vector2(0.5f, 0.5f);
		[SerializeField] private float sideTrackPadding = 0.2f;
		[SerializeField] private float upperTrackPadding = 0.2f;
		[SerializeField] private float lowerTrackPadding = 0.2f;
		[SerializeField] private float elevationSmoothTime = 0.2f;
		private Vector2 velocity;
		private Vector3 pVelocity;
		private Vector2 adjustedScreenPosition;
		private float groundedElevation;
		private float targetGroundedElevation;
		private float continousTrackingTimerCountDown;
		private float diff;
		private float distance;
		private float elevationSmoothVel;
		private float smoothTime;

		public Transform FollowTarget
		{
			get => followTarget != null ? followTarget : (Ball != null ? Ball.transform : base.Ball?.transform);
			set => followTarget = value;
		}

		private Vector3 ballAtElevation => FollowTarget != null ? FollowTarget.position : Vector3.zero;
		private void Awake() { }
		public override void Init() => base.Init();
		public override void OutOfBounds() { }
		public void SetElevation(float newElevation) => elevation = newElevation;
		public void SetRotation(Vector3 newRotation) => rotation = newRotation;
		public Vector3 GetRotation() => rotation;
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);
		private Vector3 ScreenToWorld(Vector2 screenPos) => transform.position;

		protected override Vector3 CalculatePosition()
		{
			var t = FollowTarget;
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = elevation > 0.1f ? elevation : 15f;
			return t.position - (rot * Vector3.forward) * dist;
		}

		private bool IsBallOutsideOfBox() => true;
		private bool IsPointOutsideOfBox(Vector3 p) => true;
		private bool IsPointOutsideOfWindow(Vector3 p) => true;
		public override string ToString() => name;
	}
}
