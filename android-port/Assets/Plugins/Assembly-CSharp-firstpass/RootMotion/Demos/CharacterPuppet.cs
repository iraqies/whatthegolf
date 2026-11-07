using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200022A")]
	public class CharacterPuppet : CharacterThirdPerson
	{
		[Token(Token = "0x4000E48")]
		[FieldOffset(Offset = "0x1E8")]
		public PropMuscle propMuscle;

		[Token(Token = "0x4000E49")]
		[FieldOffset(Offset = "0x1F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x36D58", Offset = "0x36D58")]
		private BehaviourPuppet puppet__BackingField;

		[Token(Token = "0x170001CA")]
		public BehaviourPuppet puppet
		{
			[Token(Token = "0x6000EA6")]
			[Address(RVA = "0x135DA24", Offset = "0x135DA24", VA = "0x135DA24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0BC", Offset = "0x3B0BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EA7")]
			[Address(RVA = "0x135DA2C", Offset = "0x135DA2C", VA = "0x135DA2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B0CC", Offset = "0x3B0CC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x135D2F4", Offset = "0x135D2F4", VA = "0x135D2F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x135DB80", Offset = "0x135DB80", VA = "0x135DB80", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x135DCA0", Offset = "0x135DCA0", VA = "0x135DCA0", Slot = "9")]
		protected override void Rotate()
		{
		}

		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x135E1EC", Offset = "0x135E1EC", VA = "0x135E1EC", Slot = "10")]
		protected override bool Jump()
		{
			return default;
		}

		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x135D928", Offset = "0x135D928", VA = "0x135D928")]
		public CharacterPuppet()
		{
		}
	}
}
