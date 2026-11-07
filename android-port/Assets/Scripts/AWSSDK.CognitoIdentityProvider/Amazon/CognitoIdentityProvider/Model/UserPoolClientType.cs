using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000147")]
	public class UserPoolClientType
	{
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x10")]
		private List<string> _allowedOAuthFlows;

		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x18")]
		private bool? _allowedOAuthFlowsUserPoolClient;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x20")]
		private List<string> _allowedOAuthScopes;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x28")]
		private AnalyticsConfigurationType _analyticsConfiguration;

		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x30")]
		private List<string> _callbackURLs;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x38")]
		private string _clientId;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x40")]
		private string _clientName;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x48")]
		private string _clientSecret;

		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x50")]
		private DateTime? _creationDate;

		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x60")]
		private string _defaultRedirectURI;

		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x68")]
		private List<string> _explicitAuthFlows;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x70")]
		private DateTime? _lastModifiedDate;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0x80")]
		private List<string> _logoutURLs;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x88")]
		private PreventUserExistenceErrorTypes _preventUserExistenceErrors;

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x90")]
		private List<string> _readAttributes;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0x98")]
		private int? _refreshTokenValidity;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0xA0")]
		private List<string> _supportedIdentityProviders;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0xA8")]
		private string _userPoolId;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0xB0")]
		private List<string> _writeAttributes;

		[Token(Token = "0x170002A8")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x217CC", Offset = "0x217CC")]
		public List<string> AllowedOAuthFlows
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x1173F00", Offset = "0x1173F00", VA = "0x1173F00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x1173F08", Offset = "0x1173F08", VA = "0x1173F08")]
			set
			{
			}
		}

		[Token(Token = "0x170002A9")]
		public bool AllowedOAuthFlowsUserPoolClient
		{
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x1173F68", Offset = "0x1173F68", VA = "0x1173F68")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x1173FA8", Offset = "0x1173FA8", VA = "0x1173FA8")]
			set
			{
			}
		}

		[Token(Token = "0x170002AA")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21814", Offset = "0x21814")]
		public List<string> AllowedOAuthScopes
		{
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x117405C", Offset = "0x117405C", VA = "0x117405C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x1174064", Offset = "0x1174064", VA = "0x1174064")]
			set
			{
			}
		}

		[Token(Token = "0x170002AB")]
		public AnalyticsConfigurationType AnalyticsConfiguration
		{
			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x11740C4", Offset = "0x11740C4", VA = "0x11740C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x11740CC", Offset = "0x11740CC", VA = "0x11740CC")]
			set
			{
			}
		}

		[Token(Token = "0x170002AC")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2184C", Offset = "0x2184C")]
		public List<string> CallbackURLs
		{
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x11740E4", Offset = "0x11740E4", VA = "0x11740E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x11740EC", Offset = "0x11740EC", VA = "0x11740EC")]
			set
			{
			}
		}

		[Token(Token = "0x170002AD")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21894", Offset = "0x21894")]
		public string ClientId
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x117414C", Offset = "0x117414C", VA = "0x117414C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x1174154", Offset = "0x1174154", VA = "0x1174154")]
			set
			{
			}
		}

		[Token(Token = "0x170002AE")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x218DC", Offset = "0x218DC")]
		public string ClientName
		{
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x117416C", Offset = "0x117416C", VA = "0x117416C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x1174174", Offset = "0x1174174", VA = "0x1174174")]
			set
			{
			}
		}

		[Token(Token = "0x170002AF")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21924", Offset = "0x21924")]
		public string ClientSecret
		{
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x117418C", Offset = "0x117418C", VA = "0x117418C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x1174194", Offset = "0x1174194", VA = "0x1174194")]
			set
			{
			}
		}

		[Token(Token = "0x170002B0")]
		public DateTime CreationDate
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x11741AC", Offset = "0x11741AC", VA = "0x11741AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x11741EC", Offset = "0x11741EC", VA = "0x11741EC")]
			set
			{
			}
		}

		[Token(Token = "0x170002B1")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2196C", Offset = "0x2196C")]
		public string DefaultRedirectURI
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x11742A0", Offset = "0x11742A0", VA = "0x11742A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0x11742A8", Offset = "0x11742A8", VA = "0x11742A8")]
			set
			{
			}
		}

		[Token(Token = "0x170002B2")]
		public List<string> ExplicitAuthFlows
		{
			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x11742C0", Offset = "0x11742C0", VA = "0x11742C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x11742C8", Offset = "0x11742C8", VA = "0x11742C8")]
			set
			{
			}
		}

		[Token(Token = "0x170002B3")]
		public DateTime LastModifiedDate
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x1174328", Offset = "0x1174328", VA = "0x1174328")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x1174368", Offset = "0x1174368", VA = "0x1174368")]
			set
			{
			}
		}

		[Token(Token = "0x170002B4")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x219B4", Offset = "0x219B4")]
		public List<string> LogoutURLs
		{
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x117441C", Offset = "0x117441C", VA = "0x117441C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B98")]
			[Address(RVA = "0x1174424", Offset = "0x1174424", VA = "0x1174424")]
			set
			{
			}
		}

		[Token(Token = "0x170002B5")]
		public PreventUserExistenceErrorTypes PreventUserExistenceErrors
		{
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0x1174484", Offset = "0x1174484", VA = "0x1174484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x117448C", Offset = "0x117448C", VA = "0x117448C")]
			set
			{
			}
		}

		[Token(Token = "0x170002B6")]
		public List<string> ReadAttributes
		{
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x1174510", Offset = "0x1174510", VA = "0x1174510")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x1174518", Offset = "0x1174518", VA = "0x1174518")]
			set
			{
			}
		}

		[Token(Token = "0x170002B7")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x219FC", Offset = "0x219FC")]
		public int RefreshTokenValidity
		{
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x1174578", Offset = "0x1174578", VA = "0x1174578")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x11745B8", Offset = "0x11745B8", VA = "0x11745B8")]
			set
			{
			}
		}

		[Token(Token = "0x170002B8")]
		public List<string> SupportedIdentityProviders
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x117466C", Offset = "0x117466C", VA = "0x117466C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x1174674", Offset = "0x1174674", VA = "0x1174674")]
			set
			{
			}
		}

		[Token(Token = "0x170002B9")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x21A44", Offset = "0x21A44")]
		public string UserPoolId
		{
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x11746D4", Offset = "0x11746D4", VA = "0x11746D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x11746DC", Offset = "0x11746DC", VA = "0x11746DC")]
			set
			{
			}
		}

		[Token(Token = "0x170002BA")]
		public List<string> WriteAttributes
		{
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x11746F4", Offset = "0x11746F4", VA = "0x11746F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x11746FC", Offset = "0x11746FC", VA = "0x11746FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x1173F10", Offset = "0x1173F10", VA = "0x1173F10")]
		internal bool IsSetAllowedOAuthFlows()
		{
			return default;
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x117401C", Offset = "0x117401C", VA = "0x117401C")]
		internal bool IsSetAllowedOAuthFlowsUserPoolClient()
		{
			return default;
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x117406C", Offset = "0x117406C", VA = "0x117406C")]
		internal bool IsSetAllowedOAuthScopes()
		{
			return default;
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x11740D4", Offset = "0x11740D4", VA = "0x11740D4")]
		internal bool IsSetAnalyticsConfiguration()
		{
			return default;
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x11740F4", Offset = "0x11740F4", VA = "0x11740F4")]
		internal bool IsSetCallbackURLs()
		{
			return default;
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x117415C", Offset = "0x117415C", VA = "0x117415C")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x117417C", Offset = "0x117417C", VA = "0x117417C")]
		internal bool IsSetClientName()
		{
			return default;
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x117419C", Offset = "0x117419C", VA = "0x117419C")]
		internal bool IsSetClientSecret()
		{
			return default;
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x1174260", Offset = "0x1174260", VA = "0x1174260")]
		internal bool IsSetCreationDate()
		{
			return default;
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x11742B0", Offset = "0x11742B0", VA = "0x11742B0")]
		internal bool IsSetDefaultRedirectURI()
		{
			return default;
		}

		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x11742D0", Offset = "0x11742D0", VA = "0x11742D0")]
		internal bool IsSetExplicitAuthFlows()
		{
			return default;
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x11743DC", Offset = "0x11743DC", VA = "0x11743DC")]
		internal bool IsSetLastModifiedDate()
		{
			return default;
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x117442C", Offset = "0x117442C", VA = "0x117442C")]
		internal bool IsSetLogoutURLs()
		{
			return default;
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x1174494", Offset = "0x1174494", VA = "0x1174494")]
		internal bool IsSetPreventUserExistenceErrors()
		{
			return default;
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x1174520", Offset = "0x1174520", VA = "0x1174520")]
		internal bool IsSetReadAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x117462C", Offset = "0x117462C", VA = "0x117462C")]
		internal bool IsSetRefreshTokenValidity()
		{
			return default;
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x117467C", Offset = "0x117467C", VA = "0x117467C")]
		internal bool IsSetSupportedIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x11746E4", Offset = "0x11746E4", VA = "0x11746E4")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x1174704", Offset = "0x1174704", VA = "0x1174704")]
		internal bool IsSetWriteAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x117475C", Offset = "0x117475C", VA = "0x117475C")]
		public UserPoolClientType()
		{
		}
	}
}
