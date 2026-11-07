using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class GetOpenIdTokenForDeveloperIdentityRequest : AmazonCognitoIdentityRequest
	{
		private string _identityId;

		private string _identityPoolId;

		private Dictionary<string, string> _logins;

		private long? _tokenDuration;

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

		[AWSProperty]
		public long TokenDuration
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityId()
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

		internal bool IsSetTokenDuration()
		{
			return false;
		}
	}
}
