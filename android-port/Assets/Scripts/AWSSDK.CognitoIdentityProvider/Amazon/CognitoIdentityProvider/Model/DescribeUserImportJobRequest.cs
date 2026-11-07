using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A0")]
	public class DescribeUserImportJobRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x30")]
		private string _jobId;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000121")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DDC0", Offset = "0x1DDC0")]
		public string JobId
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1108D4C", Offset = "0x1108D4C", VA = "0x1108D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1108D54", Offset = "0x1108D54", VA = "0x1108D54")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DE10", Offset = "0x1DE10")]
		public string UserPoolId
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1108D6C", Offset = "0x1108D6C", VA = "0x1108D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x1108D74", Offset = "0x1108D74", VA = "0x1108D74")]
			set
			{
			}
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1108D5C", Offset = "0x1108D5C", VA = "0x1108D5C")]
		internal bool IsSetJobId()
		{
			return default;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1108D7C", Offset = "0x1108D7C", VA = "0x1108D7C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1108D8C", Offset = "0x1108D8C", VA = "0x1108D8C")]
		public DescribeUserImportJobRequest()
		{
		}
	}
}
