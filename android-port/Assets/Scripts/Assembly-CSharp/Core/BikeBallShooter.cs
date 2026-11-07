using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001447")]
	public class BikeBallShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006E0E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006E0F")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006E10")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float raycastDist;

		[Token(Token = "0x4006E11")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform frontForcePosition;

		[Token(Token = "0x4006E12")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 AdjustForceRange;

		[Token(Token = "0x4006E13")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006E14")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4006E15")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float AdjustRotationSpeedStartupTime;

		[Token(Token = "0x4006E16")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float MaxSpeedLossOnHeadOnCollision;

		[Token(Token = "0x4006E17")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float jumpHeightMod;

		[Token(Token = "0x4006E18")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float MaxVelocity;

		[Token(Token = "0x4006E19")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float MinVelocity;

		[Token(Token = "0x4006E1A")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private LayerMask GroundCheckMask;

		[Token(Token = "0x4006E1B")]
		[FieldOffset(Offset = "0xA0")]
		public GolfBallController ballController;

		[Token(Token = "0x4006E1C")]
		[FieldOffset(Offset = "0xA8")]
		private float lastBoostMagnitude;

		[Token(Token = "0x4006E1D")]
		[FieldOffset(Offset = "0xAC")]
		private float currentSpeedLossFromCollisions;

		[Token(Token = "0x4006E1E")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006E1F")]
		[FieldOffset(Offset = "0xBC")]
		private bool isAiming;

		[Token(Token = "0x4006E20")]
		[FieldOffset(Offset = "0xBD")]
		private bool didAim;

		[Token(Token = "0x4006E21")]
		[FieldOffset(Offset = "0xC0")]
		private float rotationStartupTimer;

		[Token(Token = "0x4006E22")]
		[FieldOffset(Offset = "0xC8")]
		private LocalClock clock;

		[Token(Token = "0x4006E23")]
		[FieldOffset(Offset = "0xD0")]
		private Timeline timeline;

		[Token(Token = "0x4006E24")]
		[FieldOffset(Offset = "0xD8")]
		private float timeGrounded;

		[Token(Token = "0x17000AC2")]
		private float FixedDeltaTime
		{
			[Token(Token = "0x6005EDF")]
			[Address(RVA = "0x160FE1C", Offset = "0x160FE1C", VA = "0x160FE1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AC3")]
		private float DeltaTime
		{
			[Token(Token = "0x6005EE0")]
			[Address(RVA = "0x160EFD8", Offset = "0x160EFD8", VA = "0x160EFD8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AC4")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6005EE1")]
			[Address(RVA = "0x160FD64", Offset = "0x160FD64", VA = "0x160FD64")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005EE2")]
			[Address(RVA = "0x160ED04", Offset = "0x160ED04", VA = "0x160ED04")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC5")]
		public Vector3 AngularVelocity
		{
			[Token(Token = "0x6005EE3")]
			[Address(RVA = "0x16100F4", Offset = "0x16100F4", VA = "0x16100F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005EE4")]
			[Address(RVA = "0x160EDF8", Offset = "0x160EDF8", VA = "0x160EDF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC6")]
		public float Drag
		{
			[Token(Token = "0x6005EE5")]
			[Address(RVA = "0x16101AC", Offset = "0x16101AC", VA = "0x16101AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005EE6")]
			[Address(RVA = "0x1610278", Offset = "0x1610278", VA = "0x1610278")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC7")]
		public float AngularDrag
		{
			[Token(Token = "0x6005EE7")]
			[Address(RVA = "0x161035C", Offset = "0x161035C", VA = "0x161035C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005EE8")]
			[Address(RVA = "0x1610428", Offset = "0x1610428", VA = "0x1610428")]
			set
			{
			}
		}

		[Token(Token = "0x17000AC8")]
		public float LocalTime
		{
			[Token(Token = "0x6005EE9")]
			[Address(RVA = "0x161050C", Offset = "0x161050C", VA = "0x161050C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AC9")]
		public bool IsKinematic
		{
			[Token(Token = "0x6005EEA")]
			[Address(RVA = "0x16105B4", Offset = "0x16105B4", VA = "0x16105B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005EEB")]
			[Address(RVA = "0x160EC44", Offset = "0x160EC44", VA = "0x160EC44")]
			set
			{
			}
		}

		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0x160EBF8", Offset = "0x160EBF8", VA = "0x160EBF8", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0x160EEEC", Offset = "0x160EEEC", VA = "0x160EEEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6005ED5")]
		[Address(RVA = "0x160EF6C", Offset = "0x160EF6C", VA = "0x160EF6C", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0x160F1C0", Offset = "0x160F1C0", VA = "0x160F1C0", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005ED7")]
		[Address(RVA = "0x160F1FC", Offset = "0x160F1FC", VA = "0x160F1FC", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005ED8")]
		[Address(RVA = "0x160F080", Offset = "0x160F080", VA = "0x160F080")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6005ED9")]
		[Address(RVA = "0x160F224", Offset = "0x160F224", VA = "0x160F224", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005EDA")]
		[Address(RVA = "0x160F4A0", Offset = "0x160F4A0", VA = "0x160F4A0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x160F734", Offset = "0x160F734", VA = "0x160F734", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x160FEC4", Offset = "0x160FEC4", VA = "0x160FEC4")]
		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0x160F3A0", Offset = "0x160F3A0", VA = "0x160F3A0")]
		private void AddRelativeTorque(Vector3 torque, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6005EDE")]
		[Address(RVA = "0x160FFF4", Offset = "0x160FFF4", VA = "0x160FFF4")]
		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Token(Token = "0x6005EEC")]
		[Address(RVA = "0x161066C", Offset = "0x161066C", VA = "0x161066C")]
		public BikeBallShooter()
		{
		}
	}
}
