using System.Collections;
using UnityEngine;

namespace CameraStack
{
	public class CBFollowTrailer : CameraBehaviorPerspective
	{
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] protected bool followGoalOnWin;
		[SerializeField] public Vector3 rotation = new Vector3(45f, 0f, 0f);
		[SerializeField] public float elevation = 15f;
		[SerializeField] public bool shouldFollow = true;
		[SerializeField] public float startSmoothTime = 0.2f;
		[SerializeField] public float continuousSmoothTime = 0.15f;
		[SerializeField] public float aimSmoothTime = 0.2f;
		[SerializeField] private float continousTrackingTimer;
		[SerializeField] public Vector2 screenPosition = new Vector2(0.5f, 0.5f);
		[SerializeField] private float sideTrackPadding;
		[SerializeField] private float upperTrackPadding;
		[SerializeField] private float lowerTrackPadding;
		[SerializeField] private float startFOV = 60f;
		[SerializeField] private float offsetFOV;
		private float trailerFOV;
		[SerializeField] private Vector3 globalOffset;
		[SerializeField] private Vector3 cameraOffset;
		private bool useGlobalOffset;
		private Vector3 cachedCameraOffset;
		private float elevationSmoothTime;
		private Vector2 velocity;
		private Vector2 adjustedScreenPosition;
		public float groundedElevation;
		public float targetGroundedElevation;
		private float continousTrackingTimerCountDown;
		private float diff;
		private float distance;
		private float elevationSmoothVel;
		private float smoothTime;
		private float width;
		private float height;

		public float OffsetFOV { get => offsetFOV; set => offsetFOV = value; }
		public Vector3 GlobalOffset { get => globalOffset; set => globalOffset = value; }
		public Vector3 CameraOffset { get => cameraOffset; set => cameraOffset = value; }
		public Transform FollowTarget
		{
			get => followTarget != null ? followTarget : (Ball != null ? Ball.transform : orbitTarget);
			set => followTarget = value;
		}
		private Vector3 ballAtElevation => FollowTarget != null ? FollowTarget.position : Vector3.zero;

		public override void Init() => base.Init();
		private IEnumerator WaitForActiveBall() { yield break; }
		public override void OutOfBounds() { }
		public void SetElevation(float newElevation) => elevation = newElevation;
		public float GetElevation() => elevation;
		public void SetRotation(Vector3 newRotation) => rotation = newRotation;
		public Vector3 GetRotation() => rotation;
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);
		private Vector3 ScreenToWorld(Vector2 screenPos) => transform.position;
		private void UpdateWidthAndHeight() { }

		protected override Vector3 CalculatePosition()
		{
			var t = FollowTarget;
			if (t == null) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = elevation > 0.1f ? elevation : 15f;
			return t.position + globalOffset + cameraOffset - (rot * Vector3.forward) * dist;
		}

		public override void PreUpdate() { }
		private bool IsBallOutsideOfBox() => true;
		private bool IsPointOutsideOfBox(Vector3 p) => true;
		public override string ToString() => name;

		public void CopyVariables(CBFollow cbFollow)
		{
			if (cbFollow == null) return;
			rotation = cbFollow.rotation;
			elevation = cbFollow.elevation;
			shouldFollow = cbFollow.shouldFollow;
		}
	}
}
