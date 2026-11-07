using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Olympics.Wrestling
{
	[Token(Token = "0x20011E1")]
	public class WrestlerShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006007")]
		[FieldOffset(Offset = "0x60")]
		public Rigidbody pelvis;

		[Token(Token = "0x4006008")]
		[FieldOffset(Offset = "0x68")]
		public Animator animator;

		[Token(Token = "0x60051CC")]
		[Address(RVA = "0x175BDF4", Offset = "0x175BDF4", VA = "0x175BDF4", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x60051CD")]
		[Address(RVA = "0x175BDFC", Offset = "0x175BDFC", VA = "0x175BDFC", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x175BEB0", Offset = "0x175BEB0", VA = "0x175BEB0", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x175BF7C", Offset = "0x175BF7C", VA = "0x175BF7C")]
		public WrestlerShooter()
		{
		}
	}
}
