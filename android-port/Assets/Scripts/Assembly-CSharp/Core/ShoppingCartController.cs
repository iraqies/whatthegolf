using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001421")]
	public class ShoppingCartController : GolfBallShooterBase
	{
		[Token(Token = "0x4006C7C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006C7D")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006C7E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006C7F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006C80")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006C81")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006C82")]
		[FieldOffset(Offset = "0x7D")]
		public bool lookInAimDirection;

		[Token(Token = "0x4006C83")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x4006C84")]
		[FieldOffset(Offset = "0x80")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006C85")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x4006C86")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006C87")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006C88")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float minWheelsVelocity;

		[Token(Token = "0x4006C89")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float maxWheelsVelocity;

		[Token(Token = "0x4006C8A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private PhysicMaterial noFrictionMaterial;

		[Token(Token = "0x4006C8B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Collider wheelCollider;

		[Token(Token = "0x4006C8C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform[] wheelTransforms;

		[Token(Token = "0x4006C8D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float wheelRotationSpeed;

		[Token(Token = "0x4006C8E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AnimationCurve wheelSpinDownAnim;

		[Token(Token = "0x4006C8F")]
		[FieldOffset(Offset = "0xB8")]
		private float lastOnWheelsTime;

		[Token(Token = "0x4006C90")]
		[FieldOffset(Offset = "0xC0")]
		private Transform t;

		[Token(Token = "0x6005D9E")]
		[Address(RVA = "0x16A3C34", Offset = "0x16A3C34", VA = "0x16A3C34", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005D9F")]
		[Address(RVA = "0x16A3C68", Offset = "0x16A3C68", VA = "0x16A3C68", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005DA0")]
		[Address(RVA = "0x16A3CA4", Offset = "0x16A3CA4", VA = "0x16A3CA4", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005DA1")]
		[Address(RVA = "0x16A3F54", Offset = "0x16A3F54", VA = "0x16A3F54", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005DA2")]
		[Address(RVA = "0x16A41A0", Offset = "0x16A41A0", VA = "0x16A41A0", Slot = "14")]
		protected override void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6005DA3")]
		[Address(RVA = "0x16A3EB0", Offset = "0x16A3EB0", VA = "0x16A3EB0")]
		private bool IsOnWheels()
		{
			return default;
		}

		[Token(Token = "0x6005DA4")]
		[Address(RVA = "0x16A4360", Offset = "0x16A4360", VA = "0x16A4360")]
		private new void FixedUpdate()
		{
		}

		[Token(Token = "0x6005DA5")]
		[Address(RVA = "0x16A4664", Offset = "0x16A4664", VA = "0x16A4664")]
		public ShoppingCartController()
		{
		}
	}
}
