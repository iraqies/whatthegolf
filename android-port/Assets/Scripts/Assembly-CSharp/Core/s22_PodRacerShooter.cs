using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200146F")]
	public class s22_PodRacerShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4007019")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x400701A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x400701B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float raycastDist;

		[Token(Token = "0x400701C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform frontForcePosition;

		[Token(Token = "0x400701D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 AdjustForceRange;

		[Token(Token = "0x400701E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x400701F")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4007020")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float AdjustRotationSpeedStartupTime;

		[Token(Token = "0x4007021")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float MaxSpeedLossOnHeadOnCollision;

		[Token(Token = "0x4007022")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float MaxVelocity;

		[Token(Token = "0x4007023")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float MinVelocity;

		[Token(Token = "0x4007024")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private LayerMask GroundCheckMask;

		[Token(Token = "0x4007025")]
		[FieldOffset(Offset = "0xA0")]
		public GolfBallController ballController;

		[Token(Token = "0x4007026")]
		[FieldOffset(Offset = "0xA8")]
		private float lastBoostMagnitude;

		[Token(Token = "0x4007027")]
		[FieldOffset(Offset = "0xAC")]
		private float currentSpeedLossFromCollisions;

		[Token(Token = "0x4007028")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4007029")]
		[FieldOffset(Offset = "0xBC")]
		private bool isAiming;

		[Token(Token = "0x400702A")]
		[FieldOffset(Offset = "0xBD")]
		private bool didAim;

		[Token(Token = "0x400702B")]
		[FieldOffset(Offset = "0xC0")]
		private float rotationStartupTimer;

		[Token(Token = "0x400702C")]
		[FieldOffset(Offset = "0xC8")]
		private LocalClock clock;

		[Token(Token = "0x400702D")]
		[FieldOffset(Offset = "0xD0")]
		private Timeline timeline;

		[Token(Token = "0x400702E")]
		[FieldOffset(Offset = "0xD8")]
		private float timeGrounded;

		[Token(Token = "0x17000AEF")]
		private float FixedDeltaTime
		{
			[Token(Token = "0x6006047")]
			[Address(RVA = "0x1766540", Offset = "0x1766540", VA = "0x1766540")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AF0")]
		private float DeltaTime
		{
			[Token(Token = "0x6006048")]
			[Address(RVA = "0x1765D0C", Offset = "0x1765D0C", VA = "0x1765D0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AF1")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6006049")]
			[Address(RVA = "0x1766488", Offset = "0x1766488", VA = "0x1766488")]
			get
			{
				return default;
			}
			[Token(Token = "0x600604A")]
			[Address(RVA = "0x1765A38", Offset = "0x1765A38", VA = "0x1765A38")]
			set
			{
			}
		}

		[Token(Token = "0x17000AF2")]
		public Vector3 AngularVelocity
		{
			[Token(Token = "0x600604B")]
			[Address(RVA = "0x1766918", Offset = "0x1766918", VA = "0x1766918")]
			get
			{
				return default;
			}
			[Token(Token = "0x600604C")]
			[Address(RVA = "0x1765B2C", Offset = "0x1765B2C", VA = "0x1765B2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000AF3")]
		public float Drag
		{
			[Token(Token = "0x600604D")]
			[Address(RVA = "0x17669D0", Offset = "0x17669D0", VA = "0x17669D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600604E")]
			[Address(RVA = "0x1766A9C", Offset = "0x1766A9C", VA = "0x1766A9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000AF4")]
		public float AngularDrag
		{
			[Token(Token = "0x600604F")]
			[Address(RVA = "0x1766B80", Offset = "0x1766B80", VA = "0x1766B80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006050")]
			[Address(RVA = "0x1766C4C", Offset = "0x1766C4C", VA = "0x1766C4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000AF5")]
		public float LocalTime
		{
			[Token(Token = "0x6006051")]
			[Address(RVA = "0x1766D30", Offset = "0x1766D30", VA = "0x1766D30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AF6")]
		public bool IsKinematic
		{
			[Token(Token = "0x6006052")]
			[Address(RVA = "0x1766DD8", Offset = "0x1766DD8", VA = "0x1766DD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006053")]
			[Address(RVA = "0x1765978", Offset = "0x1765978", VA = "0x1765978")]
			set
			{
			}
		}

		[Token(Token = "0x600603B")]
		[Address(RVA = "0x176592C", Offset = "0x176592C", VA = "0x176592C", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x600603C")]
		[Address(RVA = "0x1765C20", Offset = "0x1765C20", VA = "0x1765C20")]
		private void Start()
		{
		}

		[Token(Token = "0x600603D")]
		[Address(RVA = "0x1765CA0", Offset = "0x1765CA0", VA = "0x1765CA0", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x600603E")]
		[Address(RVA = "0x1765EF4", Offset = "0x1765EF4", VA = "0x1765EF4", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x600603F")]
		[Address(RVA = "0x1765F30", Offset = "0x1765F30", VA = "0x1765F30", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6006040")]
		[Address(RVA = "0x1765DB4", Offset = "0x1765DB4", VA = "0x1765DB4")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6006041")]
		[Address(RVA = "0x1765F58", Offset = "0x1765F58", VA = "0x1765F58", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6006042")]
		[Address(RVA = "0x1765F84", Offset = "0x1765F84", VA = "0x1765F84")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6006043")]
		[Address(RVA = "0x1766218", Offset = "0x1766218", VA = "0x1766218", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6006044")]
		[Address(RVA = "0x17665E8", Offset = "0x17665E8", VA = "0x17665E8")]
		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6006045")]
		[Address(RVA = "0x1766718", Offset = "0x1766718", VA = "0x1766718")]
		private void AddRelativeTorque(Vector3 torque, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6006046")]
		[Address(RVA = "0x1766818", Offset = "0x1766818", VA = "0x1766818")]
		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Token(Token = "0x6006054")]
		[Address(RVA = "0x1766E90", Offset = "0x1766E90", VA = "0x1766E90")]
		public s22_PodRacerShooter()
		{
		}
	}
}
