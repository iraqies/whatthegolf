using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000045")]
	public class AdminInitiateAuthRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x38")]
		private AuthFlowType _authFlow;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _authParameters;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x48")]
		private string _clientId;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x58")]
		private ContextDataType _contextData;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x60")]
		private string _userPoolId;

		[Token(Token = "0x1700003F")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x10ACE64", Offset = "0x10ACE64", VA = "0x10ACE64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x10ACE6C", Offset = "0x10ACE6C", VA = "0x10ACE6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B660", Offset = "0x1B660")]
		public AuthFlowType AuthFlow
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x10ACE84", Offset = "0x10ACE84", VA = "0x10ACE84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x10ACE8C", Offset = "0x10ACE8C", VA = "0x10ACE8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public Dictionary<string, string> AuthParameters
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x10ACF10", Offset = "0x10ACF10", VA = "0x10ACF10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x10ACF18", Offset = "0x10ACF18", VA = "0x10ACF18")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B694", Offset = "0x1B694")]
		public string ClientId
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x10ACF7C", Offset = "0x10ACF7C", VA = "0x10ACF7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x10ACF84", Offset = "0x10ACF84", VA = "0x10ACF84")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x10ACF9C", Offset = "0x10ACF9C", VA = "0x10ACF9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x10ACFA4", Offset = "0x10ACFA4", VA = "0x10ACFA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public ContextDataType ContextData
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x10AD008", Offset = "0x10AD008", VA = "0x10AD008")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x10AD010", Offset = "0x10AD010", VA = "0x10AD010")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B6E4", Offset = "0x1B6E4")]
		public string UserPoolId
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x10AD028", Offset = "0x10AD028", VA = "0x10AD028")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x10AD030", Offset = "0x10AD030", VA = "0x10AD030")]
			set
			{
			}
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x10ACE74", Offset = "0x10ACE74", VA = "0x10ACE74")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x10ACE94", Offset = "0x10ACE94", VA = "0x10ACE94")]
		internal bool IsSetAuthFlow()
		{
			return default;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x10ACF20", Offset = "0x10ACF20", VA = "0x10ACF20")]
		internal bool IsSetAuthParameters()
		{
			return default;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x10ACF8C", Offset = "0x10ACF8C", VA = "0x10ACF8C")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x10ACFAC", Offset = "0x10ACFAC", VA = "0x10ACFAC")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x10AD018", Offset = "0x10AD018", VA = "0x10AD018")]
		internal bool IsSetContextData()
		{
			return default;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x10AD038", Offset = "0x10AD038", VA = "0x10AD038")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x10AD048", Offset = "0x10AD048", VA = "0x10AD048")]
		public AdminInitiateAuthRequest()
		{
		}
	}
}
