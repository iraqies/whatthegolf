using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class GetFederationTokenResponse : AmazonWebServiceResponse
	{
		private Credentials _credentials;

		private FederatedUser _federatedUser;

		private int? _packedPolicySize;

		public Credentials Credentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FederatedUser FederatedUser
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
		public int PackedPolicySize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool IsSetCredentials()
		{
			return false;
		}

		internal bool IsSetFederatedUser()
		{
			return false;
		}

		internal bool IsSetPackedPolicySize()
		{
			return false;
		}
	}
}
