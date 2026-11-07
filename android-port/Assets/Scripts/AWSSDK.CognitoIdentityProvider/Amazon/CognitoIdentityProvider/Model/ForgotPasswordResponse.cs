using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B6")]
	public class ForgotPasswordResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x28")]
		private CodeDeliveryDetailsType _codeDeliveryDetails;

		[Token(Token = "0x17000154")]
		public CodeDeliveryDetailsType CodeDeliveryDetails
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x11163F0", Offset = "0x11163F0", VA = "0x11163F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x11163F8", Offset = "0x11163F8", VA = "0x11163F8")]
			set
			{
			}
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1116400", Offset = "0x1116400", VA = "0x1116400")]
		internal bool IsSetCodeDeliveryDetails()
		{
			return default;
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1116410", Offset = "0x1116410", VA = "0x1116410")]
		public ForgotPasswordResponse()
		{
		}
	}
}
