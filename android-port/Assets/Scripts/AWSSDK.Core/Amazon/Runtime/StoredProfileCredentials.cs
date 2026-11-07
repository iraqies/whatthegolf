using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000D1")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x25AA4", Offset = "0x25AA4")]
	public abstract class StoredProfileCredentials
	{
		[Token(Token = "0x4000395")]
		public const string DEFAULT_PROFILE_NAME = "default";

		[Token(Token = "0x4000396")]
		public const string SHARED_CREDENTIALS_FILE_ENVVAR = "AWS_SHARED_CREDENTIALS_FILE";

		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x0")]
		private static string[] PotentialEnvironmentPathsToCredentialsFile;

		[Token(Token = "0x4000398")]
		public const string DefaultSharedCredentialFilename = "credentials";

		[Token(Token = "0x4000399")]
		public const string DefaultSharedCredentialLocation = ".aws/credentials";

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x127BAE0", Offset = "0x127BAE0", VA = "0x127BAE0")]
		public static AWSCredentials GetProfile(string profileName)
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x127BB84", Offset = "0x127BB84", VA = "0x127BB84")]
		public static AWSCredentials GetProfile(string profileName, string profileLocation)
		{
			return null;
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x127AFC8", Offset = "0x127AFC8", VA = "0x127AFC8")]
		public static string ResolveSharedCredentialFileLocation(string profileLocation)
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x127BD88", Offset = "0x127BD88", VA = "0x127BD88")]
		private static string TestSharedCredentialFileExists(string pathOrFilename)
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x127BE44", Offset = "0x127BE44", VA = "0x127BE44")]
		protected StoredProfileCredentials()
		{
		}
	}
}
