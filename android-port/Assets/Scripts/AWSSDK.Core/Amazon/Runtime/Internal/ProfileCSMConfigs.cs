using System.Collections.Generic;
using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x20001AA")]
	public class ProfileCSMConfigs
	{
		[Token(Token = "0x4000673")]
		private const string CSM_ENABLED = "csm_enabled";

		[Token(Token = "0x4000674")]
		private const string CSM_CLIENTID = "csm_clientid";

		[Token(Token = "0x4000675")]
		private const string CSM_HOST = "csm_host";

		[Token(Token = "0x4000676")]
		private const string CSM_PORT = "csm_port";

		[Token(Token = "0x4000677")]
		private const string CSM_PROFILE_ERROR_MSG = "CSM configurations not found using profile store.";

		[Token(Token = "0x4000678")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27638", Offset = "0x27638")]
		private string ProfileName__BackingField;

		[Token(Token = "0x17000361")]
		private string ProfileName
		{
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x12500F8", Offset = "0x12500F8", VA = "0x12500F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AFD4", Offset = "0x2AFD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x1250100", Offset = "0x1250100", VA = "0x1250100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AFE4", Offset = "0x2AFE4")]
			set
			{
			}
		}

		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x1250108", Offset = "0x1250108", VA = "0x1250108")]
		public ProfileCSMConfigs(CSMFallbackConfigChain cSMFallbackConfigChain, string profileName, IDictionary<string, string> profileProperties)
		{
		}

		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x1250848", Offset = "0x1250848", VA = "0x1250848")]
		public ProfileCSMConfigs(ICredentialProfileSource source, CSMFallbackConfigChain cSMFallbackConfigChain)
		{
		}

		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x1250150", Offset = "0x1250150", VA = "0x1250150")]
		private void Setup(CSMFallbackConfigChain cSMFallbackConfigChain, IDictionary<string, string> profileProperties)
		{
		}
	}
}
