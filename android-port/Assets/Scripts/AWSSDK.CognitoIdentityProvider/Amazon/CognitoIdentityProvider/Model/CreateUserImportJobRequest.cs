using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateUserImportJobRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _cloudWatchLogsRoleArn;

		private string _jobName;

		private string _userPoolId;

		[AWSProperty]
		public string CloudWatchLogsRoleArn
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
		public string JobName
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

		internal bool IsSetCloudWatchLogsRoleArn()
		{
			return false;
		}

		internal bool IsSetJobName()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
