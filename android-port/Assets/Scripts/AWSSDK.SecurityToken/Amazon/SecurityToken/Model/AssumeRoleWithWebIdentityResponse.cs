using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleWithWebIdentityResponse : AmazonWebServiceResponse
	{
		private AssumedRoleUser _assumedRoleUser;

		private string _audience;

		private Credentials _credentials;

		private int? _packedPolicySize;

		private string _provider;

		private string _subjectFromWebIdentityToken;

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

		public string Audience
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

		[AWSProperty]
		public string SubjectFromWebIdentityToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAssumedRoleUser()
		{
			return false;
		}

		internal bool IsSetAudience()
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

		internal bool IsSetProvider()
		{
			return false;
		}

		internal bool IsSetSubjectFromWebIdentityToken()
		{
			return false;
		}
	}
}
