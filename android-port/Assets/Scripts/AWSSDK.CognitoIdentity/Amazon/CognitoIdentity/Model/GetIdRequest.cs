using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class GetIdRequest : AmazonCognitoIdentityRequest
	{
		private string _accountId;

		private string _identityPoolId;

		private Dictionary<string, string> _logins;

		[AWSProperty]
		public string AccountId
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
		public string IdentityPoolId
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
		public Dictionary<string, string> Logins
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccountId()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetLogins()
		{
			return false;
		}
	}
}
