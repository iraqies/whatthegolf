using Il2CppDummyDll;
using RootMotion.FinalIK;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000218")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x4000DFE")]
		[FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x1326E90", Offset = "0x1326E90", VA = "0x1326E90", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000E6E")]
		[Address(RVA = "0x1327224", Offset = "0x1327224", VA = "0x1327224")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x1327494", Offset = "0x1327494", VA = "0x1327494")]
		public UserControlInteractions()
		{
		}
	}
}
