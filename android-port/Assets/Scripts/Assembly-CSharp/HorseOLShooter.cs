using Audio;
using Chronos;
using Core;
using UnityEngine;

public class HorseOLShooter : GolfBallShooterBase
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
	private LayerMask knockoutLayers;

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
	private HorseRacer horseAnimatorController;

	[SerializeField]
	public float pitch;

	[SerializeField]
	public AnimationCurve powerToPitchWeightCurve;

	[SerializeField]
	public float spin;

	[SerializeField]
	public float jumpMinForce;

	[SerializeField]
	public float jumpMaxForce;

	[SerializeField]
	private ClipSettingsCollection reactionClips;

	[SerializeField]
	private ClipSettingsCollection bounceClips;

	[SerializeField]
	private float reactionDelay;

	[SerializeField]
	private Transform ragdoll;

	private Rigidbody[] ragdollRigidbodies;

	private Rigidbody ragdollRbRoot;

	private Vector3[] ragdollRbLocalPositions;

	private Quaternion[] ragdollRbLocalRotations;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private float minKnockoutForce;

	[SerializeField]
	private float immunityDurationAfterKnockout;

	private float lastKnockoutTime;

	private bool isKnockedOut;

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

	private void CopyTransformsFromTo(Rigidbody[] from, Vector3[] toPos, Quaternion[] toRot)
	{
	}

	private void CopyTransformsFromTo(Vector3[] fromPos, Quaternion[] fromRot, Rigidbody[] to)
	{
	}

	private void SetRagdollRbState(bool kinematic)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	public override void OnReset()
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
	{
	}

	private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
	{
	}
}
