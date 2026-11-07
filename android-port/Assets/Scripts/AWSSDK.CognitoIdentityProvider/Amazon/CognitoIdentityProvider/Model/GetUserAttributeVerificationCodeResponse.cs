using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C4")]
	public class GetUserAttributeVerificationCodeResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x28")]
		private CodeDeliveryDetailsType _codeDeliveryDetails;

		[Token(Token = "0x17000169")]
		public CodeDeliveryDetailsType CodeDeliveryDetails
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1121850", Offset = "0x1121850", VA = "0x1121850")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1121858", Offset = "0x1121858", VA = "0x1121858")]
			set
			{
			}
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1121860", Offset = "0x1121860", VA = "0x1121860")]
		internal bool IsSetCodeDeliveryDetails()
		{
			return default;
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1121870", Offset = "0x1121870", VA = "0x1121870")]
		public GetUserAttributeVerificationCodeResponse()
		{
		}
	}
}
