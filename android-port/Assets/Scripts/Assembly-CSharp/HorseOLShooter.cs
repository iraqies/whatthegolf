using Audio;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000228")]
public class HorseOLShooter : GolfBallShooterBase
{
	[Token(Token = "0x4000ACC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public float fullShootVelocity;

	[Token(Token = "0x4000ACD")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public float minShootVelocity;

	[Token(Token = "0x4000ACE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float raycastDist;

	[Token(Token = "0x4000ACF")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Transform frontForcePosition;

	[Token(Token = "0x4000AD0")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector2 AdjustForceRange;

	[Token(Token = "0x4000AD1")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float AdjustRotationSpeed;

	[Token(Token = "0x4000AD2")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float AdjustRotationSpeedWhileDriving;

	[Token(Token = "0x4000AD3")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float AdjustRotationSpeedStartupTime;

	[Token(Token = "0x4000AD4")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private float MaxSpeedLossOnHeadOnCollision;

	[Token(Token = "0x4000AD5")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private LayerMask knockoutLayers;

	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	private bool moveCarForwardIfNotGrounded;

	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private float dragInAir;

	[Token(Token = "0x4000AD8")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	private float angularDragInAir;

	[Token(Token = "0x4000AD9")]
	[FieldOffset(Offset = "0xA0")]
	public GolfBallController ballController;

	[Token(Token = "0x4000ADA")]
	[FieldOffset(Offset = "0xA8")]
	private float lastShootTime;

	[Token(Token = "0x4000ADB")]
	[FieldOffset(Offset = "0xAC")]
	private float lastBoostMagnitude;

	[Token(Token = "0x4000ADC")]
	[FieldOffset(Offset = "0xB0")]
	private float currentSpeedLossFromCollisions;

	[Token(Token = "0x4000ADD")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 lastShootVelocity;

	[Token(Token = "0x4000ADE")]
	[FieldOffset(Offset = "0xC0")]
	private bool isAiming;

	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0xC4")]
	private float keepGoingForwardTime;

	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0xC8")]
	private bool didShoot;

	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0xCC")]
	private float rotationStartupTimer;

	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0xD0")]
	private float baseDrag;

	[Token(Token = "0x4000AE3")]
	[FieldOffset(Offset = "0xD4")]
	private float baseAngularDrag;

	[Token(Token = "0x4000AE4")]
	[FieldOffset(Offset = "0xD8")]
	private bool baseAffectTimeSetting;

	[Token(Token = "0x4000AE5")]
	[FieldOffset(Offset = "0xE0")]
	private Timeline timeline;

	[Token(Token = "0x4000AE6")]
	[FieldOffset(Offset = "0xE8")]
	private LocalClock clock;

	[Token(Token = "0x4000AE7")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private HorseRacer horseAnimatorController;

	[Token(Token = "0x4000AE8")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public float pitch;

	[Token(Token = "0x4000AE9")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public AnimationCurve powerToPitchWeightCurve;

	[Token(Token = "0x4000AEA")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public float spin;

	[Token(Token = "0x4000AEB")]
	[FieldOffset(Offset = "0x10C")]
	[SerializeField]
	public float jumpMinForce;

	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public float jumpMaxForce;

	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private ClipSettingsCollection reactionClips;

	[Token(Token = "0x4000AEE")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private ClipSettingsCollection bounceClips;

	[Token(Token = "0x4000AEF")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private float reactionDelay;

	[Token(Token = "0x4000AF0")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private Transform ragdoll;

	[Token(Token = "0x4000AF1")]
	[FieldOffset(Offset = "0x138")]
	private Rigidbody[] ragdollRigidbodies;

	[Token(Token = "0x4000AF2")]
	[FieldOffset(Offset = "0x140")]
	private Rigidbody ragdollRbRoot;

	[Token(Token = "0x4000AF3")]
	[FieldOffset(Offset = "0x148")]
	private Vector3[] ragdollRbLocalPositions;

	[Token(Token = "0x4000AF4")]
	[FieldOffset(Offset = "0x150")]
	private Quaternion[] ragdollRbLocalRotations;

	[Token(Token = "0x4000AF5")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000AF6")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private float minKnockoutForce;

	[Token(Token = "0x4000AF7")]
	[FieldOffset(Offset = "0x164")]
	[SerializeField]
	private float immunityDurationAfterKnockout;

	[Token(Token = "0x4000AF8")]
	[FieldOffset(Offset = "0x168")]
	private float lastKnockoutTime;

	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x16C")]
	private bool isKnockedOut;

	[Token(Token = "0x1700012D")]
	private float FixedDeltaTime
	{
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x14D7A68", Offset = "0x14D7A68", VA = "0x14D7A68")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700012E")]
	private float DeltaTime
	{
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x14D66B0", Offset = "0x14D66B0", VA = "0x14D66B0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700012F")]
	public Vector3 Velocity
	{
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x14D79B0", Offset = "0x14D79B0", VA = "0x14D79B0")]
		get
		{
			return default;
		}
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x14D6430", Offset = "0x14D6430", VA = "0x14D6430")]
		set
		{
		}
	}

	[Token(Token = "0x17000130")]
	public Vector3 AngularVelocity
	{
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x14D7D40", Offset = "0x14D7D40", VA = "0x14D7D40")]
		get
		{
			return default;
		}
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x14D6524", Offset = "0x14D6524", VA = "0x14D6524")]
		set
		{
		}
	}

	[Token(Token = "0x17000131")]
	public float Drag
	{
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x14D5F58", Offset = "0x14D5F58", VA = "0x14D5F58")]
		get
		{
			return default;
		}
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x14D77E8", Offset = "0x14D77E8", VA = "0x14D77E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000132")]
	public float AngularDrag
	{
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x14D6024", Offset = "0x14D6024", VA = "0x14D6024")]
		get
		{
			return default;
		}
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x14D78CC", Offset = "0x14D78CC", VA = "0x14D78CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000133")]
	public float LocalTime
	{
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x14D6388", Offset = "0x14D6388", VA = "0x14D6388")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000134")]
	public bool IsKinematic
	{
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x14D7DF8", Offset = "0x14D7DF8", VA = "0x14D7DF8")]
		get
		{
			return default;
		}
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x14D62C8", Offset = "0x14D62C8", VA = "0x14D62C8")]
		set
		{
		}
	}

	[Token(Token = "0x600099F")]
	[Address(RVA = "0x14D5CD0", Offset = "0x14D5CD0", VA = "0x14D5CD0")]
	private void Start()
	{
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x14D6268", Offset = "0x14D6268", VA = "0x14D6268", Slot = "4")]
	public override void OnActivate()
	{
	}

	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x14D6618", Offset = "0x14D6618", VA = "0x14D6618")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x14D6644", Offset = "0x14D6644", VA = "0x14D6644", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x14D68A0", Offset = "0x14D68A0", VA = "0x14D68A0", Slot = "5")]
	public override void OnAimStart()
	{
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x14D68D4", Offset = "0x14D68D4", VA = "0x14D68D4", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x14D6758", Offset = "0x14D6758", VA = "0x14D6758")]
	private void AdjustRotation(Vector3 dir, bool isDriving)
	{
	}

	[Token(Token = "0x60009A6")]
	[Address(RVA = "0x14D60F0", Offset = "0x14D60F0", VA = "0x14D60F0")]
	private void CopyTransformsFromTo(Rigidbody[] from, Vector3[] toPos, Quaternion[] toRot)
	{
	}

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x14D68FC", Offset = "0x14D68FC", VA = "0x14D68FC")]
	private void CopyTransformsFromTo(Vector3[] fromPos, Quaternion[] fromRot, Rigidbody[] to)
	{
	}

	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x14D61EC", Offset = "0x14D61EC", VA = "0x14D61EC")]
	private void SetRagdollRbState(bool kinematic)
	{
	}

	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x14D69FC", Offset = "0x14D69FC", VA = "0x14D69FC", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x14D6CD0", Offset = "0x14D6CD0", VA = "0x14D6CD0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x14D6E68", Offset = "0x14D6E68", VA = "0x14D6E68", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x60009AC")]
	[Address(RVA = "0x14D6F30", Offset = "0x14D6F30", VA = "0x14D6F30", Slot = "12")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x14D7B10", Offset = "0x14D7B10", VA = "0x14D7B10")]
	private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
	{
	}

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x14D7C40", Offset = "0x14D7C40", VA = "0x14D7C40")]
	private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
	{
	}

	[Token(Token = "0x60009BC")]
	[Address(RVA = "0x14D7EB0", Offset = "0x14D7EB0", VA = "0x14D7EB0")]
	public HorseOLShooter()
	{
	}
}
