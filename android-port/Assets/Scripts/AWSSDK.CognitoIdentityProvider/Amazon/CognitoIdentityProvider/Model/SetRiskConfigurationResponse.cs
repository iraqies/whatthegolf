using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200010A")]
	public class SetRiskConfigurationResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x28")]
		private RiskConfigurationType _riskConfiguration;

		[Token(Token = "0x17000218")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x202B8", Offset = "0x202B8")]
		public RiskConfigurationType RiskConfiguration
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x114C554", Offset = "0x114C554", VA = "0x114C554")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x114C55C", Offset = "0x114C55C", VA = "0x114C55C")]
			set
			{
			}
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x114C564", Offset = "0x114C564", VA = "0x114C564")]
		internal bool IsSetRiskConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x114C574", Offset = "0x114C574", VA = "0x114C574")]
		public SetRiskConfigurationResponse()
		{
		}
	}
}
