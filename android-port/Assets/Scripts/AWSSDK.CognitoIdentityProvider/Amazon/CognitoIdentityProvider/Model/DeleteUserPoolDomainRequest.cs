using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000094")]
	public class DeleteUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x30")]
		private string _domain;

		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000114")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DA28", Offset = "0x1DA28")]
		public string Domain
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1100D74", Offset = "0x1100D74", VA = "0x1100D74")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1100D7C", Offset = "0x1100D7C", VA = "0x1100D7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DA78", Offset = "0x1DA78")]
		public string UserPoolId
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1100D94", Offset = "0x1100D94", VA = "0x1100D94")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x1100D9C", Offset = "0x1100D9C", VA = "0x1100D9C")]
			set
			{
			}
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1100D84", Offset = "0x1100D84", VA = "0x1100D84")]
		internal bool IsSetDomain()
		{
			return default;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1100DA4", Offset = "0x1100DA4", VA = "0x1100DA4")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1100DB4", Offset = "0x1100DB4", VA = "0x1100DB4")]
		public DeleteUserPoolDomainRequest()
		{
		}
	}
}
