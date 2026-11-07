using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SetRiskConfigurationResponse : AmazonWebServiceResponse
	{
		private RiskConfigurationType _riskConfiguration;

		[AWSProperty]
		public RiskConfigurationType RiskConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetRiskConfiguration()
		{
			return false;
		}
	}
}
