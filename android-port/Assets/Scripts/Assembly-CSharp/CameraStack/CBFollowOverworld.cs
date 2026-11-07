using Core;
using UnityEngine;

namespace CameraStack
{
	public class CBFollowOverworld : CameraBehaviorPerspective
	{
		[SerializeField]
		protected new GolfBallController Ball;

		[SerializeField]
		protected Transform orbitTarget;

		[SerializeField]
		protected Transform followTarget;

		[SerializeField]
		private Vector3 rotation;

		[SerializeField]
		private float elevation;

		[SerializeField]
		private bool shouldFollow;

		[SerializeField]
		private float startSmoothTime;

		[SerializeField]
		private float continuousSmoothTime;

		[SerializeField]
		private float aimSmoothTime;

		[SerializeField]
		private float continousTrackingTimer;

		[SerializeField]
		private Vector2 screenPosition;

		[SerializeField]
		private float sideTrackPadding;

		[SerializeField]
		private float upperTrackPadding;

		[SerializeField]
		private float lowerTrackPadding;

		[SerializeField]
		private float elevationSmoothTime;

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
			get
			{
				return null;
			}
			set
			{
			}
		}

		private Vector3 ballAtElevation => default;

		private void Awake()
		{
		}

		public override void Init()
		{
		}

		public override void OutOfBounds()
		{
		}

		public void SetElevation(float newElevation)
		{
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

		private Vector3 ScreenToWorld(Vector2 screenPos)
		{
			return default;
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		private bool IsBallOutsideOfBox()
		{
			return false;
		}

		private bool IsPointOutsideOfBox(Vector3 p)
		{
			return false;
		}

		private bool IsPointOutsideOfWindow(Vector3 p)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
