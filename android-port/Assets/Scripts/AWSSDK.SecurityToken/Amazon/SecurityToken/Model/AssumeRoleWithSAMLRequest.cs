using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleWithSAMLRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _policy;

		private List<PolicyDescriptorType> _policyArns;

		private string _principalArn;

		private string _roleArn;

		private string _samlAssertion;

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
		public string PrincipalArn
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
		public string SAMLAssertion
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

		internal bool IsSetPrincipalArn()
		{
			return false;
		}

		internal bool IsSetRoleArn()
		{
			return false;
		}

		internal bool IsSetSAMLAssertion()
		{
			return false;
		}
	}
}
