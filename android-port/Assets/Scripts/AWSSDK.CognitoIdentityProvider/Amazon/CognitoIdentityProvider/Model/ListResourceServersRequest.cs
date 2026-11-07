using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000E2")]
	public class ListResourceServersRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x170001A9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F1AC", Offset = "0x1F1AC")]
		public int MaxResults
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1131B78", Offset = "0x1131B78", VA = "0x1131B78")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1131BB8", Offset = "0x1131BB8", VA = "0x1131BB8")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F1F4", Offset = "0x1F1F4")]
		public string NextToken
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1131C6C", Offset = "0x1131C6C", VA = "0x1131C6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1131C74", Offset = "0x1131C74", VA = "0x1131C74")]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F22C", Offset = "0x1F22C")]
		public string UserPoolId
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x1131C8C", Offset = "0x1131C8C", VA = "0x1131C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x1131C94", Offset = "0x1131C94", VA = "0x1131C94")]
			set
			{
			}
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1131C2C", Offset = "0x1131C2C", VA = "0x1131C2C")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1131C7C", Offset = "0x1131C7C", VA = "0x1131C7C")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1131C9C", Offset = "0x1131C9C", VA = "0x1131C9C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1131CAC", Offset = "0x1131CAC", VA = "0x1131CAC")]
		public ListResourceServersRequest()
		{
		}
	}
}
