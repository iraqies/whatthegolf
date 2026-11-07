using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001454")]
	public class GolfBallShooterStandard : GolfBallShooterBase
	{
		[Token(Token = "0x4006EA0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float fullShootVelocity;

		[Token(Token = "0x4006EA1")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float pitch;

		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0x1499BC4", Offset = "0x1499BC4", VA = "0x1499BC4", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F3B")]
		[Address(RVA = "0x1499BFC", Offset = "0x1499BFC", VA = "0x1499BFC", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0x1499DC4", Offset = "0x1499DC4", VA = "0x1499DC4")]
		public GolfBallShooterStandard()
		{
		}
	}
}
