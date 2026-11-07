using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AnalyticsConfigurationType
	{
		private string _applicationId;

		private string _externalId;

		private string _roleArn;

		private bool? _userDataShared;

		[AWSProperty]
		public string ApplicationId
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

		public bool UserDataShared
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsSetApplicationId()
		{
			return false;
		}

		internal bool IsSetExternalId()
		{
			return false;
		}

		internal bool IsSetRoleArn()
		{
			return false;
		}

		internal bool IsSetUserDataShared()
		{
			return false;
		}
	}
}
