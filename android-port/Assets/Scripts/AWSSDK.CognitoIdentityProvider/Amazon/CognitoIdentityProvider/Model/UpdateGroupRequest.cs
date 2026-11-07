using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateGroupRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _description;

		private string _groupName;

		private int? _precedence;

		private string _roleArn;

		private string _userPoolId;

		[AWSProperty]
		public string Description
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
		public string GroupName
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
		public int Precedence
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

		internal bool IsSetDescription()
		{
			return false;
		}

		internal bool IsSetGroupName()
		{
			return false;
		}

		internal bool IsSetPrecedence()
		{
			return false;
		}

		internal bool IsSetRoleArn()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
