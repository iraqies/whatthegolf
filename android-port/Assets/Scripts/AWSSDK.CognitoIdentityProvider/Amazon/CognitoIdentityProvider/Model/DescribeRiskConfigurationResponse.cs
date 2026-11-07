using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DescribeRiskConfigurationResponse : AmazonWebServiceResponse
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
