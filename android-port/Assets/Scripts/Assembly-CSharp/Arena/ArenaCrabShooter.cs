using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001216")]
	public class ArenaCrabShooter : GolfBallShooterBase
	{
		[Token(Token = "0x40061BB")]
		[FieldOffset(Offset = "0x60")]
		public float continuousMovementMultiplier;

		[Token(Token = "0x40061BC")]
		[FieldOffset(Offset = "0x64")]
		public float addForceContinuousMultiplier;

		[Token(Token = "0x40061BD")]
		[FieldOffset(Offset = "0x68")]
		public float addForceShootMultiplier;

		[Token(Token = "0x40061BE")]
		[FieldOffset(Offset = "0x6C")]
		public ForceMode aimUpdateForceMode;

		[Token(Token = "0x40061BF")]
		[FieldOffset(Offset = "0x70")]
		public ForceMode onShootForceMode;

		[Token(Token = "0x40061C0")]
		[FieldOffset(Offset = "0x74")]
		public float fullShootVelocity;

		[Token(Token = "0x40061C1")]
		[FieldOffset(Offset = "0x78")]
		public SpiderLegs Legs;

		[Token(Token = "0x40061C2")]
		[FieldOffset(Offset = "0x80")]
		public Transform Body;

		[Token(Token = "0x40061C3")]
		[FieldOffset(Offset = "0x88")]
		public bool moveOnAim;

		[Token(Token = "0x40061C4")]
		[FieldOffset(Offset = "0x90")]
		public Animator AnimatorCrab;

		[Token(Token = "0x40061C5")]
		[FieldOffset(Offset = "0x98")]
		public Animator AnimatorRider;

		[Token(Token = "0x40061C6")]
		[FieldOffset(Offset = "0xA0")]
		private int shootFrames;

		[Token(Token = "0x40061C7")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x5856C", Offset = "0x5856C")]
		private bool UseAddForce__BackingField;

		[Token(Token = "0x1700092F")]
		public bool DidShoot
		{
			[Token(Token = "0x6005346")]
			[Address(RVA = "0x1421B24", Offset = "0x1421B24", VA = "0x1421B24")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000930")]
		public bool UseAddForce
		{
			[Token(Token = "0x6005347")]
			[Address(RVA = "0x1421F30", Offset = "0x1421F30", VA = "0x1421F30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70EC8", Offset = "0x70EC8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005348")]
			[Address(RVA = "0x1421F38", Offset = "0x1421F38", VA = "0x1421F38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x70ED8", Offset = "0x70ED8")]
			set
			{
			}
		}

		[Token(Token = "0x6005349")]
		[Address(RVA = "0x1421F40", Offset = "0x1421F40", VA = "0x1421F40", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x600534A")]
		[Address(RVA = "0x1421F74", Offset = "0x1421F74", VA = "0x1421F74", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x600534B")]
		[Address(RVA = "0x1422168", Offset = "0x1422168", VA = "0x1422168", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x600534C")]
		[Address(RVA = "0x14223F8", Offset = "0x14223F8", VA = "0x14223F8")]
		public ArenaCrabShooter()
		{
		}
	}
}
