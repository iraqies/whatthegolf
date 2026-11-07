using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleWithWebIdentityRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _policy;

		private List<PolicyDescriptorType> _policyArns;

		private string _providerId;

		private string _roleArn;

		private string _roleSessionName;

		private string _webIdentityToken;

		[AWSProperty]
		public int DurationSeconds
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
		public string Policy
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<PolicyDescriptorType> PolicyArns
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
		public string ProviderId
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
		public string RoleArn
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
		public string RoleSessionName
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
		public string WebIdentityToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetDurationSeconds()
		{
			return false;
		}

		internal bool IsSetPolicy()
		{
			return false;
		}

		internal bool IsSetPolicyArns()
		{
			return false;
		}

		internal bool IsSetProviderId()
		{
			return false;
		}

		internal bool IsSetRoleArn()
		{
			return false;
		}

		internal bool IsSetRoleSessionName()
		{
			return false;
		}

		internal bool IsSetWebIdentityToken()
		{
			return false;
		}
	}
}
