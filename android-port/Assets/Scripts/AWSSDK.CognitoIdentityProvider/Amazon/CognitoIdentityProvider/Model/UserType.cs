using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserType
	{
		private List<AttributeType> _attributes;

		private bool? _enabled;

		private List<MFAOptionType> _mfaOptions;

		private DateTime? _userCreateDate;

		private DateTime? _userLastModifiedDate;

		private string _username;

		private UserStatusType _userStatus;

		public List<AttributeType> Attributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		internal bool IsSetAttributes()
		{
			return false;
		}

		internal bool IsSetEnabled()
		{
			return false;
		}

		internal bool IsSetMFAOptions()
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
