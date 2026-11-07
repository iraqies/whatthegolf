using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x2000259")]
	public class ActionIdentifier
	{
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x10")]
		private string actionName;

		[Token(Token = "0x17000462")]
		public string ActionName
		{
			[Token(Token = "0x60011BA")]
			[Address(RVA = "0x11C8AEC", Offset = "0x11C8AEC", VA = "0x11C8AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60011BB")]
			[Address(RVA = "0x11C8AF4", Offset = "0x11C8AF4", VA = "0x11C8AF4")]
			set
			{
			}
		}

		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x11C8AC0", Offset = "0x11C8AC0", VA = "0x11C8AC0")]
		public ActionIdentifier(string actionName)
		{
		}
	}
}
