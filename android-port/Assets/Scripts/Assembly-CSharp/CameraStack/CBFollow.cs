using System.Collections;
using Chronos;
using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField] protected Transform orbitTarget;
		[SerializeField] protected Transform followTarget;
		[SerializeField] protected bool followGoalOnWin = true;
		[SerializeField] public Vector3 rotation = new Vector3(45f, 0f, 0f);
		[SerializeField] public float elevation = 15f;
		[SerializeField] public bool shouldFollow = true;
		[SerializeField] protected float startSmoothTime = 0.25f;
		[SerializeField] protected float continuousSmoothTime = 0.15f;
		[SerializeField] protected float aimSmoothTime = 0.2f;
		[SerializeField] protected float continousTrackingTimer = 0.5f;
		[SerializeField] public Vector2 screenPosition = new Vector2(0.5f, 0.5f);
		[SerializeField] protected float sideTrackPadding = 0.2f;
		[SerializeField] protected float upperTrackPadding = 0.2f;
		[SerializeField] protected float lowerTrackPadding = 0.2f;

		public LocalClock Clock;
		protected float elevationSmoothTime;
		protected Vector2 velocity;
		protected Vector2 adjustedScreenPosition;
		public float groundedElevation;
		public float targetGroundedElevation;
		protected float continousTrackingTimerCountDown;
		protected float diff;
		protected float distance;
		protected float elevationSmoothVel;
		protected float smoothTime;
		protected float width;
		protected float height;
		private Vector3 _currentPos;
		private bool _hasInitialPos;

		public Transform FollowTarget
		{
			get => GetFollowTarget();
			set => followTarget = value;
		}

		protected virtual Vector3 ballAtElevation
		{
			get
			{
				var t = GetFollowTarget();
				return t != null ? t.position : Vector3.zero;
			}
		}

		public Transform GetFollowTarget()
		{
			if (followTarget != null) return followTarget;
			var b = Ball;
			return b != null ? b.transform : orbitTarget;
		}

		public override void Init()
		{
			base.Init();
			_currentPos = transform.position;
			_hasInitialPos = true;
		}

		private IEnumerator WaitForActiveBall()
		{
			yield break;
		}

		public override void OutOfBounds() { }
		public void SetElevation(float newElevation) => elevation = newElevation;
		public float GetElevation() => elevation;
		public void SetRotation(Vector3 newRotation) => rotation = newRotation;
		public Vector3 GetRotation() => rotation;
		public override Quaternion CalculateRotation() => Quaternion.Euler(rotation);
		protected Vector3 ScreenToWorld(Vector2 screenPos) => transform.position;
		protected void UpdateWidthAndHeight() { }

		protected override Vector3 CalculatePosition()
		{
			var target = GetFollowTarget();
			if (target == null || !shouldFollow) return transform.position;
			Quaternion rot = CalculateRotation();
			float dist = elevation > 0.1f ? elevation : 14f;
			Vector3 desired = target.position - (rot * Vector3.forward) * dist;
			if (!_hasInitialPos)
			{
				_currentPos = desired;
				_hasInitialPos = true;
			}
			else
			{
				float st = Mathf.Max(0.05f, continuousSmoothTime);
				_currentPos = Vector3.Lerp(_currentPos, desired, Time.unscaledDeltaTime / st);
			}
			return _currentPos;
		}

		protected bool IsBallOutsideOfBox() => true;
		protected bool IsPointOutsideOfBox(Vector3 p) => true;
		public override string ToString() => name;
		public void SetFollowTarget(Transform target) => followTarget = target;
	}
}
