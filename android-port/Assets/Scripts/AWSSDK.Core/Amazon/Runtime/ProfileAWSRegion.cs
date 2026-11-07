using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000A5")]
	public class ProfileAWSRegion : AWSRegion
	{
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x124FBD0", Offset = "0x124FBD0", VA = "0x124FBD0")]
		public ProfileAWSRegion(ICredentialProfileSource source)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x12500B8", Offset = "0x12500B8", VA = "0x12500B8")]
		public ProfileAWSRegion(ICredentialProfileSource source, string profileName)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x124FC68", Offset = "0x124FC68", VA = "0x124FC68")]
		private void Setup(ICredentialProfileSource source, string profileName)
		{
		}
	}
}
