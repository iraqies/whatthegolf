using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200141D")]
	public class CartwheelController : GolfBallShooterBase
	{
		[Token(Token = "0x4006C2D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006C2E")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006C2F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006C30")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006C31")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006C32")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006C33")]
		[FieldOffset(Offset = "0x7D")]
		public bool lookInAimDirection;

		[Token(Token = "0x4006C34")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x4006C35")]
		[FieldOffset(Offset = "0x80")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006C36")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x4006C37")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006C38")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006C39")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rigidbody[] arms;

		[Token(Token = "0x4006C3A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Rigidbody[] legs;

		[Token(Token = "0x4006C3B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float limbRotationSpeed;

		[Token(Token = "0x4006C3C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Collider cartwheelCollider;

		[Token(Token = "0x4006C3D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float minCartwheelSpeed;

		[Token(Token = "0x4006C3E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform[] armTargets;

		[Token(Token = "0x4006C3F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float liftArmsForce;

		[Token(Token = "0x4006C40")]
		[FieldOffset(Offset = "0xBC")]
		private bool hasShotOnce;

		[Token(Token = "0x4006C41")]
		[FieldOffset(Offset = "0xBD")]
		private bool isAiming;

		[Token(Token = "0x4006C42")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 lastBoost;

		[Token(Token = "0x6005D82")]
		[Address(RVA = "0x188D718", Offset = "0x188D718", VA = "0x188D718", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005D83")]
		[Address(RVA = "0x188D750", Offset = "0x188D750", VA = "0x188D750", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005D84")]
		[Address(RVA = "0x188D758", Offset = "0x188D758", VA = "0x188D758", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005D85")]
		[Address(RVA = "0x188D800", Offset = "0x188D800", VA = "0x188D800", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005D86")]
		[Address(RVA = "0x188D87C", Offset = "0x188D87C", VA = "0x188D87C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005D87")]
		[Address(RVA = "0x188DB34", Offset = "0x188DB34", VA = "0x188DB34")]
		private void Update()
		{
		}

		[Token(Token = "0x6005D88")]
		[Address(RVA = "0x188DBBC", Offset = "0x188DBBC", VA = "0x188DBBC", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005D89")]
		[Address(RVA = "0x188DEF8", Offset = "0x188DEF8", VA = "0x188DEF8")]
		public CartwheelController()
		{
		}
	}
}
