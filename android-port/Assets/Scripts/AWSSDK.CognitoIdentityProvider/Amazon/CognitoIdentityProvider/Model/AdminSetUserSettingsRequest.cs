using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminSetUserSettingsRequest : AmazonCognitoIdentityProviderRequest
	{
		private List<MFAOptionType> _mfaOptions;

		private string _username;

		private string _userPoolId;

		[AWSProperty]
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

		internal bool IsSetMFAOptions()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
