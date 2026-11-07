using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200141F")]
	public class NoJumpsAllowedHurdleShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006C53")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006C54")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006C55")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006C56")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		public float shotXMultiplier;

		[Token(Token = "0x4006C57")]
		[FieldOffset(Offset = "0x70")]
		public float allowedZVariance;

		[Token(Token = "0x4006C58")]
		[FieldOffset(Offset = "0x74")]
		public float zCorrectionSpeedMultiplier;

		[Token(Token = "0x4006C59")]
		[FieldOffset(Offset = "0x78")]
		public float minimumZCorrectionSpeed;

		[Token(Token = "0x4006C5A")]
		[FieldOffset(Offset = "0x7C")]
		private float originZ;

		[Token(Token = "0x6005D90")]
		[Address(RVA = "0x158DDCC", Offset = "0x158DDCC", VA = "0x158DDCC", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005D91")]
		[Address(RVA = "0x158DE10", Offset = "0x158DE10", VA = "0x158DE10", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005D92")]
		[Address(RVA = "0x158DEC8", Offset = "0x158DEC8", VA = "0x158DEC8", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005D93")]
		[Address(RVA = "0x158DF00", Offset = "0x158DF00", VA = "0x158DF00", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005D94")]
		[Address(RVA = "0x158DF74", Offset = "0x158DF74", VA = "0x158DF74")]
		public NoJumpsAllowedHurdleShooter()
		{
		}
	}
}
