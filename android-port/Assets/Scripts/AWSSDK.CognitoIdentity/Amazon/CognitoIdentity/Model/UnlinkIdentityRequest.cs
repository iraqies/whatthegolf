using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class UnlinkIdentityRequest : AmazonCognitoIdentityRequest
	{
		private string _identityId;

		private Dictionary<string, string> _logins;

		private List<string> _loginsToRemove;

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

		[AWSProperty]
		public List<string> LoginsToRemove
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

		internal bool IsSetLoginsToRemove()
		{
			return false;
		}
	}
}
