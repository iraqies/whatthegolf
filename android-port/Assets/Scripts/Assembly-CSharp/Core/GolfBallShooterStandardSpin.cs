using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001470")]
	public class GolfBallShooterStandardSpin : GolfBallShooterBase
	{
		[Token(Token = "0x400702F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float fullShootVelocity;

		[Token(Token = "0x4007030")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float pitch;

		[Token(Token = "0x4007031")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float spin;

		[Token(Token = "0x6006055")]
		[Address(RVA = "0x1499DD4", Offset = "0x1499DD4", VA = "0x1499DD4", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6006056")]
		[Address(RVA = "0x1499E0C", Offset = "0x1499E0C", VA = "0x1499E0C", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6006057")]
		[Address(RVA = "0x149A090", Offset = "0x149A090", VA = "0x149A090")]
		public GolfBallShooterStandardSpin()
		{
		}
	}
}
