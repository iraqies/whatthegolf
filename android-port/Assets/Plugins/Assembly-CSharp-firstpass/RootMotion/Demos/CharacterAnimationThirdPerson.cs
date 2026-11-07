using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200024E")]
	[Attribute(Name = "RequireComponent", RVA = "0x33FEC", Offset = "0x33FEC")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36E80", Offset = "0x36E80")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000F02")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000F03")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x170001E1")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000F41")]
			[Address(RVA = "0x135C124", Offset = "0x135C124", VA = "0x135C124", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F3F")]
		[Address(RVA = "0x135C080", Offset = "0x135C080", VA = "0x135C080", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000F40")]
		[Address(RVA = "0x135C108", Offset = "0x135C108", VA = "0x135C108", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default;
		}

		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x135B7EC", Offset = "0x135B7EC", VA = "0x135B7EC", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000F43")]
		[Address(RVA = "0x135C204", Offset = "0x135C204", VA = "0x135C204")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x135C310", Offset = "0x135C310", VA = "0x135C310")]
		public void SetAnimSpeedMultiplier(float val)
		{
		}

		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x135BC80", Offset = "0x135BC80", VA = "0x135BC80")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
}
