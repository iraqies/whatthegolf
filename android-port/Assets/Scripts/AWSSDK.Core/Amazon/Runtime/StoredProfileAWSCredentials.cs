using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000D0")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x25A6C", Offset = "0x25A6C")]
	public class StoredProfileAWSCredentials : AWSCredentials
	{
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x10")]
		private AWSCredentials _wrappedCredentials;

		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B28", Offset = "0x26B28")]
		private string ProfileName__BackingField;

		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26B38", Offset = "0x26B38")]
		private string ProfilesLocation__BackingField;

		[Token(Token = "0x170001E1")]
		public AWSCredentials WrappedCredentials
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x127AA28", Offset = "0x127AA28", VA = "0x127AA28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E2")]
		public string ProfileName
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x127B630", Offset = "0x127B630", VA = "0x127B630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2935C", Offset = "0x2935C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x127B638", Offset = "0x127B638", VA = "0x127B638")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2936C", Offset = "0x2936C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public string ProfilesLocation
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x127B640", Offset = "0x127B640", VA = "0x127B640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2937C", Offset = "0x2937C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x127B648", Offset = "0x127B648", VA = "0x127B648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2938C", Offset = "0x2938C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x127AA30", Offset = "0x127AA30", VA = "0x127AA30")]
		public StoredProfileAWSCredentials()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x127AAEC", Offset = "0x127AAEC", VA = "0x127AAEC")]
		public StoredProfileAWSCredentials(string profileName)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x127AB68", Offset = "0x127AB68", VA = "0x127AB68")]
		public StoredProfileAWSCredentials(string profileName, string profilesLocation)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x127B650", Offset = "0x127B650", VA = "0x127B650")]
		public static bool IsProfileKnown(string profileName, string profilesLocation)
		{
			return default;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x127BA64", Offset = "0x127BA64", VA = "0x127BA64")]
		public static bool CanCreateFrom(string profileName, string profilesLocation)
		{
			return default;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x127B6A8", Offset = "0x127B6A8", VA = "0x127B6A8")]
		private static bool ValidCredentialsExistInSharedFile(string profilesLocation, string profileName)
		{
			return default;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x127BAC0", Offset = "0x127BAC0", VA = "0x127BAC0", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}
	}
}
