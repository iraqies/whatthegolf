using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumeRoleRequest : AmazonSecurityTokenServiceRequest
	{
		private int? _durationSeconds;

		private string _externalId;

		private string _policy;

		private List<PolicyDescriptorType> _policyArns;

		private string _roleArn;

		private string _roleSessionName;

		private string _serialNumber;

		private List<Tag> _tags;

		private string _tokenCode;

		private List<string> _transitiveTagKeys;

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
		public string ExternalId
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
		public string SerialNumber
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
		public List<Tag> Tags
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
		public string TokenCode
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
		public List<string> TransitiveTagKeys
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

		internal bool IsSetExternalId()
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

		internal bool IsSetRoleArn()
		{
			return false;
		}

		internal bool IsSetRoleSessionName()
		{
			return false;
		}

		internal bool IsSetSerialNumber()
		{
			return false;
		}

		internal bool IsSetTags()
		{
			return false;
		}

		internal bool IsSetTokenCode()
		{
			return false;
		}

		internal bool IsSetTransitiveTagKeys()
		{
			return false;
		}
	}
}
