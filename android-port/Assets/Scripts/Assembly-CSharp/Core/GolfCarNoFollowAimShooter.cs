using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001455")]
	public class GolfCarNoFollowAimShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006EA2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006EA3")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006EA4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float raycastDist;

		[Token(Token = "0x4006EA5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform frontForcePosition;

		[Token(Token = "0x4006EA6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 AdjustForceRange;

		[Token(Token = "0x4006EA7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006EA8")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4006EA9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float AdjustRotationSpeedStartupTime;

		[Token(Token = "0x4006EAA")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float MaxSpeedLossOnHeadOnCollision;

		[Token(Token = "0x4006EAB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private LayerMask NonKinematicCollisionLayer;

		[Token(Token = "0x4006EAC")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool moveCarForwardIfNotGrounded;

		[Token(Token = "0x4006EAD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float dragInAir;

		[Token(Token = "0x4006EAE")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float angularDragInAir;

		[Token(Token = "0x4006EAF")]
		[FieldOffset(Offset = "0xA0")]
		public GolfBallController ballController;

		[Token(Token = "0x4006EB0")]
		[FieldOffset(Offset = "0xA8")]
		private float lastShootTime;

		[Token(Token = "0x4006EB1")]
		[FieldOffset(Offset = "0xAC")]
		private float lastBoostMagnitude;

		[Token(Token = "0x4006EB2")]
		[FieldOffset(Offset = "0xB0")]
		private float currentSpeedLossFromCollisions;

		[Token(Token = "0x4006EB3")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006EB4")]
		[FieldOffset(Offset = "0xC0")]
		private bool isAiming;

		[Token(Token = "0x4006EB5")]
		[FieldOffset(Offset = "0xC4")]
		private float keepGoingForwardTime;

		[Token(Token = "0x4006EB6")]
		[FieldOffset(Offset = "0xC8")]
		private bool didShoot;

		[Token(Token = "0x4006EB7")]
		[FieldOffset(Offset = "0xCC")]
		private float rotationStartupTimer;

		[Token(Token = "0x4006EB8")]
		[FieldOffset(Offset = "0xD0")]
		private float baseDrag;

		[Token(Token = "0x4006EB9")]
		[FieldOffset(Offset = "0xD4")]
		private float baseAngularDrag;

		[Token(Token = "0x4006EBA")]
		[FieldOffset(Offset = "0xD8")]
		private bool baseAffectTimeSetting;

		[Token(Token = "0x4006EBB")]
		[FieldOffset(Offset = "0xE0")]
		private Timeline timeline;

		[Token(Token = "0x4006EBC")]
		[FieldOffset(Offset = "0xE8")]
		private LocalClock clock;

		[Token(Token = "0x4006EBD")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool isEditorCar;

		[Token(Token = "0x4006EBE")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private SetCenterOfMass setCoM;

		[Token(Token = "0x4006EBF")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Transform centerOfMassInMotion;

		[Token(Token = "0x4006EC0")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform centerOfMassNoMotion;

		[Token(Token = "0x17000ACF")]
		private float FixedDeltaTime
		{
			[Token(Token = "0x6005F4B")]
			[Address(RVA = "0x149B820", Offset = "0x149B820", VA = "0x149B820")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AD0")]
		private float DeltaTime
		{
			[Token(Token = "0x6005F4C")]
			[Address(RVA = "0x149A928", Offset = "0x149A928", VA = "0x149A928")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AD1")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6005F4D")]
			[Address(RVA = "0x149B768", Offset = "0x149B768", VA = "0x149B768")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F4E")]
			[Address(RVA = "0x149A6D4", Offset = "0x149A6D4", VA = "0x149A6D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD2")]
		public Vector3 AngularVelocity
		{
			[Token(Token = "0x6005F4F")]
			[Address(RVA = "0x149BAF8", Offset = "0x149BAF8", VA = "0x149BAF8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F50")]
			[Address(RVA = "0x149A7C8", Offset = "0x149A7C8", VA = "0x149A7C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD3")]
		public float Drag
		{
			[Token(Token = "0x6005F51")]
			[Address(RVA = "0x149A374", Offset = "0x149A374", VA = "0x149A374")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F52")]
			[Address(RVA = "0x149B5A0", Offset = "0x149B5A0", VA = "0x149B5A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD4")]
		public float AngularDrag
		{
			[Token(Token = "0x6005F53")]
			[Address(RVA = "0x149A440", Offset = "0x149A440", VA = "0x149A440")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F54")]
			[Address(RVA = "0x149B684", Offset = "0x149B684", VA = "0x149B684")]
			set
			{
			}
		}

		[Token(Token = "0x17000AD5")]
		public float LocalTime
		{
			[Token(Token = "0x6005F55")]
			[Address(RVA = "0x149A62C", Offset = "0x149A62C", VA = "0x149A62C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AD6")]
		public bool IsKinematic
		{
			[Token(Token = "0x6005F56")]
			[Address(RVA = "0x149BBB0", Offset = "0x149BBB0", VA = "0x149BBB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F57")]
			[Address(RVA = "0x149A56C", Offset = "0x149A56C", VA = "0x149A56C")]
			set
			{
			}
		}

		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0x149A298", Offset = "0x149A298", VA = "0x149A298")]
		public void TurnOfCar()
		{
		}

		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0x149A2A0", Offset = "0x149A2A0", VA = "0x149A2A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6005F3F")]
		[Address(RVA = "0x149A50C", Offset = "0x149A50C", VA = "0x149A50C", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F40")]
		[Address(RVA = "0x149A8BC", Offset = "0x149A8BC", VA = "0x149A8BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005F41")]
		[Address(RVA = "0x149A8E8", Offset = "0x149A8E8", VA = "0x149A8E8", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F42")]
		[Address(RVA = "0x149A9D0", Offset = "0x149A9D0", VA = "0x149A9D0", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005F43")]
		[Address(RVA = "0x149AA40", Offset = "0x149AA40", VA = "0x149AA40", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005F44")]
		[Address(RVA = "0x149AA68", Offset = "0x149AA68", VA = "0x149AA68")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6005F45")]
		[Address(RVA = "0x149AAFC", Offset = "0x149AAFC", VA = "0x149AAFC", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F46")]
		[Address(RVA = "0x149AC28", Offset = "0x149AC28", VA = "0x149AC28")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005F47")]
		[Address(RVA = "0x149AF08", Offset = "0x149AF08", VA = "0x149AF08", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6005F48")]
		[Address(RVA = "0x149AF70", Offset = "0x149AF70", VA = "0x149AF70", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F49")]
		[Address(RVA = "0x149B8C8", Offset = "0x149B8C8", VA = "0x149B8C8")]
		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0x149B9F8", Offset = "0x149B9F8", VA = "0x149B9F8")]
		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Token(Token = "0x6005F58")]
		[Address(RVA = "0x149BC68", Offset = "0x149BC68", VA = "0x149BC68")]
		public GolfCarNoFollowAimShooter()
		{
		}
	}
}
