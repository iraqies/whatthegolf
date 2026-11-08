using Chronos;
using UnityEngine;

namespace Core
{
	public class s22_PodRacerShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		private float raycastDist;

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
		private float MaxSpeedLossOnHeadOnCollision;

		[SerializeField]
		private float MaxVelocity;

		[SerializeField]
		private float MinVelocity;

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

		private float FixedDeltaTime => 0f;

		private float DeltaTime => 0f;

		public Vector3 Velocity
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Vector3 AngularVelocity
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float Drag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AngularDrag
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float LocalTime => 0f;

		public bool IsKinematic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override void OnActivate()
		{
		}

		private void Start()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnAimStart()
		{
		}

		public override void OnCancel()
		{
		}

		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}

		private void OnCollisionEnter(Collision collision)
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}

		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		private void AddRelativeTorque(Vector3 torque, ForceMode forceMode)
		{
		}

		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}
	}
}
