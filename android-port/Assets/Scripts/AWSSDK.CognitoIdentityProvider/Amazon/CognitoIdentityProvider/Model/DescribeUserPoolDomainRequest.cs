using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A4")]
	public class DescribeUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x30")]
		private string _domain;

		[Token(Token = "0x17000127")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DF00", Offset = "0x1DF00")]
		public string Domain
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x110B764", Offset = "0x110B764", VA = "0x110B764")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x110B76C", Offset = "0x110B76C", VA = "0x110B76C")]
			set
			{
			}
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x110B774", Offset = "0x110B774", VA = "0x110B774")]
		internal bool IsSetDomain()
		{
			return default;
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x110B784", Offset = "0x110B784", VA = "0x110B784")]
		public DescribeUserPoolDomainRequest()
		{
		}
	}
}
