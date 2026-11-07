using Il2CppDummyDll;

namespace Amazon.Auth.AccessControlPolicy
{
	[Token(Token = "0x2000268")]
	public static class ResourceFactory
	{
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x125F028", Offset = "0x125F028", VA = "0x125F028")]
		public static Resource NewS3BucketResource(string bucketName)
		{
			return null;
		}

		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x125F0FC", Offset = "0x125F0FC", VA = "0x125F0FC")]
		public static Resource NewS3ObjectResource(string bucketName, string keyPattern)
		{
			return null;
		}

		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x125F238", Offset = "0x125F238", VA = "0x125F238")]
		public static Resource NewSQSQueueResource(string accountId, string queueName)
		{
			return null;
		}

		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x125F2E8", Offset = "0x125F2E8", VA = "0x125F2E8")]
		private static string FormatAccountId(string accountId)
		{
			return null;
		}
	}
}
