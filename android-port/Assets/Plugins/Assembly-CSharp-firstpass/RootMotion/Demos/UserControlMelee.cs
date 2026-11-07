using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200024B")]
	public class UserControlMelee : UserControlThirdPerson
	{
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x48")]
		public KeyCode hitKey;

		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x13274B8", Offset = "0x13274B8", VA = "0x13274B8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x13274E8", Offset = "0x13274E8", VA = "0x13274E8")]
		public UserControlMelee()
		{
		}
	}
}
