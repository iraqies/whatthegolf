using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200008C")]
	public class DeleteIdentityProviderRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x30")]
		private string _providerName;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700010C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D7E0", Offset = "0x1D7E0")]
		public string ProviderName
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x10FB8C8", Offset = "0x10FB8C8", VA = "0x10FB8C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x10FB8D0", Offset = "0x10FB8D0", VA = "0x10FB8D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D830", Offset = "0x1D830")]
		public string UserPoolId
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x10FB8E8", Offset = "0x10FB8E8", VA = "0x10FB8E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x10FB8F0", Offset = "0x10FB8F0", VA = "0x10FB8F0")]
			set
			{
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x10FB8D8", Offset = "0x10FB8D8", VA = "0x10FB8D8")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x10FB8F8", Offset = "0x10FB8F8", VA = "0x10FB8F8")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x10FB908", Offset = "0x10FB908", VA = "0x10FB908")]
		public DeleteIdentityProviderRequest()
		{
		}
	}
}
