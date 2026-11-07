using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000FF")]
	public class ResendConfirmationCodeResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x28")]
		private CodeDeliveryDetailsType _codeDeliveryDetails;

		[Token(Token = "0x170001F2")]
		public CodeDeliveryDetailsType CodeDeliveryDetails
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x1143A10", Offset = "0x1143A10", VA = "0x1143A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x1143A18", Offset = "0x1143A18", VA = "0x1143A18")]
			set
			{
			}
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1143A20", Offset = "0x1143A20", VA = "0x1143A20")]
		internal bool IsSetCodeDeliveryDetails()
		{
			return default;
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1143A30", Offset = "0x1143A30", VA = "0x1143A30")]
		public ResendConfirmationCodeResponse()
		{
		}
	}
}
