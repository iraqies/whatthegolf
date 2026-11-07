using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminCreateUserConfigType
	{
		private bool? _allowAdminCreateUserOnly;

		private MessageTemplateType _inviteMessageTemplate;

		private int? _unusedAccountValidityDays;

		public bool AllowAdminCreateUserOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MessageTemplateType InviteMessageTemplate
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
		public int UnusedAccountValidityDays
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal bool IsSetAllowAdminCreateUserOnly()
		{
			return false;
		}

		internal bool IsSetInviteMessageTemplate()
		{
			return false;
		}

		internal bool IsSetUnusedAccountValidityDays()
		{
			return false;
		}
	}
}
