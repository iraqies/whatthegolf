using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.CredentialManagement
{
	[Token(Token = "0x2000134")]
	public class CredentialProfileStoreChain : ICredentialProfileSource
	{
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27038", Offset = "0x27038")]
		private string ProfilesLocation__BackingField;

		[Token(Token = "0x170002A1")]
		public string ProfilesLocation
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x11EAA74", Offset = "0x11EAA74", VA = "0x11EAA74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E3C", Offset = "0x29E3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x11EAA7C", Offset = "0x11EAA7C", VA = "0x11EAA7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x29E4C", Offset = "0x29E4C")]
			private set
			{
			}
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x11EAA84", Offset = "0x11EAA84", VA = "0x11EAA84")]
		public CredentialProfileStoreChain()
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x11DAE4C", Offset = "0x11DAE4C", VA = "0x11DAE4C")]
		public CredentialProfileStoreChain(string profilesLocation)
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x11EAAAC", Offset = "0x11EAAAC", VA = "0x11EAAAC")]
		public bool TryGetAWSCredentials(string profileName, out AWSCredentials credentials)
		{
			return default;
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x11EAB74", Offset = "0x11EAB74", VA = "0x11EAB74", Slot = "4")]
		public bool TryGetProfile(string profileName, out CredentialProfile profile)
		{
			return default;
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x11EAC74", Offset = "0x11EAC74", VA = "0x11EAC74")]
		public List<CredentialProfile> ListProfiles()
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x11EADC0", Offset = "0x11EADC0", VA = "0x11EADC0")]
		public void RegisterProfile(CredentialProfile profile)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x11EAEA4", Offset = "0x11EAEA4", VA = "0x11EAEA4")]
		public void UnregisterProfile(string profileName)
		{
		}
	}
}
