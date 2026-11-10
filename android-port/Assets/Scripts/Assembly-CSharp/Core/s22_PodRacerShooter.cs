using Chronos;
using UnityEngine;

namespace Core
{
	public class s22_PodRacerShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		private float raycastDist = 0.25f;

		[SerializeField]
		private Transform frontForcePosition;

		[SerializeField]
		private Vector2 AdjustForceRange;

		[SerializeField]
		private float AdjustRotationSpeed;

		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[SerializeField]
		private float AdjustRotationSpeedStartupTime;

		[SerializeField]
		private float MaxSpeedLossOnHeadOnCollision = 0.5f;

		[SerializeField]
		private float MaxVelocity = 15f;

		[SerializeField]
		private float MinVelocity = 2f;

		[SerializeField]
		private LayerMask GroundCheckMask;

		public GolfBallController ballController;

		private float lastBoostMagnitude;

		private float currentSpeedLossFromCollisions;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private bool didAim;

		private float rotationStartupTimer;

		private LocalClock clock;

		private Timeline timeline;

		private float timeGrounded;

		private float FixedDeltaTime => (timeline != null) ? timeline.fixedDeltaTime : Time.fixedDeltaTime;

		private float DeltaTime => (timeline != null) ? timeline.deltaTime : Time.deltaTime;

		public Vector3 Velocity
		{
			get
			{
				if (timeline != null && timeline.rigidbody != null)
					return timeline.rigidbody.velocity;
				return (rigidbodyC != null) ? rigidbodyC.velocity : Vector3.zero;
			}
			set
			{
				if (timeline != null && timeline.rigidbody != null)
					timeline.rigidbody.velocity = value;
				else if (rigidbodyC != null)
					rigidbodyC.velocity = value;
			}
		}

		public Vector3 AngularVelocity
		{
			get
			{
				if (timeline != null && timeline.rigidbody != null)
					return timeline.rigidbody.angularVelocity;
				return (rigidbodyC != null) ? rigidbodyC.angularVelocity : Vector3.zero;
			}
			set
			{
				if (timeline != null && timeline.rigidbody != null)
					timeline.rigidbody.angularVelocity = value;
				else if (rigidbodyC != null)
					rigidbodyC.angularVelocity = value;
			}
		}

		public float Drag
		{
			get
			{
				if (timeline != null && timeline.rigidbody != null)
					return timeline.rigidbody.drag;
				return (rigidbodyC != null) ? rigidbodyC.drag : 0f;
			}
			set
			{
				if (timeline != null && timeline.rigidbody != null)
					timeline.rigidbody.drag = value;
				else if (rigidbodyC != null)
					rigidbodyC.drag = value;
			}
		}

		public float AngularDrag
		{
			get
			{
				if (timeline != null && timeline.rigidbody != null)
					return timeline.rigidbody.angularDrag;
				return (rigidbodyC != null) ? rigidbodyC.angularDrag : 0f;
			}
			set
			{
				if (timeline != null && timeline.rigidbody != null)
					timeline.rigidbody.angularDrag = value;
				else if (rigidbodyC != null)
					rigidbodyC.angularDrag = value;
			}
		}

		public float LocalTime => (timeline != null) ? timeline.time : Time.time;

		public bool IsKinematic
		{
			get
			{
				if (timeline != null && timeline.rigidbody != null)
					return timeline.rigidbody.isKinematic;
				return rigidbodyC != null && rigidbodyC.isKinematic;
			}
			set
			{
				if (timeline != null && timeline.rigidbody != null)
					timeline.rigidbody.isKinematic = value;
				else if (rigidbodyC != null)
					rigidbodyC.isKinematic = value;
			}
		}

		public override void OnActivate()
		{
			base.OnActivate();
			IsKinematic = false;
			didAim = false;
		}

		private void Start()
		{
			clock = GetComponent<LocalClock>();
			timeline = GetComponent<Timeline>();
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (!onlyAimArrow)
				AdjustRotation(boost.normalized, false);
		}

		public override void OnAimStart()
		{
			base.OnAimStart();
			isAiming = true;
			didAim = true;
		}

		public override void OnCancel()
		{
			base.OnCancel();
			isAiming = false;
		}

		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
			if (dir.magnitude <= 0.001f)
				return;

			float speed = isDriving ? AdjustRotationSpeedWhileDriving : AdjustRotationSpeed;
			if (AdjustRotationSpeedStartupTime != 0f)
			{
				speed *= Mathf.Clamp01(rotationStartupTimer / AdjustRotationSpeedStartupTime);
			}

			Quaternion targetRot = Quaternion.LookRotation(dir.normalized);
			if (rigidbodyC != null)
			{
				Quaternion curRot = rigidbodyC.rotation;
				Quaternion nextRot = Quaternion.RotateTowards(curRot, targetRot, speed * Time.unscaledDeltaTime);
				rigidbodyC.MoveRotation(nextRot);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			rotationStartupTimer = 0f;
			AngularVelocity = Vector3.zero;
			currentSpeedLossFromCollisions = 0f;
			Vector3 norm = boost.normalized;
			float mag = boost.magnitude;
			Vector3 horizontalBoost = new Vector3(norm.x * mag, 0f, norm.z * mag);
			lastBoostMagnitude = horizontalBoost.magnitude;
			lastShootVelocity = horizontalBoost.normalized * Mathf.Lerp(minShootVelocity, fullShootVelocity, horizontalBoost.magnitude);
			Velocity += lastShootVelocity;
			isAiming = false;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision == null || collision.contacts == null || collision.contacts.Length == 0)
				return;

			if (!Mathf.Approximately(MaxSpeedLossOnHeadOnCollision, 0f))
			{
				Vector3 point = collision.contacts[0].point;
				Vector3 toHit = point - transform.position;
				float angle = Vector3.Angle(transform.forward, toHit);
				float factor = 1f - Mathf.Clamp01(angle / 90f);
				currentSpeedLossFromCollisions += factor * MaxSpeedLossOnHeadOnCollision;
				currentSpeedLossFromCollisions = Mathf.Clamp(currentSpeedLossFromCollisions, 0f, MaxSpeedLossOnHeadOnCollision);
			}
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (clock != null)
			{
				clock.localTimeScale = (GolfBallController != null && GolfBallController.IsChangingTime)
					? (1f / Mathf.Max(0.0001f, Time.timeScale))
					: 1f;
			}

			Vector3 rayOrigin = transform.position + Vector3.up * 0.5f;
			bool grounded = Physics.Raycast(rayOrigin, Vector3.down, raycastDist, GroundCheckMask);
			if (grounded)
				timeGrounded += FixedDeltaTime;
			else
				timeGrounded = 0f;

			if (grounded)
			{
				if (isAiming)
					rotationStartupTimer += Time.unscaledDeltaTime;

				if (GolfBallController != null)
					GolfBallController.isBlocking = false;

				Vector3 forward = transform.forward;
				float angleToTarget = Vector3.SignedAngle(forward, lastShootVelocity.normalized, Vector3.up);
				float forceFactor = Mathf.Clamp01(Mathf.Abs(angleToTarget) / 90f);
				float sideForceMag = Mathf.Lerp(AdjustForceRange.x, AdjustForceRange.y, forceFactor) * lastBoostMagnitude;
				Vector3 sideDir = (angleToTarget > 0f) ? transform.right : (-transform.right);
				if (frontForcePosition != null)
					AddForceAtPosition(sideDir * (sideForceMag * FixedDeltaTime), frontForcePosition.position, ForceMode.Force);

				if (didAim && Velocity.magnitude < MaxVelocity)
				{
					AddForce(forward * MinVelocity, ForceMode.Acceleration);
				}

				if (Velocity.magnitude < 5f)
				{
					AddForce(Vector3.down * (FixedDeltaTime * 500f), ForceMode.Force);
				}
			}
			else
			{
				if (GolfBallController != null)
					GolfBallController.isBlocking = true;
			}
		}

		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
			if (timeline != null && timeline.rigidbody != null)
				timeline.rigidbody.AddForceAtPosition(force, position, forceMode);
			else if (rigidbodyC != null)
				rigidbodyC.AddForceAtPosition(force, position, forceMode);
		}

		private void AddRelativeTorque(Vector3 torque, ForceMode forceMode)
		{
			if (timeline != null && timeline.rigidbody != null)
				timeline.rigidbody.AddRelativeTorque(torque, forceMode);
			else if (rigidbodyC != null)
				rigidbodyC.AddRelativeTorque(torque, forceMode);
		}

		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
			if (timeline != null && timeline.rigidbody != null)
				timeline.rigidbody.AddForce(force, forceMode);
			else if (rigidbodyC != null)
				rigidbodyC.AddForce(force, forceMode);
		}
	}
}
