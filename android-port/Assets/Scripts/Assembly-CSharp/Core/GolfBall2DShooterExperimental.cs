using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200144E")]
	public class GolfBall2DShooterExperimental : GolfBall2DShooterBase
	{
		[Token(Token = "0x4006E6B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006E6C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006E6D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006E6E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006E6F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006E70")]
		[FieldOffset(Offset = "0x59")]
		[SerializeField]
		public bool lookInAimDirection;

		[Token(Token = "0x6005F15")]
		[Address(RVA = "0x1491090", Offset = "0x1491090", VA = "0x1491090", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F16")]
		[Address(RVA = "0x14910C8", Offset = "0x14910C8", VA = "0x14910C8", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F17")]
		[Address(RVA = "0x1491144", Offset = "0x1491144", VA = "0x1491144", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F18")]
		[Address(RVA = "0x149125C", Offset = "0x149125C", VA = "0x149125C")]
		public GolfBall2DShooterExperimental()
		{
		}
	}
}
