using Chronos;
using UnityEngine;

namespace Core
{
	public class GolfCarNoFollowAimShooter : GolfBallShooterBase
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
		private LayerMask NonKinematicCollisionLayer;

		[SerializeField]
		private bool moveCarForwardIfNotGrounded;

		[SerializeField]
		private float dragInAir;

		[SerializeField]
		private float angularDragInAir;

		public GolfBallController ballController;

		private float lastShootTime;

		private float lastBoostMagnitude;

		private float currentSpeedLossFromCollisions;

		private Vector3 lastShootVelocity;

		private bool isAiming;

		private float keepGoingForwardTime;

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

		public void TurnOfCar()
		{
		}

		private void Start()
		{
		}

		public override void OnActivate()
		{
		}

		private void OnEnable()
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
		base.OnShoot(boost);
		StandardShoot(boost, 15f, (minShootVelocity > 0f ? minShootVelocity : 5f), (fullShootVelocity > 0f ? fullShootVelocity : 22f), 5f);
	}

		private void OnCollisionEnter(Collision collision)
		{
		}

		public override void OnReset()
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}

		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}
	}
}
