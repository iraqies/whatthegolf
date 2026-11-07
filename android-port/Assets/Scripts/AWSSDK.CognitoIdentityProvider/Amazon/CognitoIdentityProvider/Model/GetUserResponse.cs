using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GetUserResponse : AmazonWebServiceResponse
	{
		private List<MFAOptionType> _mfaOptions;

		private string _preferredMfaSetting;

		private List<AttributeType> _userAttributes;

		private List<string> _userMFASettingList;

		private string _username;

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

		[AWSProperty]
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

		internal bool IsSetUserMFASettingList()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}
	}
}
