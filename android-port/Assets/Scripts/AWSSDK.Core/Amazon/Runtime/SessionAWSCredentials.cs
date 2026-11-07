using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000BC")]
	public class SessionAWSCredentials : AWSCredentials
	{
		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x10")]
		private ImmutableCredentials _lastCredentials;

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1271D34", Offset = "0x1271D34", VA = "0x1271D34")]
		public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1271E7C", Offset = "0x1271E7C", VA = "0x1271E7C", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1271E9C", Offset = "0x1271E9C", VA = "0x1271E9C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x127202C", Offset = "0x127202C", VA = "0x127202C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
