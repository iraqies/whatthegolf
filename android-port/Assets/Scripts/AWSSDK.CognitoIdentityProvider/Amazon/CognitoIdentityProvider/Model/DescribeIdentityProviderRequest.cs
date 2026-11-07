using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200009A")]
	public class DescribeIdentityProviderRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x30")]
		private string _providerName;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000118")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DB4C", Offset = "0x1DB4C")]
		public string ProviderName
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x1104D5C", Offset = "0x1104D5C", VA = "0x1104D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1104D64", Offset = "0x1104D64", VA = "0x1104D64")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DB9C", Offset = "0x1DB9C")]
		public string UserPoolId
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1104D7C", Offset = "0x1104D7C", VA = "0x1104D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1104D84", Offset = "0x1104D84", VA = "0x1104D84")]
			set
			{
			}
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1104D6C", Offset = "0x1104D6C", VA = "0x1104D6C")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1104D8C", Offset = "0x1104D8C", VA = "0x1104D8C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1104D9C", Offset = "0x1104D9C", VA = "0x1104D9C")]
		public DescribeIdentityProviderRequest()
		{
		}
	}
}
