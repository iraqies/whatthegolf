using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class CognitoIdentityProviderInfo
	{
		private string _clientId;

		private string _providerName;

		private bool? _serverSideTokenCheck;

		[AWSProperty]
		public string ClientId
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
		public string ProviderName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ServerSideTokenCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsSetClientId()
		{
			return false;
		}

		internal bool IsSetProviderName()
		{
			return false;
		}

		internal bool IsSetServerSideTokenCheck()
		{
			return false;
		}
	}
}
