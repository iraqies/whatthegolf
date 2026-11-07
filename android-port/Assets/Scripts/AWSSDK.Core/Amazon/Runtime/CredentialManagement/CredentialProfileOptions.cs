namespace Amazon.Runtime.CredentialManagement
{
	public class CredentialProfileOptions
	{
		public string AccessKey { get; set; }

		public string CredentialSource { get; set; }

		public string EndpointName { get; set; }

		public string ExternalID { get; set; }

		public string MfaSerial { get; set; }

		public string RoleArn { get; set; }

		public string RoleSessionName { get; set; }

		public string SecretKey { get; set; }

		public string SourceProfile { get; set; }

		public string Token { get; set; }

		public string UserIdentity { get; set; }

		public string CredentialProcess { get; set; }

		public string WebIdentityTokenFile { get; set; }

		internal bool IsEmpty => false;

		public override string ToString()
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
