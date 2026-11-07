using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateUserAttributesResponse : AmazonWebServiceResponse
	{
		private List<CodeDeliveryDetailsType> _codeDeliveryDetailsList;

		public List<CodeDeliveryDetailsType> CodeDeliveryDetailsList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCodeDeliveryDetailsList()
		{
			return false;
		}
	}
}
