namespace Amazon.Runtime
{
	public class BasicAWSCredentials : AWSCredentials
	{
		private ImmutableCredentials _credentials;

		public BasicAWSCredentials(string accessKey, string secretKey)
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
