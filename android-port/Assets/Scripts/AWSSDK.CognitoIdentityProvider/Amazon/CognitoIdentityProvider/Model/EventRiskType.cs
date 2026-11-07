namespace Amazon.CognitoIdentityProvider.Model
{
	public class EventRiskType
	{
		private bool? _compromisedCredentialsDetected;

		private RiskDecisionType _riskDecision;

		private RiskLevelType _riskLevel;

		public bool CompromisedCredentialsDetected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RiskDecisionType RiskDecision
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RiskLevelType RiskLevel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCompromisedCredentialsDetected()
		{
			return false;
		}

		internal bool IsSetRiskDecision()
		{
			return false;
		}

		internal bool IsSetRiskLevel()
		{
			return false;
		}
	}
}
