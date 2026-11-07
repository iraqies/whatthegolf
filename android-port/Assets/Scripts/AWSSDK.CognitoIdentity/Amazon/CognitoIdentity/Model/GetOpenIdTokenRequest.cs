using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class GetOpenIdTokenRequest : AmazonCognitoIdentityRequest
	{
		private string _identityId;

		private Dictionary<string, string> _logins;

		[AWSProperty]
		public string IdentityId
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

		internal bool IsSetIdentityId()
		{
			return false;
		}

		internal bool IsSetLogins()
		{
			return false;
		}
	}
}
