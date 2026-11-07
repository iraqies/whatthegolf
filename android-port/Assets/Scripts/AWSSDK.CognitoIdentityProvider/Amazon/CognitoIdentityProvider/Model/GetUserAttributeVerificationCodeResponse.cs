using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GetUserAttributeVerificationCodeResponse : AmazonWebServiceResponse
	{
		private CodeDeliveryDetailsType _codeDeliveryDetails;

		public CodeDeliveryDetailsType CodeDeliveryDetails
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCodeDeliveryDetails()
		{
			return false;
		}
	}
}
