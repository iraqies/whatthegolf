namespace Amazon.Runtime
{
	public class SessionAWSCredentials : AWSCredentials
	{
		private ImmutableCredentials _lastCredentials;

		public SessionAWSCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
		{
		}

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
