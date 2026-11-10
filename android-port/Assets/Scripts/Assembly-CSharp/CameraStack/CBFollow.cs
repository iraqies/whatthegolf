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
		[SerializeField] public Vector3 rotation = new Vector3(30f, 0f, 0f);
		[SerializeField] public float elevation = 40f;
		[SerializeField] public bool shouldFollow = true;
		[SerializeField] protected float startSmoothTime = 1.2f;
		[SerializeField] protected float continuousSmoothTime = 0.4f;
		[SerializeField] protected float aimSmoothTime = 0.2f;
		[SerializeField] protected float continousTrackingTimer = 0.4f;
		[SerializeField] public Vector2 screenPosition = new Vector2(0.5f, 0.33f);
		public Vector2 screenRelativePivot
		{
			get => screenPosition;
			set => screenPosition = value;
		}
		[SerializeField] protected float sideTrackPadding = 0.2f;
		[SerializeField] protected float upperTrackPadding = 0.2f;
		[SerializeField] protected float lowerTrackPadding = 0.2f;

		public LocalClock Clock;
		protected float elevationSmoothTime = 0.4f;
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
			get => followTarget;
			set
			{
				followTarget = value;
				if (MainAudioListener.Instance != null)
					MainAudioListener.Instance.OnCameraBehaviourChanged(this);
			}
		}

		protected virtual Vector3 ballAtElevation
		{
			get
			{
				if (followTarget == null)
					return Vector3.zero;
				Vector3 p = followTarget.position;
				return new Vector3(p.x, groundedElevation, p.z);
			}
		}

		public Transform GetFollowTarget() => followTarget;

		public override void Init()
		{
			base.Init();
			if (gameObject.activeInHierarchy)
				StartCoroutine(WaitForActiveBall());
			if (followTarget == null)
			{
				if (Ball != null)
				{
					followTarget = Ball.transform;
					if (MainAudioListener.Instance != null)
						MainAudioListener.Instance.OnCameraBehaviourChanged(this);
				}
				else
				{
					enabled = false;
					return;
				}
			}
			UpdateWidthAndHeight();
			transform.position = ScreenToWorld(screenPosition);
			if (followTarget != null)
			{
				float y = followTarget.position.y;
				groundedElevation = y;
				targetGroundedElevation = y;
			}
		}

		private IEnumerator WaitForActiveBall()
		{
			while (Ball == null)
				yield return null;
			Ball.OnShoot += _ =>
			{
				continousTrackingTimerCountDown = continousTrackingTimer;
			};
		}

		public override void OutOfBounds()
		{
			velocity = Vector2.zero;
			elevationSmoothVel = 0f;
			if (followTarget != null)
			{
				float y = followTarget.position.y;
				groundedElevation = y;
				targetGroundedElevation = y;
				transform.position = ScreenToWorld(screenPosition);
			}
		}

		public void SetElevation(float newElevation) => elevation = newElevation;
		public float GetElevation() => elevation;
		public void SetRotation(Vector3 newRotation) => rotation = newRotation;
		public Vector3 GetRotation() => rotation;

		public override Quaternion CalculateRotation()
		{
			if (orbitTarget == null)
				return Quaternion.Euler(rotation);
			if (followTarget == null)
				return Quaternion.Euler(rotation);
			Vector3 dir = new Vector3(orbitTarget.position.x, followTarget.position.y, orbitTarget.position.z) - transform.position;
			if (dir.sqrMagnitude > 1e-4f)
				return Quaternion.LookRotation(dir);
			return Quaternion.Euler(rotation);
		}

		protected Vector3 ScreenToWorld(Vector2 screenPos)
		{
			if (!shouldFollow || followTarget == null)
				return transform.position;
			var cams = Cameras;
			Camera cam = (cams != null && cams.Length > 0 && cams[0] != null) ? cams[0] : Camera.main;
			if (cam == null)
				return transform.position;

			Vector3 vpZero = cam.ViewportToWorldPoint(new Vector3(screenPos.x, screenPos.y, 0f));
			Vector3 targetPos = ballAtElevation;
			Vector3 delta = new Vector3(vpZero.x - targetPos.x, groundedElevation - targetPos.y, vpZero.z - targetPos.z);
			diff = delta.magnitude;
			distance = Mathf.Sqrt(diff * diff + elevation * elevation);
			Vector3 worldAtDist = cam.ViewportToWorldPoint(new Vector3(screenPos.x, screenPos.y, distance));
			Vector3 camOffset = transform.position - worldAtDist;
			return ballAtElevation + camOffset;
		}

		protected void UpdateWidthAndHeight()
		{
			var cams = Cameras;
			Camera cam = (cams != null && cams.Length > 0 && cams[0] != null) ? cams[0] : Camera.main;
			if (cam != null)
			{
				width = cam.pixelWidth;
				height = cam.pixelHeight;
				if (cam.targetTexture != null)
				{
					width = cam.targetTexture.width;
					height = cam.targetTexture.height;
				}
			}
		}

		protected override Vector3 CalculatePosition()
		{
			if ((followTarget == null || !followTarget.gameObject.activeInHierarchy) && Ball != null && Ball.gameObject.activeInHierarchy)
			{
				followTarget = Ball.transform;
				groundedElevation = followTarget.position.y;
				targetGroundedElevation = followTarget.position.y;
			}
			if (followTarget == null)
				return Vector3.zero;
			var cams = Cameras;
			Camera cam = (cams != null && cams.Length > 0 && cams[0] != null) ? cams[0] : Camera.main;
			UpdateWidthAndHeight();

			if (orbitTarget != null)
			{
				Vector3 dir = (orbitTarget.position - followTarget.position).normalized;
				return followTarget.position - dir * 100f;
			}

			if (!IsPointOutsideOfBox(followTarget.position) || followTarget.position.y < targetGroundedElevation)
				targetGroundedElevation = followTarget.position.y;

			float dt = Clock != null ? Clock.deltaTime : Time.unscaledDeltaTime;
			groundedElevation = Mathf.SmoothDamp(groundedElevation, targetGroundedElevation, ref elevationSmoothVel, Mathf.Max(0.05f, elevationSmoothTime), float.PositiveInfinity, dt);

			if (cam != null)
			{
				Vector3 vp = cam.WorldToViewportPoint(ballAtElevation);
				adjustedScreenPosition = new Vector2(vp.x, vp.y);
				float px = vp.x * cam.pixelWidth;
				float py = vp.y * cam.pixelHeight;
				float leftPad = sideTrackPadding * width;
				float rightPad = (1f - sideTrackPadding) * width;
				if (px < leftPad || px > rightPad)
					adjustedScreenPosition.x = px > rightPad ? (1f - sideTrackPadding) : sideTrackPadding;
				float botPad = lowerTrackPadding * height;
				if (py < botPad)
					adjustedScreenPosition.y = lowerTrackPadding;
				float topPad = (1f - upperTrackPadding) * height;
				if (py > topPad)
					adjustedScreenPosition.y = 1f - upperTrackPadding;
			}
			else
			{
				adjustedScreenPosition = screenPosition;
			}

			continousTrackingTimerCountDown -= (Clock != null ? Clock.deltaTime : Time.deltaTime);
			if (Ball != null && Ball.IsAiming)
				smoothTime = aimSmoothTime;
			else if (continousTrackingTimerCountDown < 0f)
				smoothTime = continuousSmoothTime;
			else
				smoothTime = startSmoothTime;

			adjustedScreenPosition = Vector2.SmoothDamp(
				adjustedScreenPosition,
				screenPosition,
				ref velocity,
				Mathf.Max(0.05f, smoothTime),
				float.PositiveInfinity,
				dt);

			return ScreenToWorld(adjustedScreenPosition);
		}

		protected bool IsBallOutsideOfBox()
		{
			return followTarget != null && IsPointOutsideOfBox(followTarget.position);
		}

		protected bool IsPointOutsideOfBox(Vector3 p)
		{
			var cams = Cameras;
			Camera cam = (cams != null && cams.Length > 0 && cams[0] != null) ? cams[0] : Camera.main;
			if (cam == null) return true;
			Vector3 sp = cam.WorldToScreenPoint(p);
			if (sp.x < sideTrackPadding * width || sp.x > (1f - sideTrackPadding) * width)
				return true;
			if (sp.y < lowerTrackPadding * height)
				return true;
			return sp.y > (1f - upperTrackPadding) * height;
		}

		public override string ToString() => name;
		public void SetFollowTarget(Transform target) => followTarget = target;
	}
}
