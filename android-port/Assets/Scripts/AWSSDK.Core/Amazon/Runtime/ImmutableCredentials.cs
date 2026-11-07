namespace Amazon.Runtime
{
	public class ImmutableCredentials
	{
		public string AccessKey { get; private set; }

		public string SecretKey { get; private set; }

		public string Token { get; private set; }

		public bool UseToken => false;

		public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
		{
		}

		private ImmutableCredentials()
		{
		}

		public virtual ImmutableCredentials Copy()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}
	}
}
