using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B1")]
	public class EventRiskType
	{
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x10")]
		private bool? _compromisedCredentialsDetected;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x18")]
		private RiskDecisionType _riskDecision;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x20")]
		private RiskLevelType _riskLevel;

		[Token(Token = "0x17000149")]
		public bool CompromisedCredentialsDetected
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1112478", Offset = "0x1112478", VA = "0x1112478")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x11124B8", Offset = "0x11124B8", VA = "0x11124B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public RiskDecisionType RiskDecision
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x111256C", Offset = "0x111256C", VA = "0x111256C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x1112574", Offset = "0x1112574", VA = "0x1112574")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public RiskLevelType RiskLevel
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x11125F8", Offset = "0x11125F8", VA = "0x11125F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x1112600", Offset = "0x1112600", VA = "0x1112600")]
			set
			{
			}
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x111252C", Offset = "0x111252C", VA = "0x111252C")]
		internal bool IsSetCompromisedCredentialsDetected()
		{
			return default;
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x111257C", Offset = "0x111257C", VA = "0x111257C")]
		internal bool IsSetRiskDecision()
		{
			return default;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1112608", Offset = "0x1112608", VA = "0x1112608")]
		internal bool IsSetRiskLevel()
		{
			return default;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1112684", Offset = "0x1112684", VA = "0x1112684")]
		public EventRiskType()
		{
		}
	}
}
