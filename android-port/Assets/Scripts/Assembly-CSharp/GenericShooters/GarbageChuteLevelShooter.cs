using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace GenericShooters
{
	[Token(Token = "0x20010F6")]
	public class GarbageChuteLevelShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4005956")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float force;

		[Token(Token = "0x4005957")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float rotationForce;

		[Token(Token = "0x6004BE8")]
		[Address(RVA = "0x14833AC", Offset = "0x14833AC", VA = "0x14833AC", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6004BE9")]
		[Address(RVA = "0x14834A8", Offset = "0x14834A8", VA = "0x14834A8")]
		public GarbageChuteLevelShooter()
		{
		}
	}
}
