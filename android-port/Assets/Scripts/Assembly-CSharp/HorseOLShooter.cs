using Audio;
using Chronos;
using Core;
using UnityEngine;

public class HorseOLShooter : GolfBallShooterBase
{
	[SerializeField]
	public float fullShootVelocity = 25f;

	[SerializeField]
	public float minShootVelocity;

	[SerializeField]
	private float raycastDist = 3f;

	[SerializeField]
	private Transform frontForcePosition;

	[SerializeField]
	private Vector2 AdjustForceRange = new Vector2(5500f, 8500f);

	[SerializeField]
	private float AdjustRotationSpeed = 700f;

	[SerializeField]
	private float AdjustRotationSpeedWhileDriving = 700f;

	[SerializeField]
	private float AdjustRotationSpeedStartupTime;

	[SerializeField]
	private float MaxSpeedLossOnHeadOnCollision;

	[SerializeField]
	private LayerMask knockoutLayers;

	[SerializeField]
	private bool moveCarForwardIfNotGrounded = true;

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

	private float keepGoingForwardTime = 1f;

	private bool didShoot;

	private float rotationStartupTimer = 1f;

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
	public AnimationCurve powerToPitchWeightCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);

	[SerializeField]
	public float spin;

	[SerializeField]
	public float jumpMinForce = 20f;

	[SerializeField]
	public float jumpMaxForce = 50f;

	[SerializeField]
	private ClipSettingsCollection reactionClips;

	[SerializeField]
	private ClipSettingsCollection bounceClips;

	[SerializeField]
	private float reactionDelay = 0.2f;

	[SerializeField]
	private Transform ragdoll;

	private Rigidbody[] ragdollRigidbodies;

	private Rigidbody ragdollRbRoot;

	private Vector3[] ragdollRbLocalPositions;

	private Quaternion[] ragdollRbLocalRotations;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private float minKnockoutForce = 100f;

	[SerializeField]
	private float immunityDurationAfterKnockout = 0.5f;

	private float lastKnockoutTime = -1000f;

	private bool isKnockedOut;

	private float FixedDeltaTime
	{
		get
		{
			if (timeline == null)
			{
				return Time.fixedUnscaledDeltaTime;
			}
			return timeline.fixedDeltaTime;
		}
	}

	private float DeltaTime
	{
		get
		{
			if (timeline == null)
			{
				return Time.deltaTime;
			}
			return timeline.deltaTime;
		}
	}

	public Vector3 Velocity
	{
		get
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					return rigid.velocity;
				}
				return Vector3.zero;
			}
			if (timeline.rigidbody != null)
			{
				return timeline.rigidbody.velocity;
			}
			return Vector3.zero;
		}
		set
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					rigid.velocity = value;
				}
			}
			else if (timeline.rigidbody != null)
			{
				timeline.rigidbody.velocity = value;
			}
		}
	}

	public Vector3 AngularVelocity
	{
		get
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					return rigid.angularVelocity;
				}
				return Vector3.zero;
			}
			if (timeline.rigidbody != null)
			{
				return timeline.rigidbody.angularVelocity;
			}
			return Vector3.zero;
		}
		set
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					rigid.angularVelocity = value;
				}
			}
			else if (timeline.rigidbody != null)
			{
				timeline.rigidbody.angularVelocity = value;
			}
		}
	}

	public float Drag
	{
		get
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					return rigid.drag;
				}
				return 0f;
			}
			if (timeline.rigidbody != null && timeline.rigidbody.component != null)
			{
				return timeline.rigidbody.component.drag;
			}
			return 0f;
		}
		set
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					rigid.drag = value;
				}
			}
			else if (timeline.rigidbody != null && timeline.rigidbody.component != null)
			{
				timeline.rigidbody.component.drag = value;
			}
		}
	}

	public float AngularDrag
	{
		get
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					return rigid.angularDrag;
				}
				return 0f;
			}
			if (timeline.rigidbody != null && timeline.rigidbody.component != null)
			{
				return timeline.rigidbody.component.angularDrag;
			}
			return 0f;
		}
		set
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					rigid.angularDrag = value;
				}
			}
			else if (timeline.rigidbody != null && timeline.rigidbody.component != null)
			{
				timeline.rigidbody.component.angularDrag = value;
			}
		}
	}

	public float LocalTime
	{
		get
		{
			if (timeline == null)
			{
				return Time.time;
			}
			return timeline.time;
		}
	}

	public bool IsKinematic
	{
		get
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					return rigid.isKinematic;
				}
				return false;
			}
			if (timeline.rigidbody != null)
			{
				return timeline.rigidbody.isKinematic;
			}
			return false;
		}
		set
		{
			if (timeline == null)
			{
				if (rigid != null)
				{
					rigid.isKinematic = value;
				}
			}
			else if (timeline.rigidbody != null)
			{
				timeline.rigidbody.isKinematic = value;
			}
		}
	}

	private void Start()
	{
		timeline = GetComponent<Timeline>();
		clock = GetComponent<LocalClock>();
		baseDrag = Drag;
		baseAngularDrag = AngularDrag;
		if (dragInAir < 0f)
		{
			dragInAir = baseDrag;
		}
		if (angularDragInAir < 0f)
		{
			angularDragInAir = baseAngularDrag;
		}
		if (GolfBallController != null)
		{
			baseAffectTimeSetting = GolfBallController.UseRigidbodyTimeline;
			GolfBallController.UseRigidbodyTimeline = false;
		}
		if (ragdoll == null)
		{
			return;
		}
		Collider[] componentsInChildren = ragdoll.GetComponentsInChildren<Collider>();
		Collider[] componentsInChildren2 = GetComponentsInChildren<Collider>();
		if (componentsInChildren2 != null && componentsInChildren != null)
		{
			for (int i = 0; i < componentsInChildren2.Length; i++)
			{
				for (int j = 0; j < componentsInChildren.Length; j++)
				{
					Physics.IgnoreCollision(componentsInChildren[j], componentsInChildren2[i]);
				}
			}
		}
		ragdollRigidbodies = ragdoll.GetComponentsInChildren<Rigidbody>();
		if (ragdollRigidbodies != null)
		{
			ragdollRbLocalPositions = new Vector3[ragdollRigidbodies.Length];
			ragdollRbLocalRotations = new Quaternion[ragdollRigidbodies.Length];
			CopyTransformsFromTo(ragdollRigidbodies, ragdollRbLocalPositions, ragdollRbLocalRotations);
			SetRagdollRbState(true);
		}
	}

	public override void OnActivate()
	{
		base.OnActivate();
		IsKinematic = false;
		lastShootTime = LocalTime - 10f;
		Velocity = Vector3.zero;
		AngularVelocity = Vector3.zero;
	}

	private void OnEnable()
	{
		lastShootTime = LocalTime - 10f;
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (!onlyAimArrow)
		{
			rotationStartupTimer += DeltaTime;
			AdjustRotation(boost, false);
			isAiming = true;
		}
	}

	public override void OnAimStart()
	{
		base.OnAimStart();
		if (AdjustRotationSpeedStartupTime > 0f)
		{
			rotationStartupTimer = 0f;
		}
	}

	public override void OnCancel()
	{
		base.OnCancel();
		isAiming = false;
	}

	private void AdjustRotation(Vector3 dir, bool isDriving)
	{
		if ((double)dir.magnitude > 0.3 && rigid != null)
		{
			dir.y = 0f;
			float num = (isDriving ? AdjustRotationSpeedWhileDriving : AdjustRotationSpeed);
			Quaternion to = Quaternion.LookRotation(dir.normalized);
			Quaternion rotation = rigid.rotation;
			float num2 = 1f;
			if (AdjustRotationSpeedStartupTime > 0f)
			{
				num2 = Mathf.Clamp01(rotationStartupTimer / AdjustRotationSpeedStartupTime);
			}
			float maxDegreesDelta = num * Time.fixedUnscaledDeltaTime * num2;
			rigid.MoveRotation(Quaternion.RotateTowards(rotation, to, maxDegreesDelta));
		}
	}

	private void CopyTransformsFromTo(Rigidbody[] from, Vector3[] toPos, Quaternion[] toRot)
	{
		if (from == null)
		{
			return;
		}
		for (int i = 0; i < from.Length; i++)
		{
			if (from[i] != null)
			{
				toPos[i] = from[i].transform.localPosition;
				toRot[i] = from[i].transform.localRotation;
			}
		}
	}

	private void CopyTransformsFromTo(Vector3[] fromPos, Quaternion[] fromRot, Rigidbody[] to)
	{
		if (to == null)
		{
			return;
		}
		for (int i = 0; i < to.Length; i++)
		{
			if (to[i] != null)
			{
				to[i].transform.localPosition = fromPos[i];
				to[i].transform.localRotation = fromRot[i];
			}
		}
	}

	private void SetRagdollRbState(bool kinematic)
	{
		if (ragdollRigidbodies == null)
		{
			return;
		}
		for (int i = 0; i < ragdollRigidbodies.Length; i++)
		{
			if (ragdollRigidbodies[i] != null)
			{
				ragdollRigidbodies[i].isKinematic = kinematic;
			}
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		AngularVelocity = Vector3.zero;
		Vector3 normalized = boost.normalized;
		float d = Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude);
		lastShootVelocity = normalized * d;
		Velocity = lastShootVelocity;
		lastShootTime = LocalTime;
		keepGoingForwardTime = float.PositiveInfinity;
		lastBoostMagnitude = boost.magnitude;
		didShoot = true;
		currentSpeedLossFromCollisions = 0f;
		if (GolfBallController != null)
		{
			GolfBallController.UseRigidbodyTimeline = baseAffectTimeSetting;
		}
		isKnockedOut = false;
		SetRagdollRbState(true);
		CopyTransformsFromTo(ragdollRbLocalPositions, ragdollRbLocalRotations, ragdollRigidbodies);
		if (horseAnimatorController != null)
		{
			horseAnimatorController.enabled = true;
		}
		if (animator != null)
		{
			animator.enabled = true;
		}
		if (horseAnimatorController != null)
		{
			horseAnimatorController.Jump();
		}
		Vector3 axis = Vector3.Cross(boost, Vector3.up);
		boost = Quaternion.AngleAxis(pitch, axis) * boost;
		if (rigid != null)
		{
			float d2 = Mathf.Lerp(jumpMinForce, jumpMaxForce, boost.magnitude);
			rigid.AddForce(boost * d2, ForceMode.Impulse);
		}
		if (bounceClips != null)
		{
			bounceClips.Play(base.transform.position, 1f, 1f);
		}
		if (reactionClips != null && rigid != null)
		{
			reactionClips.PlayDelayed(rigid.position, reactionDelay, 1f, 1f);
		}
		if (rigid != null)
		{
			rigid.constraints = (RigidbodyConstraints)80;
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
		{
			return;
		}
		int value = knockoutLayers.value;
		if (value == (value | (1 << collision.gameObject.layer)))
		{
			float time = Time.time;
			if (collision.impulse.magnitude > minKnockoutForce && time - lastKnockoutTime > immunityDurationAfterKnockout)
			{
				SetRagdollRbState(false);
				if (horseAnimatorController != null)
				{
					horseAnimatorController.enabled = false;
				}
				if (animator != null)
				{
					animator.enabled = false;
				}
				didShoot = false;
				lastKnockoutTime = Time.time;
				isKnockedOut = true;
				if (rigid != null)
				{
					rigid.constraints = RigidbodyConstraints.FreezeRotation;
				}
			}
		}
	}

	public override void OnReset()
	{
		didShoot = false;
		if (ballController != null)
		{
			ballController.affectTime = false;
		}
		SetRagdollRbState(true);
		CopyTransformsFromTo(ragdollRbLocalPositions, ragdollRbLocalRotations, ragdollRigidbodies);
		if (horseAnimatorController != null)
		{
			horseAnimatorController.enabled = true;
		}
		if (animator != null)
		{
			animator.enabled = true;
		}
		isKnockedOut = false;
	}

	protected override void FixedUpdate()
	{
		if (clock != null && GolfBallController != null)
		{
			float b = (GolfBallController.isAiming ? 0.3f : 1f);
			float num = ((b > clock.localTimeScale) ? 1000f : 10f);
			clock.localTimeScale = Mathf.Lerp(clock.localTimeScale, b, clock.localTimeScale * num);
		}
		Vector3 origin = base.transform.position + Vector3.up * 0.5f;
		int layerMask = ~LayerMask.GetMask("GolfBall");
		if (Physics.Raycast(origin, Vector3.down, raycastDist, layerMask, QueryTriggerInteraction.Ignore))
		{
			Drag = baseDrag;
			AngularDrag = baseAngularDrag;
			if (ballController != null)
			{
				ballController.affectTime = false;
			}
			Debug.DrawRay(base.transform.position + Vector3.up * 0.5f, Vector3.down * raycastDist, Color.blue);
		}
		else
		{
			Drag = dragInAir;
			AngularDrag = angularDragInAir;
			if (ballController != null)
			{
				ballController.affectTime = true;
			}
			Debug.DrawRay(base.transform.position + Vector3.up * 0.5f, Vector3.down * raycastDist, Color.red);
		}
		if (!didShoot)
		{
			Velocity = Vector3.zero;
			return;
		}
		float num2 = Mathf.Lerp(AdjustForceRange.x, AdjustForceRange.y, lastBoostMagnitude);
		float num3 = currentSpeedLossFromCollisions;
		float num4 = LocalTime - lastShootTime;
		if (didShoot && !isAiming && num4 >= 0f && num4 < 0.3f && Vector3.Angle(Velocity, base.transform.forward) > 1f)
		{
			AdjustRotation(Velocity, true);
		}
		if (didShoot && num4 >= 0f && num4 < keepGoingForwardTime && (moveCarForwardIfNotGrounded || (ballController != null && !ballController.BlockShooting)))
		{
			Vector3 vector = new Vector3(base.transform.forward.x, 0f, base.transform.forward.z);
			if (isAiming)
			{
				vector = new Vector3(Velocity.x, 0f, Velocity.z);
			}
			vector.Normalize();
			if (frontForcePosition != null)
			{
				Vector3 force = vector * (num2 * (1f - num3)) * FixedDeltaTime;
				AddForceAtPosition(force, frontForcePosition.position, ForceMode.Acceleration);
			}
		}
		if (goalPullForce > 0f && Level.Instance != null && Level.Instance.Goal != null && rigid != null && GolfBallController != null && GolfBallController.enabled)
		{
			if (Vector3.Distance(base.transform.position, Level.Instance.Goal.transform.position) <= goalPullDistance && Vector3.Angle(Velocity, Level.Instance.Goal.transform.position - base.transform.position) < angleThreshold)
			{
				Vector3 normalized = (Level.Instance.Goal.transform.position - base.transform.position).normalized;
				AddForce(normalized * goalPullForce, ForceMode.Force);
			}
		}
		if (rigid != null)
		{
			Vector3 eulerAngles = rigid.rotation.eulerAngles;
			rigid.MoveRotation(Quaternion.Euler(0f, eulerAngles.y, 0f));
		}
		if (ragdoll != null)
		{
			ragdoll.position = base.transform.position;
			ragdoll.rotation = base.transform.rotation;
		}
	}

	private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
	{
		if (timeline == null)
		{
			if (rigid != null)
			{
				rigid.AddForceAtPosition(force, position, forceMode);
			}
		}
		else if (timeline.rigidbody != null)
		{
			timeline.rigidbody.AddForceAtPosition(force, position, forceMode);
		}
	}

	private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
	{
		if (timeline == null)
		{
			if (rigid != null)
			{
				rigid.AddForce(force, forceMode);
			}
		}
		else if (timeline.rigidbody != null)
		{
			timeline.rigidbody.AddForce(force, forceMode);
		}
	}
}
