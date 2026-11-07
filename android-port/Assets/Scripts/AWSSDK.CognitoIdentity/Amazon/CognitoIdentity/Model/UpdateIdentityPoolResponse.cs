using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000056")]
	public class UpdateIdentityPoolResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x24")]
		private bool? _allowClassicFlow;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x26")]
		private bool? _allowUnauthenticatedIdentities;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x28")]
		private List<CognitoIdentityProviderInfo> _cognitoIdentityProviders;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x30")]
		private string _developerProviderName;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolName;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> _identityPoolTags;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _openIdConnectProviderARNs;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x58")]
		private List<string> _samlProviderARNs;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, string> _supportedLoginProviders;

		[Token(Token = "0x1700009D")]
		public bool AllowClassicFlow
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x118822C", Offset = "0x118822C", VA = "0x118822C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x118826C", Offset = "0x118826C", VA = "0x118826C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23DB4", Offset = "0x23DB4")]
		public bool AllowUnauthenticatedIdentities
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1188320", Offset = "0x1188320", VA = "0x1188320")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1188360", Offset = "0x1188360", VA = "0x1188360")]
			set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public List<CognitoIdentityProviderInfo> CognitoIdentityProviders
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x1188414", Offset = "0x1188414", VA = "0x1188414")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x118841C", Offset = "0x118841C", VA = "0x118841C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23DE8", Offset = "0x23DE8")]
		public string DeveloperProviderName
		{
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x118847C", Offset = "0x118847C", VA = "0x118847C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D7")]
			[Address(RVA = "0x1188484", Offset = "0x1188484", VA = "0x1188484")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23E30", Offset = "0x23E30")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x118849C", Offset = "0x118849C", VA = "0x118849C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x11884A4", Offset = "0x11884A4", VA = "0x11884A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23E80", Offset = "0x23E80")]
		public string IdentityPoolName
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x11884BC", Offset = "0x11884BC", VA = "0x11884BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x11884C4", Offset = "0x11884C4", VA = "0x11884C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public Dictionary<string, string> IdentityPoolTags
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x11884DC", Offset = "0x11884DC", VA = "0x11884DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x11884E4", Offset = "0x11884E4", VA = "0x11884E4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public List<string> OpenIdConnectProviderARNs
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1188548", Offset = "0x1188548", VA = "0x1188548")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x1188550", Offset = "0x1188550", VA = "0x1188550")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public List<string> SamlProviderARNs
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x11885B0", Offset = "0x11885B0", VA = "0x11885B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x11885B8", Offset = "0x11885B8", VA = "0x11885B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23ED0", Offset = "0x23ED0")]
		public Dictionary<string, string> SupportedLoginProviders
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x1188618", Offset = "0x1188618", VA = "0x1188618")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x1188620", Offset = "0x1188620", VA = "0x1188620")]
			set
			{
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x11882E0", Offset = "0x11882E0", VA = "0x11882E0")]
		internal bool IsSetAllowClassicFlow()
		{
			return default;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x11883D4", Offset = "0x11883D4", VA = "0x11883D4")]
		internal bool IsSetAllowUnauthenticatedIdentities()
		{
			return default;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1188424", Offset = "0x1188424", VA = "0x1188424")]
		internal bool IsSetCognitoIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x118848C", Offset = "0x118848C", VA = "0x118848C")]
		internal bool IsSetDeveloperProviderName()
		{
			return default;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11884AC", Offset = "0x11884AC", VA = "0x11884AC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11884CC", Offset = "0x11884CC", VA = "0x11884CC")]
		internal bool IsSetIdentityPoolName()
		{
			return default;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11884EC", Offset = "0x11884EC", VA = "0x11884EC")]
		internal bool IsSetIdentityPoolTags()
		{
			return default;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1188558", Offset = "0x1188558", VA = "0x1188558")]
		internal bool IsSetOpenIdConnectProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11885C0", Offset = "0x11885C0", VA = "0x11885C0")]
		internal bool IsSetSamlProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1188628", Offset = "0x1188628", VA = "0x1188628")]
		internal bool IsSetSupportedLoginProviders()
		{
			return default;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1188684", Offset = "0x1188684", VA = "0x1188684")]
		public UpdateIdentityPoolResponse()
		{
		}
	}
}
