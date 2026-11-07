using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200015C")]
	public class ProfileInternalConfiguration : InternalConfiguration
	{
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x28")]
		private Logger _logger;

		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x1250DF0", Offset = "0x1250DF0", VA = "0x1250DF0")]
		public ProfileInternalConfiguration(ICredentialProfileSource source)
		{
		}

		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x125144C", Offset = "0x125144C", VA = "0x125144C")]
		public ProfileInternalConfiguration(ICredentialProfileSource source, string profileName)
		{
		}

		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x1250F24", Offset = "0x1250F24", VA = "0x1250F24")]
		private void Setup(ICredentialProfileSource source, string profileName)
		{
		}
	}
}
