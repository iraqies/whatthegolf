using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200141E")]
	public class GolfBallShooterExperimentalSim2d : GolfBallShooterBase
	{
		[Token(Token = "0x4006C43")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006C44")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006C45")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006C46")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006C47")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006C48")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006C49")]
		[FieldOffset(Offset = "0x7D")]
		public bool lookInAimDirection;

		[Token(Token = "0x4006C4A")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x4006C4B")]
		[FieldOffset(Offset = "0x80")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006C4C")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x4006C4D")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006C4E")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006C4F")]
		[FieldOffset(Offset = "0x88")]
		public float allowedZVariance;

		[Token(Token = "0x4006C50")]
		[FieldOffset(Offset = "0x8C")]
		public float zCorrectionSpeedMultiplier;

		[Token(Token = "0x4006C51")]
		[FieldOffset(Offset = "0x90")]
		public float minimumZCorrectionSpeed;

		[Token(Token = "0x4006C52")]
		[FieldOffset(Offset = "0x94")]
		private float originZ;

		[Token(Token = "0x6005D8A")]
		[Address(RVA = "0x1497FC8", Offset = "0x1497FC8", VA = "0x1497FC8", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005D8B")]
		[Address(RVA = "0x1498008", Offset = "0x1498008", VA = "0x1498008", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005D8C")]
		[Address(RVA = "0x14980C0", Offset = "0x14980C0", VA = "0x14980C0", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005D8D")]
		[Address(RVA = "0x14980F8", Offset = "0x14980F8", VA = "0x14980F8", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005D8E")]
		[Address(RVA = "0x14982C8", Offset = "0x14982C8", VA = "0x14982C8", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005D8F")]
		[Address(RVA = "0x1498520", Offset = "0x1498520", VA = "0x1498520")]
		public GolfBallShooterExperimentalSim2d()
		{
		}
	}
}
