using Il2CppDummyDll;

namespace Amazon.Runtime.SharedInterfaces
{
	[Token(Token = "0x200010D")]
	public interface ICoreAmazonSTS
	{
		[Token(Token = "0x60008F2")]
		AssumeRoleImmutableCredentials CredentialsFromAssumeRoleAuthentication(string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options);
	}
}
