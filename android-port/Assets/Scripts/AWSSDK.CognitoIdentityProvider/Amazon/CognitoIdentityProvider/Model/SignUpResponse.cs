using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SignUpResponse : AmazonWebServiceResponse
	{
		private CodeDeliveryDetailsType _codeDeliveryDetails;

		private bool? _userConfirmed;

		private string _userSub;

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

		[AWSProperty]
		public bool UserConfirmed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string UserSub
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

		internal bool IsSetUserConfirmed()
		{
			return false;
		}

		internal bool IsSetUserSub()
		{
			return false;
		}
	}
}
