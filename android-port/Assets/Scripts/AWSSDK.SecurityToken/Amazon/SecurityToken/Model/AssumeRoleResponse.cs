using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleResponse : AmazonWebServiceResponse
	{
		private AssumedRoleUser _assumedRoleUser;

		private Credentials _credentials;

		private int? _packedPolicySize;

		public AssumedRoleUser AssumedRoleUser
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		internal bool IsSetAssumedRoleUser()
		{
			return false;
		}

		internal bool IsSetCredentials()
		{
			return false;
		}

		internal bool IsSetPackedPolicySize()
		{
			return false;
		}
	}
}
