using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x2000136")]
	public interface ICredentialProfileStore : ICredentialProfileSource
	{
		[Token(Token = "0x6000A04")]
		void RenameProfile(string oldProfileName, string newProfileName);

		[Token(Token = "0x6000A05")]
		void RenameProfile(string oldProfileName, string newProfileName, bool force);

		[Token(Token = "0x6000A06")]
		void CopyProfile(string fromProfileName, string toProfileName);

		[Token(Token = "0x6000A07")]
		void CopyProfile(string fromProfileName, string toProfileName, bool force);

		[Token(Token = "0x6000A08")]
		void RegisterProfile(CredentialProfile profile);

		[Token(Token = "0x6000A09")]
		void UnregisterProfile(string profileName);

		[Token(Token = "0x6000A0A")]
		List<string> ListProfileNames();

		[Token(Token = "0x6000A0B")]
		List<CredentialProfile> ListProfiles();
	}
}
