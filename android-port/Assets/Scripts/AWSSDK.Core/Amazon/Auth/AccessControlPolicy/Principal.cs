namespace Amazon.Auth.AccessControlPolicy
{
	public class Principal
	{
		public static readonly Principal AllUsers;

		public static readonly Principal Anonymous;

		public const string AWS_PROVIDER = "AWS";

		public const string CANONICAL_USER_PROVIDER = "CanonicalUser";

		public const string FEDERATED_PROVIDER = "Federated";

		public const string SERVICE_PROVIDER = "Service";

		public const string ANONYMOUS_PROVIDER = "__ANONYMOUS__";

		private string id;

		private string provider;

		public string Provider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Id => null;

		public Principal(string accountId)
		{
		}

		public Principal(string provider, string id)
		{
		}

		public Principal(string provider, string id, bool stripHyphen)
		{
		}
	}
}
