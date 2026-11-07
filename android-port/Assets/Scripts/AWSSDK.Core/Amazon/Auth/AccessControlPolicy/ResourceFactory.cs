namespace Amazon.Auth.AccessControlPolicy
{
	public static class ResourceFactory
	{
		public static Resource NewS3BucketResource(string bucketName)
		{
			return null;
		}

		public static Resource NewS3ObjectResource(string bucketName, string keyPattern)
		{
			return null;
		}

		public static Resource NewSQSQueueResource(string accountId, string queueName)
		{
			return null;
		}

		private static string FormatAccountId(string accountId)
		{
			return null;
		}
	}
}
