using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200008E")]
	public class DeleteResourceServerRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x30")]
		private string _identifier;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700010E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D880", Offset = "0x1D880")]
		public string Identifier
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x10FCD4C", Offset = "0x10FCD4C", VA = "0x10FCD4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x10FCD54", Offset = "0x10FCD54", VA = "0x10FCD54")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D8D0", Offset = "0x1D8D0")]
		public string UserPoolId
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x10FCD6C", Offset = "0x10FCD6C", VA = "0x10FCD6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x10FCD74", Offset = "0x10FCD74", VA = "0x10FCD74")]
			set
			{
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x10FCD5C", Offset = "0x10FCD5C", VA = "0x10FCD5C")]
		internal bool IsSetIdentifier()
		{
			return default;
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x10FCD7C", Offset = "0x10FCD7C", VA = "0x10FCD7C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x10FCD8C", Offset = "0x10FCD8C", VA = "0x10FCD8C")]
		public DeleteResourceServerRequest()
		{
		}
	}
}
