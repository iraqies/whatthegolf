using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x2000135")]
	public interface ICredentialProfileSource
	{
		[Token(Token = "0x6000A03")]
		bool TryGetProfile(string profileName, out CredentialProfile profile);
	}
}
