using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200009E")]
	public class DescribeRiskConfigurationRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x30")]
		private string _clientId;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x1700011E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DCF4", Offset = "0x1DCF4")]
		public string ClientId
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1107774", Offset = "0x1107774", VA = "0x1107774")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x110777C", Offset = "0x110777C", VA = "0x110777C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DD3C", Offset = "0x1DD3C")]
		public string UserPoolId
		{
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x1107794", Offset = "0x1107794", VA = "0x1107794")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x110779C", Offset = "0x110779C", VA = "0x110779C")]
			set
			{
			}
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1107784", Offset = "0x1107784", VA = "0x1107784")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x11077A4", Offset = "0x11077A4", VA = "0x11077A4")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x11077B4", Offset = "0x11077B4", VA = "0x11077B4")]
		public DescribeRiskConfigurationRequest()
		{
		}
	}
}
