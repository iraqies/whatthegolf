using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DomainDescriptionType
	{
		private string _awsAccountId;

		private string _cloudFrontDistribution;

		private CustomDomainConfigType _customDomainConfig;

		private string _domain;

		private string _s3Bucket;

		private DomainStatusType _status;

		private string _userPoolId;

		private string _version;

		public string AWSAccountId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CloudFrontDistribution
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CustomDomainConfigType CustomDomainConfig
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
		public string Domain
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
		public string S3Bucket
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DomainStatusType Status
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
		public string UserPoolId
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
		public string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAWSAccountId()
		{
			return false;
		}

		internal bool IsSetCloudFrontDistribution()
		{
			return false;
		}

		internal bool IsSetCustomDomainConfig()
		{
			return false;
		}

		internal bool IsSetDomain()
		{
			return false;
		}

		internal bool IsSetS3Bucket()
		{
			return false;
		}

		internal bool IsSetStatus()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}

		internal bool IsSetVersion()
		{
			return false;
		}
	}
}
