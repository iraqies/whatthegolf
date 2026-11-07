using System;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class RiskConfigurationType
	{
		private AccountTakeoverRiskConfigurationType _accountTakeoverRiskConfiguration;

		private string _clientId;

		private CompromisedCredentialsRiskConfigurationType _compromisedCredentialsRiskConfiguration;

		private DateTime? _lastModifiedDate;

		private RiskExceptionConfigurationType _riskExceptionConfiguration;

		private string _userPoolId;

		public AccountTakeoverRiskConfigurationType AccountTakeoverRiskConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string ClientId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CompromisedCredentialsRiskConfigurationType CompromisedCredentialsRiskConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime LastModifiedDate
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public RiskExceptionConfigurationType RiskExceptionConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string UserPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccountTakeoverRiskConfiguration()
		{
			return false;
		}

		internal bool IsSetClientId()
		{
			return false;
		}

		internal bool IsSetCompromisedCredentialsRiskConfiguration()
		{
			return false;
		}

		internal bool IsSetLastModifiedDate()
		{
			return false;
		}

		internal bool IsSetRiskExceptionConfiguration()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
