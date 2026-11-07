using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class DeleteIdentitiesRequest : AmazonCognitoIdentityRequest
	{
		private List<string> _identityIdsToDelete;

		[AWSProperty]
		public List<string> IdentityIdsToDelete
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityIdsToDelete()
		{
			return false;
		}
	}
}
