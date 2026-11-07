using System.Collections;
using Chronos;
using UnityEngine;

namespace CameraStack
{
	public class CBFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[SerializeField]
		protected Transform orbitTarget;

		[SerializeField]
		protected Transform followTarget;

		[SerializeField]
		protected bool followGoalOnWin;

		[SerializeField]
		public Vector3 rotation;

		[SerializeField]
		public float elevation;

		[SerializeField]
		public bool shouldFollow;

		[SerializeField]
		protected float startSmoothTime;

		[SerializeField]
		protected float continuousSmoothTime;

		[SerializeField]
		protected float aimSmoothTime;

		[SerializeField]
		protected float continousTrackingTimer;

		[SerializeField]
		public Vector2 screenPosition;

		[SerializeField]
		protected float sideTrackPadding;

		[SerializeField]
		protected float upperTrackPadding;

		[SerializeField]
		protected float lowerTrackPadding;

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

		public Transform FollowTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual Vector3 ballAtElevation => default;

		public Transform GetFollowTarget()
		{
			return null;
		}

		public override void Init()
		{
		}

		private IEnumerator WaitForActiveBall()
		{
			return null;
		}

		public override void OutOfBounds()
		{
		}

		public void SetElevation(float newElevation)
		{
		}

		public float GetElevation()
		{
			return 0f;
		}

		public void SetRotation(Vector3 newRotation)
		{
		}

		public Vector3 GetRotation()
		{
			return default;
		}

		public override Quaternion CalculateRotation()
		{
			return default;
		}

		protected Vector3 ScreenToWorld(Vector2 screenPos)
		{
			return default;
		}

		protected void UpdateWidthAndHeight()
		{
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		protected bool IsBallOutsideOfBox()
		{
			return false;
		}

		protected bool IsPointOutsideOfBox(Vector3 p)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public void SetFollowTarget(Transform target)
		{
		}
	}
}
