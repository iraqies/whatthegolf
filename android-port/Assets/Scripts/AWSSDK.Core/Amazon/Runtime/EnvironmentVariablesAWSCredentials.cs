using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000C6")]
	public class EnvironmentVariablesAWSCredentials : AWSCredentials
	{
		[Token(Token = "0x4000367")]
		public const string ENVIRONMENT_VARIABLE_ACCESSKEY = "AWS_ACCESS_KEY_ID";

		[Token(Token = "0x4000368")]
		public const string ENVIRONMENT_VARIABLE_SECRETKEY = "AWS_SECRET_ACCESS_KEY";

		[Token(Token = "0x4000369")]
		public const string ENVIRONMENT_VARIABLE_SESSION_TOKEN = "AWS_SESSION_TOKEN";

		[Token(Token = "0x400036A")]
		public const string LEGACY_ENVIRONMENT_VARIABLE_SECRETKEY = "AWS_SECRET_KEY";

		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x10")]
		private Logger logger;

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x12001FC", Offset = "0x12001FC", VA = "0x12001FC")]
		public EnvironmentVariablesAWSCredentials()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x12002E0", Offset = "0x12002E0", VA = "0x12002E0")]
		public ImmutableCredentials FetchCredentials()
		{
			return null;
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x12007AC", Offset = "0x12007AC", VA = "0x12007AC", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}
	}
}
