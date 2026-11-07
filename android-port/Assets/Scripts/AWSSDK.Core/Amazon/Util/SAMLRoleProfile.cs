using Amazon.Runtime;
using Amazon.Runtime.Internal.Settings;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000074")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x25924", Offset = "0x25924")]
	public class SAMLRoleProfile : ProfileSettingsBase
	{
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x20")]
		private object _synclock;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26528", Offset = "0x26528")]
		private string RoleArn__BackingField;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26538", Offset = "0x26538")]
		private string UserIdentity__BackingField;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26548", Offset = "0x26548")]
		private string Region__BackingField;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x40")]
		private SAMLImmutableCredentials _session;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26558", Offset = "0x26558")]
		private SAMLEndpointSettings EndpointSettings__BackingField;

		[Token(Token = "0x170000FA")]
		public string RoleArn
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x126D794", Offset = "0x126D794", VA = "0x126D794")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2861C", Offset = "0x2861C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x126D79C", Offset = "0x126D79C", VA = "0x126D79C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2862C", Offset = "0x2862C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public string UserIdentity
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x126D7A4", Offset = "0x126D7A4", VA = "0x126D7A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2863C", Offset = "0x2863C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x126D7AC", Offset = "0x126D7AC", VA = "0x126D7AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2864C", Offset = "0x2864C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public bool UseDefaultUserIdentity
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x126D7B4", Offset = "0x126D7B4", VA = "0x126D7B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000FD")]
		public string Region
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x126D7C0", Offset = "0x126D7C0", VA = "0x126D7C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2865C", Offset = "0x2865C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x126D7C8", Offset = "0x126D7C8", VA = "0x126D7C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2866C", Offset = "0x2866C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public SAMLEndpointSettings EndpointSettings
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x126DB1C", Offset = "0x126DB1C", VA = "0x126DB1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2867C", Offset = "0x2867C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x126DB24", Offset = "0x126DB24", VA = "0x126DB24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2868C", Offset = "0x2868C")]
			internal set
			{
			}
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x126D7D0", Offset = "0x126D7D0", VA = "0x126D7D0")]
		public SAMLImmutableCredentials GetCurrentSession()
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x126D9D4", Offset = "0x126D9D4", VA = "0x126D9D4")]
		public void PersistSession(SAMLImmutableCredentials credentials)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x126D980", Offset = "0x126D980", VA = "0x126D980")]
		private void UpdateProfileSessionData(SAMLImmutableCredentials credentials)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x126DB2C", Offset = "0x126DB2C", VA = "0x126DB2C")]
		public static bool CanCreateFrom(string profileName)
		{
			return default;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x126DBC8", Offset = "0x126DBC8", VA = "0x126DBC8")]
		public static bool CanCreateFrom(SettingsCollection.ObjectSettings os)
		{
			return default;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x126DC5C", Offset = "0x126DC5C", VA = "0x126DC5C")]
		public static SAMLRoleProfile LoadFrom(string profileName)
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x126DC74", Offset = "0x126DC74", VA = "0x126DC74")]
		public static SAMLRoleProfile LoadFrom(SettingsCollection.ObjectSettings os)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x126E3A8", Offset = "0x126E3A8", VA = "0x126E3A8")]
		public static void Validate(string profileName)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x126DFAC", Offset = "0x126DFAC", VA = "0x126DFAC")]
		private static void Validate(SettingsCollection.ObjectSettings os)
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x126E3C0", Offset = "0x126E3C0", VA = "0x126E3C0", Slot = "4")]
		public override string Persist()
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x126DAEC", Offset = "0x126DAEC", VA = "0x126DAEC")]
		private string Persist(string session)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x126E3F0", Offset = "0x126E3F0", VA = "0x126E3F0")]
		public static string Persist(string profileName, string endpointSettingsName, string roleArn, string userIdentity, string session, string region)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x126E168", Offset = "0x126E168", VA = "0x126E168")]
		private static SAMLImmutableCredentials LoadActiveSessionCredentials(string profileName)
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x126E934", Offset = "0x126E934", VA = "0x126E934")]
		private static void PersistActiveSessionCredentials(string profileName, string session)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x126E2F8", Offset = "0x126E2F8", VA = "0x126E2F8")]
		private SAMLRoleProfile(string profileName, SAMLEndpointSettings endpointSettings, string roleArn, string userIdentity, SAMLImmutableCredentials currentSession, string region)
		{
		}
	}
}
