using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class GetUICustomizationResponse : AmazonWebServiceResponse
	{
		private UICustomizationType _uiCustomization;

		[AWSProperty]
		public UICustomizationType UICustomization
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetUICustomization()
		{
			return false;
		}
	}
}
