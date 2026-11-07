using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ResourceServerScopeType
	{
		private string _scopeDescription;

		private string _scopeName;

		[AWSProperty]
		public string ScopeDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string ScopeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetScopeDescription()
		{
			return false;
		}

		internal bool IsSetScopeName()
		{
			return false;
		}
	}
}
