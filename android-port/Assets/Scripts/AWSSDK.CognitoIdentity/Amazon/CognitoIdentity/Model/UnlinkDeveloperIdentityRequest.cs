using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class UnlinkDeveloperIdentityRequest : AmazonCognitoIdentityRequest
	{
		private string _developerProviderName;

		private string _developerUserIdentifier;

		private string _identityId;

		private string _identityPoolId;

		[AWSProperty]
		public string DeveloperProviderName
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
		public string DeveloperUserIdentifier
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
		public string IdentityId
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
		public string IdentityPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDeveloperProviderName()
		{
			return false;
		}

		internal bool IsSetDeveloperUserIdentifier()
		{
			return false;
		}

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}
	}
}
