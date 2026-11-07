using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200146C")]
	public class TurtleShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006FEA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006FEB")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006FEC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float raycastDist;

		[Token(Token = "0x4006FED")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform frontForcePosition;

		[Token(Token = "0x4006FEE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 AdjustForceRange;

		[Token(Token = "0x4006FEF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float AdjustRotationSpeed;

		[Token(Token = "0x4006FF0")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float AdjustRotationSpeedWhileDriving;

		[Token(Token = "0x4006FF1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float AdjustRotationSpeedStartupTime;

		[Token(Token = "0x4006FF2")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float MaxSpeedLossOnHeadOnCollision;

		[Token(Token = "0x4006FF3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float jumpHeightMod;

		[Token(Token = "0x4006FF4")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float MaxVelocity;

		[Token(Token = "0x4006FF5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float MinVelocity;

		[Token(Token = "0x4006FF6")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private LayerMask GroundCheckMask;

		[Token(Token = "0x4006FF7")]
		[FieldOffset(Offset = "0xA0")]
		public GolfBallController ballController;

		[Token(Token = "0x4006FF8")]
		[FieldOffset(Offset = "0xA8")]
		private float lastBoostMagnitude;

		[Token(Token = "0x4006FF9")]
		[FieldOffset(Offset = "0xAC")]
		private float currentSpeedLossFromCollisions;

		[Token(Token = "0x4006FFA")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006FFB")]
		[FieldOffset(Offset = "0xBC")]
		private bool isAiming;

		[Token(Token = "0x4006FFC")]
		[FieldOffset(Offset = "0xBD")]
		private bool didAim;

		[Token(Token = "0x4006FFD")]
		[FieldOffset(Offset = "0xC0")]
		private float rotationStartupTimer;

		[Token(Token = "0x4006FFE")]
		[FieldOffset(Offset = "0xC8")]
		private LocalClock clock;

		[Token(Token = "0x4006FFF")]
		[FieldOffset(Offset = "0xD0")]
		private Timeline timeline;

		[Token(Token = "0x4007000")]
		[FieldOffset(Offset = "0xD8")]
		private float timeGrounded;

		[Token(Token = "0x17000AE5")]
		private float FixedDeltaTime
		{
			[Token(Token = "0x600601B")]
			[Address(RVA = "0x1732570", Offset = "0x1732570", VA = "0x1732570")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AE6")]
		private float DeltaTime
		{
			[Token(Token = "0x600601C")]
			[Address(RVA = "0x1731D10", Offset = "0x1731D10", VA = "0x1731D10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AE7")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600601D")]
			[Address(RVA = "0x17324B8", Offset = "0x17324B8", VA = "0x17324B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600601E")]
			[Address(RVA = "0x1731A3C", Offset = "0x1731A3C", VA = "0x1731A3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000AE8")]
		public Vector3 AngularVelocity
		{
			[Token(Token = "0x600601F")]
			[Address(RVA = "0x1732948", Offset = "0x1732948", VA = "0x1732948")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006020")]
			[Address(RVA = "0x1731B30", Offset = "0x1731B30", VA = "0x1731B30")]
			set
			{
			}
		}

		[Token(Token = "0x17000AE9")]
		public float Drag
		{
			[Token(Token = "0x6006021")]
			[Address(RVA = "0x1732A00", Offset = "0x1732A00", VA = "0x1732A00")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006022")]
			[Address(RVA = "0x1732ACC", Offset = "0x1732ACC", VA = "0x1732ACC")]
			set
			{
			}
		}

		[Token(Token = "0x17000AEA")]
		public float AngularDrag
		{
			[Token(Token = "0x6006023")]
			[Address(RVA = "0x1732BB0", Offset = "0x1732BB0", VA = "0x1732BB0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006024")]
			[Address(RVA = "0x1732C7C", Offset = "0x1732C7C", VA = "0x1732C7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000AEB")]
		public float LocalTime
		{
			[Token(Token = "0x6006025")]
			[Address(RVA = "0x1732D60", Offset = "0x1732D60", VA = "0x1732D60")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AEC")]
		public bool IsKinematic
		{
			[Token(Token = "0x6006026")]
			[Address(RVA = "0x1732E08", Offset = "0x1732E08", VA = "0x1732E08")]
			get
			{
				return default;
			}
			[Token(Token = "0x6006027")]
			[Address(RVA = "0x173197C", Offset = "0x173197C", VA = "0x173197C")]
			set
			{
			}
		}

		[Token(Token = "0x6006010")]
		[Address(RVA = "0x1731930", Offset = "0x1731930", VA = "0x1731930", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6006011")]
		[Address(RVA = "0x1731C24", Offset = "0x1731C24", VA = "0x1731C24")]
		private void Start()
		{
		}

		[Token(Token = "0x6006012")]
		[Address(RVA = "0x1731CA4", Offset = "0x1731CA4", VA = "0x1731CA4", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6006013")]
		[Address(RVA = "0x1731EF8", Offset = "0x1731EF8", VA = "0x1731EF8", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6006014")]
		[Address(RVA = "0x1731F34", Offset = "0x1731F34", VA = "0x1731F34", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6006015")]
		[Address(RVA = "0x1731DB8", Offset = "0x1731DB8", VA = "0x1731DB8")]
		private void AdjustRotation(Vector3 dir, bool isDriving)
		{
		}

		[Token(Token = "0x6006016")]
		[Address(RVA = "0x1731F5C", Offset = "0x1731F5C", VA = "0x1731F5C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6006017")]
		[Address(RVA = "0x1731F60", Offset = "0x1731F60", VA = "0x1731F60", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6006018")]
		[Address(RVA = "0x1732618", Offset = "0x1732618", VA = "0x1732618")]
		private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
		{
		}

		[Token(Token = "0x6006019")]
		[Address(RVA = "0x1732848", Offset = "0x1732848", VA = "0x1732848")]
		private void AddRelativeTorque(Vector3 torque, ForceMode forceMode)
		{
		}

		[Token(Token = "0x600601A")]
		[Address(RVA = "0x1732748", Offset = "0x1732748", VA = "0x1732748")]
		private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
		{
		}

		[Token(Token = "0x6006028")]
		[Address(RVA = "0x1732EC0", Offset = "0x1732EC0", VA = "0x1732EC0")]
		public TurtleShooter()
		{
		}
	}
}
