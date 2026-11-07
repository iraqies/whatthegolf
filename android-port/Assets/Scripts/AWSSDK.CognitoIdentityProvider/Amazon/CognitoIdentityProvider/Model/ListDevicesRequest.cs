using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ListDevicesRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private int? _limit;

		private string _paginationToken;

		[AWSProperty]
		public string AccessToken
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
		public int Limit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string PaginationToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetLimit()
		{
			return false;
		}

		internal bool IsSetPaginationToken()
		{
			return false;
		}
	}
}
