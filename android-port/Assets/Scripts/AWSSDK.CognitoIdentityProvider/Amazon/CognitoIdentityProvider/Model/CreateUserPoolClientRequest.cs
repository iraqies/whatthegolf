using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000083")]
	public class CreateUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _allowedOAuthFlows;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x38")]
		private bool? _allowedOAuthFlowsUserPoolClient;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x40")]
		private List<string> _allowedOAuthScopes;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x48")]
		private AnalyticsConfigurationType _analyticsConfiguration;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _callbackURLs;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x58")]
		private string _clientName;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x60")]
		private string _defaultRedirectURI;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x68")]
		private List<string> _explicitAuthFlows;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x70")]
		private bool? _generateSecret;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x78")]
		private List<string> _logoutURLs;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x80")]
		private PreventUserExistenceErrorTypes _preventUserExistenceErrors;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x88")]
		private List<string> _readAttributes;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x90")]
		private int? _refreshTokenValidity;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x98")]
		private List<string> _supportedIdentityProviders;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xA0")]
		private string _userPoolId;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xA8")]
		private List<string> _writeAttributes;

		[Token(Token = "0x170000DE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D210", Offset = "0x1D210")]
		public List<string> AllowedOAuthFlows
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x10F1FE0", Offset = "0x10F1FE0", VA = "0x10F1FE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x10F1FE8", Offset = "0x10F1FE8", VA = "0x10F1FE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public bool AllowedOAuthFlowsUserPoolClient
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x10F2048", Offset = "0x10F2048", VA = "0x10F2048")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x10F2088", Offset = "0x10F2088", VA = "0x10F2088")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D258", Offset = "0x1D258")]
		public List<string> AllowedOAuthScopes
		{
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x10F213C", Offset = "0x10F213C", VA = "0x10F213C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x10F2144", Offset = "0x10F2144", VA = "0x10F2144")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public AnalyticsConfigurationType AnalyticsConfiguration
		{
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x10F21A4", Offset = "0x10F21A4", VA = "0x10F21A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x10F21AC", Offset = "0x10F21AC", VA = "0x10F21AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D290", Offset = "0x1D290")]
		public List<string> CallbackURLs
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x10F21C4", Offset = "0x10F21C4", VA = "0x10F21C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x10F21CC", Offset = "0x10F21CC", VA = "0x10F21CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D2D8", Offset = "0x1D2D8")]
		public string ClientName
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x10F222C", Offset = "0x10F222C", VA = "0x10F222C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x10F2234", Offset = "0x10F2234", VA = "0x10F2234")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D328", Offset = "0x1D328")]
		public string DefaultRedirectURI
		{
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x10F224C", Offset = "0x10F224C", VA = "0x10F224C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x10F2254", Offset = "0x10F2254", VA = "0x10F2254")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public List<string> ExplicitAuthFlows
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x10F226C", Offset = "0x10F226C", VA = "0x10F226C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x10F2274", Offset = "0x10F2274", VA = "0x10F2274")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public bool GenerateSecret
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x10F22D4", Offset = "0x10F22D4", VA = "0x10F22D4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x10F2314", Offset = "0x10F2314", VA = "0x10F2314")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D370", Offset = "0x1D370")]
		public List<string> LogoutURLs
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x10F23C8", Offset = "0x10F23C8", VA = "0x10F23C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x10F23D0", Offset = "0x10F23D0", VA = "0x10F23D0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public PreventUserExistenceErrorTypes PreventUserExistenceErrors
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x10F2430", Offset = "0x10F2430", VA = "0x10F2430")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x10F2438", Offset = "0x10F2438", VA = "0x10F2438")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public List<string> ReadAttributes
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x10F24BC", Offset = "0x10F24BC", VA = "0x10F24BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x10F24C4", Offset = "0x10F24C4", VA = "0x10F24C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D3B8", Offset = "0x1D3B8")]
		public int RefreshTokenValidity
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x10F2524", Offset = "0x10F2524", VA = "0x10F2524")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x10F2564", Offset = "0x10F2564", VA = "0x10F2564")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public List<string> SupportedIdentityProviders
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x10F2618", Offset = "0x10F2618", VA = "0x10F2618")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x10F2620", Offset = "0x10F2620", VA = "0x10F2620")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D400", Offset = "0x1D400")]
		public string UserPoolId
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x10F2680", Offset = "0x10F2680", VA = "0x10F2680")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0x10F2688", Offset = "0x10F2688", VA = "0x10F2688")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public List<string> WriteAttributes
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x10F26A0", Offset = "0x10F26A0", VA = "0x10F26A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0x10F26A8", Offset = "0x10F26A8", VA = "0x10F26A8")]
			set
			{
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x10F1FF0", Offset = "0x10F1FF0", VA = "0x10F1FF0")]
		internal bool IsSetAllowedOAuthFlows()
		{
			return default;
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x10F20FC", Offset = "0x10F20FC", VA = "0x10F20FC")]
		internal bool IsSetAllowedOAuthFlowsUserPoolClient()
		{
			return default;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x10F214C", Offset = "0x10F214C", VA = "0x10F214C")]
		internal bool IsSetAllowedOAuthScopes()
		{
			return default;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x10F21B4", Offset = "0x10F21B4", VA = "0x10F21B4")]
		internal bool IsSetAnalyticsConfiguration()
		{
			return default;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x10F21D4", Offset = "0x10F21D4", VA = "0x10F21D4")]
		internal bool IsSetCallbackURLs()
		{
			return default;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x10F223C", Offset = "0x10F223C", VA = "0x10F223C")]
		internal bool IsSetClientName()
		{
			return default;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x10F225C", Offset = "0x10F225C", VA = "0x10F225C")]
		internal bool IsSetDefaultRedirectURI()
		{
			return default;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x10F227C", Offset = "0x10F227C", VA = "0x10F227C")]
		internal bool IsSetExplicitAuthFlows()
		{
			return default;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x10F2388", Offset = "0x10F2388", VA = "0x10F2388")]
		internal bool IsSetGenerateSecret()
		{
			return default;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x10F23D8", Offset = "0x10F23D8", VA = "0x10F23D8")]
		internal bool IsSetLogoutURLs()
		{
			return default;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x10F2440", Offset = "0x10F2440", VA = "0x10F2440")]
		internal bool IsSetPreventUserExistenceErrors()
		{
			return default;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x10F24CC", Offset = "0x10F24CC", VA = "0x10F24CC")]
		internal bool IsSetReadAttributes()
		{
			return default;
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x10F25D8", Offset = "0x10F25D8", VA = "0x10F25D8")]
		internal bool IsSetRefreshTokenValidity()
		{
			return default;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x10F2628", Offset = "0x10F2628", VA = "0x10F2628")]
		internal bool IsSetSupportedIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x10F2690", Offset = "0x10F2690", VA = "0x10F2690")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x10F26B0", Offset = "0x10F26B0", VA = "0x10F26B0")]
		internal bool IsSetWriteAttributes()
		{
			return default;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x10F2708", Offset = "0x10F2708", VA = "0x10F2708")]
		public CreateUserPoolClientRequest()
		{
		}
	}
}
