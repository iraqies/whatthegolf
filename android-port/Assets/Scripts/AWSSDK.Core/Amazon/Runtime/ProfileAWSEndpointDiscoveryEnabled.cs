using Amazon.Runtime.CredentialManagement;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000D3")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x25B14", Offset = "0x25B14")]
	public class ProfileAWSEndpointDiscoveryEnabled
	{
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B58", Offset = "0x26B58")]
		private bool Enabled__BackingField;

		[Token(Token = "0x170001E5")]
		public bool Enabled
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x124F660", Offset = "0x124F660", VA = "0x124F660")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x293BC", Offset = "0x293BC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x124F668", Offset = "0x124F668", VA = "0x124F668")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x293CC", Offset = "0x293CC")]
			private set
			{
			}
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x124F670", Offset = "0x124F670", VA = "0x124F670")]
		public ProfileAWSEndpointDiscoveryEnabled(ICredentialProfileSource source)
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x124FB90", Offset = "0x124FB90", VA = "0x124FB90")]
		public ProfileAWSEndpointDiscoveryEnabled(ICredentialProfileSource source, string profileName)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x124F708", Offset = "0x124F708", VA = "0x124F708")]
		private void Setup(ICredentialProfileSource source, string profileName)
		{
		}
	}
}
