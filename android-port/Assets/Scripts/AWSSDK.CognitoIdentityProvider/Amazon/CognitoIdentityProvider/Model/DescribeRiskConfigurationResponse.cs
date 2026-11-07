using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200009F")]
	public class DescribeRiskConfigurationResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x28")]
		private RiskConfigurationType _riskConfiguration;

		[Token(Token = "0x17000120")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DD8C", Offset = "0x1DD8C")]
		public RiskConfigurationType RiskConfiguration
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1108290", Offset = "0x1108290", VA = "0x1108290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1108298", Offset = "0x1108298", VA = "0x1108298")]
			set
			{
			}
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x11082A0", Offset = "0x11082A0", VA = "0x11082A0")]
		internal bool IsSetRiskConfiguration()
		{
			return default;
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x11082B0", Offset = "0x11082B0", VA = "0x11082B0")]
		public DescribeRiskConfigurationResponse()
		{
		}
	}
}
