using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001450")]
	public class GolfBallShooterExperimental : GolfBallShooterBase
	{
		[Token(Token = "0x4006E7D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006E7E")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006E7F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006E80")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006E81")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006E82")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006E83")]
		[FieldOffset(Offset = "0x7D")]
		public bool lookInAimDirection;

		[Token(Token = "0x4006E84")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x4006E85")]
		[FieldOffset(Offset = "0x80")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006E86")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x4006E87")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006E88")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x6005F25")]
		[Address(RVA = "0x1497AE4", Offset = "0x1497AE4", VA = "0x1497AE4", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005F26")]
		[Address(RVA = "0x1497AE8", Offset = "0x1497AE8", VA = "0x1497AE8", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F27")]
		[Address(RVA = "0x1497B20", Offset = "0x1497B20", VA = "0x1497B20", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F28")]
		[Address(RVA = "0x1497CF0", Offset = "0x1497CF0", VA = "0x1497CF0", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F29")]
		[Address(RVA = "0x1497F48", Offset = "0x1497F48", VA = "0x1497F48")]
		public GolfBallShooterExperimental()
		{
		}
	}
}
