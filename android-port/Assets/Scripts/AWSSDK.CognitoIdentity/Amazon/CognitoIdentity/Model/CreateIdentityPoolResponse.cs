using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class CreateIdentityPoolResponse : AmazonWebServiceResponse
	{
		private bool? _allowClassicFlow;

		private bool? _allowUnauthenticatedIdentities;

		private List<CognitoIdentityProviderInfo> _cognitoIdentityProviders;

		private string _developerProviderName;

		private string _identityPoolId;

		private string _identityPoolName;

		private Dictionary<string, string> _identityPoolTags;

		private List<string> _openIdConnectProviderARNs;

		private List<string> _samlProviderARNs;

		private Dictionary<string, string> _supportedLoginProviders;

		public bool AllowClassicFlow
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
		public bool AllowUnauthenticatedIdentities
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<CognitoIdentityProviderInfo> CognitoIdentityProviders
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
		public string DeveloperProviderName
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
		public string IdentityPoolId
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
		public string IdentityPoolName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, string> IdentityPoolTags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> OpenIdConnectProviderARNs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> SamlProviderARNs
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
		public Dictionary<string, string> SupportedLoginProviders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAllowClassicFlow()
		{
			return false;
		}

		internal bool IsSetAllowUnauthenticatedIdentities()
		{
			return false;
		}

		internal bool IsSetCognitoIdentityProviders()
		{
			return false;
		}

		internal bool IsSetDeveloperProviderName()
		{
			return false;
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}

		internal bool IsSetIdentityPoolName()
		{
			return false;
		}

		internal bool IsSetIdentityPoolTags()
		{
			return false;
		}

		internal bool IsSetOpenIdConnectProviderARNs()
		{
			return false;
		}

		internal bool IsSetSamlProviderARNs()
		{
			return false;
		}

		internal bool IsSetSupportedLoginProviders()
		{
			return false;
		}
	}
}
