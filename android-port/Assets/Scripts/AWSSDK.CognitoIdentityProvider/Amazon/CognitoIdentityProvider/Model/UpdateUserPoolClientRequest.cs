using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000136")]
	public class UpdateUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _allowedOAuthFlows;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x38")]
		private bool? _allowedOAuthFlowsUserPoolClient;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x40")]
		private List<string> _allowedOAuthScopes;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x48")]
		private AnalyticsConfigurationType _analyticsConfiguration;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _callbackURLs;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x58")]
		private string _clientId;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x60")]
		private string _clientName;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x68")]
		private string _defaultRedirectURI;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x70")]
		private List<string> _explicitAuthFlows;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x78")]
		private List<string> _logoutURLs;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x80")]
		private PreventUserExistenceErrorTypes _preventUserExistenceErrors;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x88")]
		private List<string> _readAttributes;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x90")]
		private int? _refreshTokenValidity;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x98")]
		private List<string> _supportedIdentityProviders;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0xA0")]
		private string _userPoolId;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0xA8")]
		private List<string> _writeAttributes;

		[Token(Token = "0x1700026F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20FC8", Offset = "0x20FC8")]
		public List<string> AllowedOAuthFlows
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x1169C00", Offset = "0x1169C00", VA = "0x1169C00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x1169C08", Offset = "0x1169C08", VA = "0x1169C08")]
			set
			{
			}
		}

		[Token(Token = "0x17000270")]
		public bool AllowedOAuthFlowsUserPoolClient
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x1169C68", Offset = "0x1169C68", VA = "0x1169C68")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x1169CA8", Offset = "0x1169CA8", VA = "0x1169CA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000271")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21010", Offset = "0x21010")]
		public List<string> AllowedOAuthScopes
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x1169D5C", Offset = "0x1169D5C", VA = "0x1169D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x1169D64", Offset = "0x1169D64", VA = "0x1169D64")]
			set
			{
			}
		}

		[Token(Token = "0x17000272")]
		public AnalyticsConfigurationType AnalyticsConfiguration
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x1169DC4", Offset = "0x1169DC4", VA = "0x1169DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x1169DCC", Offset = "0x1169DCC", VA = "0x1169DCC")]
			set
			{
			}
		}

		[Token(Token = "0x17000273")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21048", Offset = "0x21048")]
		public List<string> CallbackURLs
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x1169DE4", Offset = "0x1169DE4", VA = "0x1169DE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x1169DEC", Offset = "0x1169DEC", VA = "0x1169DEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000274")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21090", Offset = "0x21090")]
		public string ClientId
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x1169E4C", Offset = "0x1169E4C", VA = "0x1169E4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x1169E54", Offset = "0x1169E54", VA = "0x1169E54")]
			set
			{
			}
		}

		[Token(Token = "0x17000275")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x210E0", Offset = "0x210E0")]
		public string ClientName
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x1169E6C", Offset = "0x1169E6C", VA = "0x1169E6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1169E74", Offset = "0x1169E74", VA = "0x1169E74")]
			set
			{
			}
		}

		[Token(Token = "0x17000276")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21128", Offset = "0x21128")]
		public string DefaultRedirectURI
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x1169E8C", Offset = "0x1169E8C", VA = "0x1169E8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x1169E94", Offset = "0x1169E94", VA = "0x1169E94")]
			set
			{
			}
		}

		[Token(Token = "0x17000277")]
		public List<string> ExplicitAuthFlows
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x1169EAC", Offset = "0x1169EAC", VA = "0x1169EAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x1169EB4", Offset = "0x1169EB4", VA = "0x1169EB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000278")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21170", Offset = "0x21170")]
		public List<string> LogoutURLs
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x1169F14", Offset = "0x1169F14", VA = "0x1169F14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1169F1C", Offset = "0x1169F1C", VA = "0x1169F1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000279")]
		public PreventUserExistenceErrorTypes PreventUserExistenceErrors
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x1169F7C", Offset = "0x1169F7C", VA = "0x1169F7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x1169F84", Offset = "0x1169F84", VA = "0x1169F84")]
			set
			{
			}
		}

		[Token(Token = "0x1700027A")]
		public List<string> ReadAttributes
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x116A008", Offset = "0x116A008", VA = "0x116A008")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x116A010", Offset = "0x116A010", VA = "0x116A010")]
			set
			{
			}
		}

		[Token(Token = "0x1700027B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x211B8", Offset = "0x211B8")]
		public int RefreshTokenValidity
		{
			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x116A070", Offset = "0x116A070", VA = "0x116A070")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x116A0B0", Offset = "0x116A0B0", VA = "0x116A0B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700027C")]
		public List<string> SupportedIdentityProviders
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x116A164", Offset = "0x116A164", VA = "0x116A164")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x116A16C", Offset = "0x116A16C", VA = "0x116A16C")]
			set
			{
			}
		}

		[Token(Token = "0x1700027D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21200", Offset = "0x21200")]
		public string UserPoolId
		{
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x116A1CC", Offset = "0x116A1CC", VA = "0x116A1CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x116A1D4", Offset = "0x116A1D4", VA = "0x116A1D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700027E")]
		public List<string> WriteAttributes
		{
			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x116A1EC", Offset = "0x116A1EC", VA = "0x116A1EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x116A1F4", Offset = "0x116A1F4", VA = "0x116A1F4")]
			set
			{
			}
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x1169C10", Offset = "0x1169C10", VA = "0x1169C10")]
		internal bool IsSetAllowedOAuthFlows()
		{
			return default;
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1169D1C", Offset = "0x1169D1C", VA = "0x1169D1C")]
		internal bool IsSetAllowedOAuthFlowsUserPoolClient()
		{
			return default;
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1169D6C", Offset = "0x1169D6C", VA = "0x1169D6C")]
		internal bool IsSetAllowedOAuthScopes()
		{
			return default;
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1169DD4", Offset = "0x1169DD4", VA = "0x1169DD4")]
		internal bool IsSetAnalyticsConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1169DF4", Offset = "0x1169DF4", VA = "0x1169DF4")]
		internal bool IsSetCallbackURLs()
		{
			return default;
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x1169E5C", Offset = "0x1169E5C", VA = "0x1169E5C")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x1169E7C", Offset = "0x1169E7C", VA = "0x1169E7C")]
		internal bool IsSetClientName()
		{
			return default;
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x1169E9C", Offset = "0x1169E9C", VA = "0x1169E9C")]
		internal bool IsSetDefaultRedirectURI()
		{
			return default;
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x1169EBC", Offset = "0x1169EBC", VA = "0x1169EBC")]
		internal bool IsSetExplicitAuthFlows()
		{
			return default;
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x1169F24", Offset = "0x1169F24", VA = "0x1169F24")]
		internal bool IsSetLogoutURLs()
		{
			return default;
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x1169F8C", Offset = "0x1169F8C", VA = "0x1169F8C")]
		internal bool IsSetPreventUserExistenceErrors()
		{
			return default;
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x116A018", Offset = "0x116A018", VA = "0x116A018")]
		internal bool IsSetReadAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x116A124", Offset = "0x116A124", VA = "0x116A124")]
		internal bool IsSetRefreshTokenValidity()
		{
			return default;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x116A174", Offset = "0x116A174", VA = "0x116A174")]
		internal bool IsSetSupportedIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x116A1DC", Offset = "0x116A1DC", VA = "0x116A1DC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x116A1FC", Offset = "0x116A1FC", VA = "0x116A1FC")]
		internal bool IsSetWriteAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x116A254", Offset = "0x116A254", VA = "0x116A254")]
		public UpdateUserPoolClientRequest()
		{
		}
	}
}
