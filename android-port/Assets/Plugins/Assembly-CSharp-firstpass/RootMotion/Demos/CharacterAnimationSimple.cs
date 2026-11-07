using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200024D")]
	[Attribute(Name = "RequireComponent", RVA = "0x33F84", Offset = "0x33F84")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x4000EEE")]
		[FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000EEF")]
		[FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x4000EF0")]
		[FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x4000EF1")]
		[FieldOffset(Offset = "0x78")]
		public UserControlThirdPerson userController;

		[Token(Token = "0x4000EF2")]
		[FieldOffset(Offset = "0x80")]
		private Animator animator;

		[Token(Token = "0x4000EF3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public float jumpDuration;

		[Token(Token = "0x4000EF4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationCurve jumpLayerWeight;

		[Token(Token = "0x4000EF5")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AnimationCurve jumpSpeedCurve;

		[Token(Token = "0x4000EF6")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float jumpVel;

		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0xA4")]
		private float jumptStartTime;

		[Token(Token = "0x4000EF8")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000EF9")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0xA8")]
		private int jumpLayerIndex;

		[Token(Token = "0x170001E0")]
		public override bool animationGrounded
		{
			[Token(Token = "0x6000F3D")]
			[Address(RVA = "0x135BFC0", Offset = "0x135BFC0", VA = "0x135BFC0", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x135BCB4", Offset = "0x135BCB4", VA = "0x135BCB4", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x135BD50", Offset = "0x135BD50", VA = "0x135BD50", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default;
		}

		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x135BDFC", Offset = "0x135BDFC", VA = "0x135BDFC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x135BF98", Offset = "0x135BF98", VA = "0x135BF98")]
		public void Jump()
		{
		}

		[Token(Token = "0x6000F3E")]
		[Address(RVA = "0x135C000", Offset = "0x135C000", VA = "0x135C000")]
		public CharacterAnimationSimple()
		{
		}
	}
}
