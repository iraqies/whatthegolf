using System;

namespace Amazon.Runtime
{
	public class SAMLImmutableCredentials : ImmutableCredentials
	{
		private const string AccessKeyProperty = "AccessKey";

		private const string SecretKeyProperty = "SecretKey";

		private const string TokenProperty = "Token";

		private const string ExpiresProperty = "Expires";

		private const string SubjectProperty = "Subject";

		public DateTime Expires { get; private set; }

		public string Subject { get; private set; }

		public SAMLImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, DateTime expires, string subject)
			: base(null, null, null)
		{
		}

		public SAMLImmutableCredentials(ImmutableCredentials credentials, DateTime expires, string subject)
			: base(null, null, null)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override ImmutableCredentials Copy()
		{
			return null;
		}

		internal string ToJson()
		{
			return null;
		}

		internal static SAMLImmutableCredentials FromJson(string json)
		{
			return null;
		}
	}
}
