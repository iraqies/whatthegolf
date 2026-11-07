using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F2")]
	[Attribute(Name = "RequireComponent", RVA = "0x33A90", Offset = "0x33A90")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x4000D26")]
		[FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x135C318", Offset = "0x135C318", VA = "0x135C318", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x135C37C", Offset = "0x135C37C", VA = "0x135C37C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x135C5C8", Offset = "0x135C5C8", VA = "0x135C5C8")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x135C6BC", Offset = "0x135C6BC", VA = "0x135C6BC")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
}
