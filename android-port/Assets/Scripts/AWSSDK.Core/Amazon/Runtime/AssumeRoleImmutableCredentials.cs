using System;

namespace Amazon.Runtime
{
	public class AssumeRoleImmutableCredentials : ImmutableCredentials
	{
		public DateTime Expiration { get; private set; }

		public AssumeRoleImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, DateTime expiration)
			: base(null, null, null)
		{
		}

		public new AssumeRoleImmutableCredentials Copy()
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
