using Chronos;
using UnityEngine;

namespace Core
{
	public class GolfCarNoFollowAimShooter : GolfBallShooterBase
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
		private LayerMask NonKinematicCollisionLayer;

		[SerializeField]
		private bool moveCarForwardIfNotGrounded;

		[SerializeField]
		private float dragInAir = -1f;

		[SerializeField]
		private float angularDragInAir = -1f;

		public GolfBallController ballController;

		private float lastShootTime;

		private float lastBoostMagnitude;

		private float currentSpeedLossFromCollisions;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private float keepGoingForwardTime = 0.2f;

		private bool didShoot;

		private float rotationStartupTimer;

		private float baseDrag;

		private float baseAngularDrag;

		private bool baseAffectTimeSetting;

		private Timeline timeline;

		private LocalClock clock;

		[SerializeField]
		private bool isEditorCar;

		[SerializeField]
		private SetCenterOfMass setCoM;

		[SerializeField]
		private Transform centerOfMassInMotion;

		[SerializeField]
		private Transform centerOfMassNoMotion;

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

		public void TurnOfCar()
		{
			keepGoingForwardTime = 0f;
			lastShootVelocity = Vector3.zero;
		}

		private void Start()
		{
			clock = GetComponent<LocalClock>();
			timeline = GetComponent<Timeline>();
			baseDrag = Drag;
			baseAngularDrag = AngularDrag;
			if (dragInAir < 0f)
				dragInAir = baseDrag;
			if (angularDragInAir < 0f)
				angularDragInAir = baseAngularDrag;
			if (GolfBallController != null)
				baseAffectTimeSetting = GolfBallController.AffectsTimeScale;
		}

		public override void OnActivate()
		{
			base.OnActivate();
			IsKinematic = false;
			didShoot = false;
			if (GolfBallController != null)
				baseAffectTimeSetting = GolfBallController.AffectsTimeScale;
		}

		private void OnEnable()
		{
			Velocity = Vector3.zero;
			AngularVelocity = Vector3.zero;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnAimStart()
		{
			base.OnAimStart();
			isAiming = true;
			didShoot = false;
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
			didShoot = true;
			rotationStartupTimer = 0f;
			AngularVelocity = Vector3.zero;
			currentSpeedLossFromCollisions = 0f;
			Vector3 norm = boost.normalized;
			float mag = boost.magnitude;
			Vector3 horizontalBoost = new Vector3(norm.x * mag, 0f, norm.z * mag);
			lastBoostMagnitude = horizontalBoost.magnitude;
			lastShootVelocity = horizontalBoost.normalized * Mathf.Lerp(minShootVelocity, fullShootVelocity, horizontalBoost.magnitude);
			lastShootTime = LocalTime;
			isAiming = false;
			if (GolfBallController != null)
				GolfBallController.AffectsTimeScale = false;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision == null || collision.gameObject == null)
				return;

			if (!Mathf.Approximately(MaxSpeedLossOnHeadOnCollision, 0f))
			{
				Vector3 point = (collision.contacts != null && collision.contacts.Length > 0)
					? collision.contacts[0].point
					: collision.transform.position;
				Vector3 toHit = point - transform.position;
				float angle = Vector3.Angle(transform.forward, toHit);
				float factor = 1f - Mathf.Clamp01(angle / 90f);
				currentSpeedLossFromCollisions += factor * MaxSpeedLossOnHeadOnCollision;
				currentSpeedLossFromCollisions = Mathf.Clamp(currentSpeedLossFromCollisions, 0f, MaxSpeedLossOnHeadOnCollision);
			}

			int mask = NonKinematicCollisionLayer;
			if (mask == (mask | (1 << collision.gameObject.layer)))
			{
				IsKinematic = false;
			}
		}

		public override void OnReset()
		{
			base.OnReset();
			if (GolfBallController != null)
				GolfBallController.AffectsTimeScale = baseAffectTimeSetting;
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (setCoM != null)
			{
				if (Velocity.magnitude < 0.05f)
				{
					if (centerOfMassNoMotion != null)
						setCoM.UpdateCenterOfMass(centerOfMassNoMotion.position);
				}
				else
				{
					if (centerOfMassInMotion != null)
						setCoM.UpdateCenterOfMass(centerOfMassInMotion.position);
				}
			}

			if (clock != null)
			{
				clock.localTimeScale = (GolfBallController != null && GolfBallController.IsChangingTime)
					? (1f / Mathf.Max(0.0001f, Time.timeScale))
					: 1f;
			}

			Vector3 rayOrigin = transform.position + Vector3.up * 0.5f;
			int mask = ~LayerMask.GetMask("GolfBall");
			bool grounded = Physics.Raycast(rayOrigin, Vector3.down, raycastDist, mask, QueryTriggerInteraction.Ignore);

			if (grounded)
			{
				if (isAiming)
					rotationStartupTimer += Time.unscaledDeltaTime;

				Drag = baseDrag;
				AngularDrag = baseAngularDrag;
				if (GolfBallController != null)
					GolfBallController.isBlocking = false;

				Vector3 forward = transform.forward;
				float angleToTarget = Vector3.SignedAngle(forward, lastShootVelocity.normalized, Vector3.up);
				float forceFactor = Mathf.Clamp01(Mathf.Abs(angleToTarget) / 90f);
				float sideForceMag = Mathf.Lerp(AdjustForceRange.x, AdjustForceRange.y, forceFactor) * lastBoostMagnitude;
				Vector3 sideDir = (angleToTarget > 0f) ? transform.right : (-transform.right);
				if (frontForcePosition != null)
					AddForceAtPosition(sideDir * (sideForceMag * FixedDeltaTime), frontForcePosition.position, ForceMode.Force);

				if (didShoot && LocalTime < lastShootTime + keepGoingForwardTime)
				{
					if (GolfBallController != null)
						GolfBallController.CancelShooting();
					isAiming = false;
					AdjustRotation(lastShootVelocity.normalized, true);
					float curY = Velocity.y;
					Vector3 forwardVel = forward * (lastShootVelocity.magnitude * (1f - currentSpeedLossFromCollisions));
					Velocity = new Vector3(forwardVel.x, curY, forwardVel.z);
				}
				else if (!isEditorCar && GolfBallController != null)
				{
					GolfBallController.AffectsTimeScale = baseAffectTimeSetting;
				}

				if (Velocity.magnitude < 5f)
				{
					AddForce(Vector3.down * (FixedDeltaTime * 500f), ForceMode.Force);
				}
			}
			else
			{
				Drag = dragInAir;
				AngularDrag = angularDragInAir;
				if (GolfBallController != null)
					GolfBallController.isBlocking = true;

				if (didShoot && moveCarForwardIfNotGrounded && LocalTime < lastShootTime + keepGoingForwardTime)
				{
					Vector3 forward = transform.forward;
					AdjustRotation(lastShootVelocity.normalized, true);
					float curY = Velocity.y;
					Vector3 forwardVel = forward * (lastShootVelocity.magnitude * (1f - currentSpeedLossFromCollisions));
					Velocity = new Vector3(forwardVel.x, curY, forwardVel.z);
				}
			}
		}

		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
			if (timeline != null && timeline.rigidbody != null)
				timeline.rigidbody.AddForceAtPosition(force, position, forceMode);
			else if (rigidbodyC != null)
				rigidbodyC.AddForceAtPosition(force, position, forceMode);
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
