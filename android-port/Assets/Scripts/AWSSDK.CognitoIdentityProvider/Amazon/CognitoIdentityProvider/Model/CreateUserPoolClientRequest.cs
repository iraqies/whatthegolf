using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
	{
		private List<string> _allowedOAuthFlows;

		private bool? _allowedOAuthFlowsUserPoolClient;

		private List<string> _allowedOAuthScopes;

		private AnalyticsConfigurationType _analyticsConfiguration;

		private List<string> _callbackURLs;

		private string _clientName;

		private string _defaultRedirectURI;

		private List<string> _explicitAuthFlows;

		private bool? _generateSecret;

		private List<string> _logoutURLs;

		private PreventUserExistenceErrorTypes _preventUserExistenceErrors;

		private List<string> _readAttributes;

		private int? _refreshTokenValidity;

		private List<string> _supportedIdentityProviders;

		private string _userPoolId;

		private List<string> _writeAttributes;

		[AWSProperty]
		public List<string> AllowedOAuthFlows
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AllowedOAuthFlowsUserPoolClient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[AWSProperty]
		public List<string> AllowedOAuthScopes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AnalyticsConfigurationType AnalyticsConfiguration
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
		public List<string> CallbackURLs
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
		public string ClientName
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
		public string DefaultRedirectURI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> ExplicitAuthFlows
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool GenerateSecret
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[AWSProperty]
		public List<string> LogoutURLs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PreventUserExistenceErrorTypes PreventUserExistenceErrors
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> ReadAttributes
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
		public int RefreshTokenValidity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<string> SupportedIdentityProviders
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

		public List<string> WriteAttributes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAllowedOAuthFlows()
		{
			return false;
		}

		internal bool IsSetAllowedOAuthFlowsUserPoolClient()
		{
			return false;
		}

		internal bool IsSetAllowedOAuthScopes()
		{
			return false;
		}

		internal bool IsSetAnalyticsConfiguration()
		{
			return false;
		}

		internal bool IsSetCallbackURLs()
		{
			return false;
		}

		internal bool IsSetClientName()
		{
			return false;
		}

		internal bool IsSetDefaultRedirectURI()
		{
			return false;
		}

		internal bool IsSetExplicitAuthFlows()
		{
			return false;
		}

		internal bool IsSetGenerateSecret()
		{
			return false;
		}

		internal bool IsSetLogoutURLs()
		{
			return false;
		}

		internal bool IsSetPreventUserExistenceErrors()
		{
			return false;
		}

		internal bool IsSetReadAttributes()
		{
			return false;
		}

		internal bool IsSetRefreshTokenValidity()
		{
			return false;
		}

		internal bool IsSetSupportedIdentityProviders()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}

		internal bool IsSetWriteAttributes()
		{
			return false;
		}
	}
}
