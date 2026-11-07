using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class MergeDeveloperIdentitiesRequest : AmazonCognitoIdentityRequest
	{
		private string _destinationUserIdentifier;

		private string _developerProviderName;

		private string _identityPoolId;

		private string _sourceUserIdentifier;

		[AWSProperty]
		public string DestinationUserIdentifier
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

		[AWSProperty]
		public string SourceUserIdentifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDestinationUserIdentifier()
		{
			return false;
		}

		internal bool IsSetDeveloperProviderName()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetSourceUserIdentifier()
		{
			return false;
		}
	}
}
