using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001456")]
	public class GolfCarShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006EC1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006EC2")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006EC3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float raycastDist;

		[Token(Token = "0x4006EC4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform frontForcePosition;

		[Token(Token = "0x4006EC5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 AdjustForceRange;

		[Token(Token = "0x4006EC6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006EC7")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4006EC8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float AdjustRotationSpeedStartupTime;

		[Token(Token = "0x4006EC9")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float MaxSpeedLossOnHeadOnCollision;

		[Token(Token = "0x4006ECA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private LayerMask NonKinematicCollisionLayer;

		[Token(Token = "0x4006ECB")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool moveCarForwardIfNotGrounded;

		[Token(Token = "0x4006ECC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float dragInAir;

		[Token(Token = "0x4006ECD")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float angularDragInAir;

		[Token(Token = "0x4006ECE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private bool canRotate;

		[Token(Token = "0x4006ECF")]
		[FieldOffset(Offset = "0xA8")]
		public GolfBallController ballController;

		[Token(Token = "0x4006ED0")]
		[FieldOffset(Offset = "0xB0")]
		private float lastShootTime;

		[Token(Token = "0x4006ED1")]
		[FieldOffset(Offset = "0xB4")]
		private float lastBoostMagnitude;

		[Token(Token = "0x4006ED2")]
		[FieldOffset(Offset = "0xB8")]
		private float currentSpeedLossFromCollisions;

		[Token(Token = "0x4006ED3")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006ED4")]
		[FieldOffset(Offset = "0xC8")]
		private bool isAiming;

		[Token(Token = "0x4006ED5")]
		[FieldOffset(Offset = "0xCC")]
		private float keepGoingForwardTime;

		[Token(Token = "0x4006ED6")]
		[FieldOffset(Offset = "0xD0")]
		private bool didShoot;

		[Token(Token = "0x4006ED7")]
		[FieldOffset(Offset = "0xD4")]
		private float rotationStartupTimer;

		[Token(Token = "0x4006ED8")]
		[FieldOffset(Offset = "0xD8")]
		private float baseDrag;

		[Token(Token = "0x4006ED9")]
		[FieldOffset(Offset = "0xDC")]
		private float baseAngularDrag;

		[Token(Token = "0x4006EDA")]
		[FieldOffset(Offset = "0xE0")]
		private bool baseAffectTimeSetting;

		[Token(Token = "0x4006EDB")]
		[FieldOffset(Offset = "0xE8")]
		private Timeline timeline;

		[Token(Token = "0x4006EDC")]
		[FieldOffset(Offset = "0xF0")]
		private LocalClock clock;

		[Token(Token = "0x4006EDD")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool isEditorCar;

		[Token(Token = "0x4006EDE")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private SetCenterOfMass setCoM;

		[Token(Token = "0x4006EDF")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Transform centerOfMassInMotion;

		[Token(Token = "0x4006EE0")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Transform centerOfMassNoMotion;

		[Token(Token = "0x17000AD7")]
		private float FixedDeltaTime
		{
			[Token(Token = "0x6005F68")]
			[Address(RVA = "0x149D3B0", Offset = "0x149D3B0", VA = "0x149D3B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AD8")]
		private float DeltaTime
		{
			[Token(Token = "0x6005F69")]
			[Address(RVA = "0x149C38C", Offset = "0x149C38C", VA = "0x149C38C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AD9")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6005F6A")]
			[Address(RVA = "0x149D2F8", Offset = "0x149D2F8", VA = "0x149D2F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F6B")]
			[Address(RVA = "0x149C100", Offset = "0x149C100", VA = "0x149C100")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADA")]
		public Vector3 AngularVelocity
		{
			[Token(Token = "0x6005F6C")]
			[Address(RVA = "0x149D688", Offset = "0x149D688", VA = "0x149D688")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F6D")]
			[Address(RVA = "0x149C1F4", Offset = "0x149C1F4", VA = "0x149C1F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADB")]
		public float Drag
		{
			[Token(Token = "0x6005F6E")]
			[Address(RVA = "0x149BDA0", Offset = "0x149BDA0", VA = "0x149BDA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F6F")]
			[Address(RVA = "0x149D130", Offset = "0x149D130", VA = "0x149D130")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADC")]
		public float AngularDrag
		{
			[Token(Token = "0x6005F70")]
			[Address(RVA = "0x149BE6C", Offset = "0x149BE6C", VA = "0x149BE6C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F71")]
			[Address(RVA = "0x149D214", Offset = "0x149D214", VA = "0x149D214")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADD")]
		public float LocalTime
		{
			[Token(Token = "0x6005F72")]
			[Address(RVA = "0x149C058", Offset = "0x149C058", VA = "0x149C058")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000ADE")]
		public bool IsKinematic
		{
			[Token(Token = "0x6005F73")]
			[Address(RVA = "0x149D740", Offset = "0x149D740", VA = "0x149D740")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005F74")]
			[Address(RVA = "0x149BF98", Offset = "0x149BF98", VA = "0x149BF98")]
			set
			{
			}
		}

		[Token(Token = "0x6005F59")]
		[Address(RVA = "0x149BCBC", Offset = "0x149BCBC", VA = "0x149BCBC")]
		public void SetCanRotate(bool b)
		{
		}

		[Token(Token = "0x6005F5A")]
		[Address(RVA = "0x149BCC4", Offset = "0x149BCC4", VA = "0x149BCC4")]
		public void TurnOfCar()
		{
		}

		[Token(Token = "0x6005F5B")]
		[Address(RVA = "0x149BCCC", Offset = "0x149BCCC", VA = "0x149BCCC")]
		private void Start()
		{
		}

		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0x149BF38", Offset = "0x149BF38", VA = "0x149BF38", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0x149C2E8", Offset = "0x149C2E8", VA = "0x149C2E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0x149C314", Offset = "0x149C314", VA = "0x149C314", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F5F")]
		[Address(RVA = "0x149C578", Offset = "0x149C578", VA = "0x149C578", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005F60")]
		[Address(RVA = "0x149C5E8", Offset = "0x149C5E8", VA = "0x149C5E8", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005F61")]
		[Address(RVA = "0x149C434", Offset = "0x149C434", VA = "0x149C434")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6005F62")]
		[Address(RVA = "0x149C610", Offset = "0x149C610", VA = "0x149C610", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F63")]
		[Address(RVA = "0x149C73C", Offset = "0x149C73C", VA = "0x149C73C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x149CA1C", Offset = "0x149CA1C", VA = "0x149CA1C", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6005F65")]
		[Address(RVA = "0x149CA84", Offset = "0x149CA84", VA = "0x149CA84", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F66")]
		[Address(RVA = "0x149D458", Offset = "0x149D458", VA = "0x149D458")]
		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6005F67")]
		[Address(RVA = "0x149D588", Offset = "0x149D588", VA = "0x149D588")]
		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Token(Token = "0x6005F75")]
		[Address(RVA = "0x149D7F8", Offset = "0x149D7F8", VA = "0x149D7F8")]
		public GolfCarShooter()
		{
		}
	}
}
