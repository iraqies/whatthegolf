using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class GetIdentityPoolConfigurationResponse : AmazonWebServiceResponse
	{
		private CognitoStreams _cognitoStreams;

		private string _identityPoolId;

		private PushSync _pushSync;

		public CognitoStreams CognitoStreams
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

		public PushSync PushSync
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCognitoStreams()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetPushSync()
		{
			return false;
		}
	}
}
