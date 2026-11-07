using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000BF")]
	public class GetSigningCertificateRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x30")]
		private string _userPoolId;

		[Token(Token = "0x17000161")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E5C8", Offset = "0x1E5C8")]
		public string UserPoolId
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x111E1D4", Offset = "0x111E1D4", VA = "0x111E1D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x111E1DC", Offset = "0x111E1DC", VA = "0x111E1DC")]
			set
			{
			}
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x111E1E4", Offset = "0x111E1E4", VA = "0x111E1E4")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x111E1F4", Offset = "0x111E1F4", VA = "0x111E1F4")]
		public GetSigningCertificateRequest()
		{
		}
	}
}
