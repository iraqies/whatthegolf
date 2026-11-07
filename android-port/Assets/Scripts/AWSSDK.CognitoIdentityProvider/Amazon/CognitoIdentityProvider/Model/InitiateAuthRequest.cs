using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000CF")]
	public class InitiateAuthRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x30")]
		private AnalyticsMetadataType _analyticsMetadata;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x38")]
		private AuthFlowType _authFlow;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _authParameters;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x48")]
		private string _clientId;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x58")]
		private UserContextDataType _userContextData;

		[Token(Token = "0x17000186")]
		public AnalyticsMetadataType AnalyticsMetadata
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1128700", Offset = "0x1128700", VA = "0x1128700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1128708", Offset = "0x1128708", VA = "0x1128708")]
			set
			{
			}
		}

		[Token(Token = "0x17000187")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EAC4", Offset = "0x1EAC4")]
		public AuthFlowType AuthFlow
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1128720", Offset = "0x1128720", VA = "0x1128720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1128728", Offset = "0x1128728", VA = "0x1128728")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public Dictionary<string, string> AuthParameters
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x11287AC", Offset = "0x11287AC", VA = "0x11287AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x11287B4", Offset = "0x11287B4", VA = "0x11287B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EAF8", Offset = "0x1EAF8")]
		public string ClientId
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1128818", Offset = "0x1128818", VA = "0x1128818")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1128820", Offset = "0x1128820", VA = "0x1128820")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1128838", Offset = "0x1128838", VA = "0x1128838")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1128840", Offset = "0x1128840", VA = "0x1128840")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public UserContextDataType UserContextData
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x11288A4", Offset = "0x11288A4", VA = "0x11288A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x11288AC", Offset = "0x11288AC", VA = "0x11288AC")]
			set
			{
			}
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1128710", Offset = "0x1128710", VA = "0x1128710")]
		internal bool IsSetAnalyticsMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1128730", Offset = "0x1128730", VA = "0x1128730")]
		internal bool IsSetAuthFlow()
		{
			return default;
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x11287BC", Offset = "0x11287BC", VA = "0x11287BC")]
		internal bool IsSetAuthParameters()
		{
			return default;
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1128828", Offset = "0x1128828", VA = "0x1128828")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1128848", Offset = "0x1128848", VA = "0x1128848")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x11288B4", Offset = "0x11288B4", VA = "0x11288B4")]
		internal bool IsSetUserContextData()
		{
			return default;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x11288C4", Offset = "0x11288C4", VA = "0x11288C4", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x112891C", Offset = "0x112891C", VA = "0x112891C")]
		public InitiateAuthRequest()
		{
		}
	}
}
