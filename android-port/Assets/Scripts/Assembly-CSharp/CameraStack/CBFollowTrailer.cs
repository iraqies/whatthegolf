using System.Collections;
using UnityEngine;

namespace CameraStack
{
	public class CBFollowTrailer : CameraBehaviorPerspective
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
		public float startSmoothTime;

		[SerializeField]
		public float continuousSmoothTime;

		[SerializeField]
		public float aimSmoothTime;

		[SerializeField]
		private float continousTrackingTimer;

		[SerializeField]
		public Vector2 screenPosition;

		[SerializeField]
		private float sideTrackPadding;

		[SerializeField]
		private float upperTrackPadding;

		[SerializeField]
		private float lowerTrackPadding;

		[SerializeField]
		private float startFOV;

		[SerializeField]
		private float offsetFOV;

		private float trailerFOV;

		[SerializeField]
		private Vector3 globalOffset;

		[SerializeField]
		private Vector3 cameraOffset;

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

		public float OffsetFOV
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 GlobalOffset
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector3 CameraOffset
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

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

		private Vector3 ScreenToWorld(Vector2 screenPos)
		{
			return default;
		}

		private void UpdateWidthAndHeight()
		{
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		public override void PreUpdate()
		{
		}

		private bool IsBallOutsideOfBox()
		{
			return false;
		}

		private bool IsPointOutsideOfBox(Vector3 p)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public void CopyVariables(CBFollow cbFollow)
		{
		}
	}
}
