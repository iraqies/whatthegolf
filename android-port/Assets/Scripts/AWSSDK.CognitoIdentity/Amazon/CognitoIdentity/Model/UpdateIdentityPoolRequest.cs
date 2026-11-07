using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000055")]
	public class UpdateIdentityPoolRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x29")]
		private bool? _allowClassicFlow;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x2B")]
		private bool? _allowUnauthenticatedIdentities;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x30")]
		private List<CognitoIdentityProviderInfo> _cognitoIdentityProviders;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x38")]
		private string _developerProviderName;

		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolId;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x48")]
		private string _identityPoolName;

		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, string> _identityPoolTags;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x58")]
		private List<string> _openIdConnectProviderARNs;

		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x60")]
		private List<string> _samlProviderARNs;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, string> _supportedLoginProviders;

		[Token(Token = "0x17000093")]
		public bool AllowClassicFlow
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x11865AC", Offset = "0x11865AC", VA = "0x11865AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x11865EC", Offset = "0x11865EC", VA = "0x11865EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23C60", Offset = "0x23C60")]
		public bool AllowUnauthenticatedIdentities
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x11866A0", Offset = "0x11866A0", VA = "0x11866A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x11866E0", Offset = "0x11866E0", VA = "0x11866E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public List<CognitoIdentityProviderInfo> CognitoIdentityProviders
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1186794", Offset = "0x1186794", VA = "0x1186794")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x118679C", Offset = "0x118679C", VA = "0x118679C")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23C94", Offset = "0x23C94")]
		public string DeveloperProviderName
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x11867FC", Offset = "0x11867FC", VA = "0x11867FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x1186804", Offset = "0x1186804", VA = "0x1186804")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23CDC", Offset = "0x23CDC")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x118681C", Offset = "0x118681C", VA = "0x118681C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x1186824", Offset = "0x1186824", VA = "0x1186824")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23D2C", Offset = "0x23D2C")]
		public string IdentityPoolName
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x118683C", Offset = "0x118683C", VA = "0x118683C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x1186844", Offset = "0x1186844", VA = "0x1186844")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public Dictionary<string, string> IdentityPoolTags
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x118685C", Offset = "0x118685C", VA = "0x118685C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1186864", Offset = "0x1186864", VA = "0x1186864")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public List<string> OpenIdConnectProviderARNs
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x11868C8", Offset = "0x11868C8", VA = "0x11868C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x11868D0", Offset = "0x11868D0", VA = "0x11868D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public List<string> SamlProviderARNs
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1186930", Offset = "0x1186930", VA = "0x1186930")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1186938", Offset = "0x1186938", VA = "0x1186938")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23D7C", Offset = "0x23D7C")]
		public Dictionary<string, string> SupportedLoginProviders
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1186998", Offset = "0x1186998", VA = "0x1186998")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x11869A0", Offset = "0x11869A0", VA = "0x11869A0")]
			set
			{
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1186660", Offset = "0x1186660", VA = "0x1186660")]
		internal bool IsSetAllowClassicFlow()
		{
			return default;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1186754", Offset = "0x1186754", VA = "0x1186754")]
		internal bool IsSetAllowUnauthenticatedIdentities()
		{
			return default;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x11867A4", Offset = "0x11867A4", VA = "0x11867A4")]
		internal bool IsSetCognitoIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x118680C", Offset = "0x118680C", VA = "0x118680C")]
		internal bool IsSetDeveloperProviderName()
		{
			return default;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x118682C", Offset = "0x118682C", VA = "0x118682C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x118684C", Offset = "0x118684C", VA = "0x118684C")]
		internal bool IsSetIdentityPoolName()
		{
			return default;
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x118686C", Offset = "0x118686C", VA = "0x118686C")]
		internal bool IsSetIdentityPoolTags()
		{
			return default;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x11868D8", Offset = "0x11868D8", VA = "0x11868D8")]
		internal bool IsSetOpenIdConnectProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1186940", Offset = "0x1186940", VA = "0x1186940")]
		internal bool IsSetSamlProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11869A8", Offset = "0x11869A8", VA = "0x11869A8")]
		internal bool IsSetSupportedLoginProviders()
		{
			return default;
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1186A04", Offset = "0x1186A04", VA = "0x1186A04")]
		public UpdateIdentityPoolRequest()
		{
		}
	}
}
