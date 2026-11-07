using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminGetUserResponse : AmazonWebServiceResponse
	{
		private bool? _enabled;

		private List<MFAOptionType> _mfaOptions;

		private string _preferredMfaSetting;

		private List<AttributeType> _userAttributes;

		private DateTime? _userCreateDate;

		private DateTime? _userLastModifiedDate;

		private List<string> _userMFASettingList;

		private string _username;

		private UserStatusType _userStatus;

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<MFAOptionType> MFAOptions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PreferredMfaSetting
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<AttributeType> UserAttributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime UserCreateDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public DateTime UserLastModifiedDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public List<string> UserMFASettingList
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
		public string Username
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserStatusType UserStatus
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEnabled()
		{
			return false;
		}

		internal bool IsSetMFAOptions()
		{
			return false;
		}

		internal bool IsSetPreferredMfaSetting()
		{
			return false;
		}

		internal bool IsSetUserAttributes()
		{
			return false;
		}

		internal bool IsSetUserCreateDate()
		{
			return false;
		}

		internal bool IsSetUserLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetUserMFASettingList()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserStatus()
		{
			return false;
		}
	}
}
