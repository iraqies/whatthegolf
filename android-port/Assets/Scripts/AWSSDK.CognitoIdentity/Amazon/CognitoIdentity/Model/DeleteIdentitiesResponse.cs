using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class DeleteIdentitiesResponse : AmazonWebServiceResponse
	{
		private List<UnprocessedIdentityId> _unprocessedIdentityIds;

		[AWSProperty]
		public List<UnprocessedIdentityId> UnprocessedIdentityIds
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetUnprocessedIdentityIds()
		{
			return false;
		}
	}
}
