using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200024A")]
	public class UserControlAIMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000EE1")]
		[FieldOffset(Offset = "0x48")]
		public BehaviourPuppet targetPuppet;

		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x58")]
		private bool isAttacking;

		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x5C")]
		private float attackTimer;

		[Token(Token = "0x170001DE")]
		private Transform moveTarget
		{
			[Token(Token = "0x6000F2B")]
			[Address(RVA = "0x1326B50", Offset = "0x1326B50", VA = "0x1326B50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x1326BA4", Offset = "0x1326BA4", VA = "0x1326BA4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x1326D54", Offset = "0x1326D54", VA = "0x1326D54")]
		private bool CanAttack()
		{
			return default;
		}

		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x1326E74", Offset = "0x1326E74", VA = "0x1326E74")]
		public UserControlAIMelee()
		{
		}
	}
}
