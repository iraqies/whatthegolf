using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200001D")]
	public class CreateIdentityPoolRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x29")]
		private bool? _allowClassicFlow;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x2B")]
		private bool? _allowUnauthenticatedIdentities;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x30")]
		private List<CognitoIdentityProviderInfo> _cognitoIdentityProviders;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x38")]
		private string _developerProviderName;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolName;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> _identityPoolTags;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _openIdConnectProviderARNs;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x58")]
		private List<string> _samlProviderARNs;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, string> _supportedLoginProviders;

		[Token(Token = "0x1700001E")]
		public bool AllowClassicFlow
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1078F80", Offset = "0x1078F80", VA = "0x1078F80")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1078FC0", Offset = "0x1078FC0", VA = "0x1078FC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22514", Offset = "0x22514")]
		public bool AllowUnauthenticatedIdentities
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x1079074", Offset = "0x1079074", VA = "0x1079074")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x10790B4", Offset = "0x10790B4", VA = "0x10790B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public List<CognitoIdentityProviderInfo> CognitoIdentityProviders
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1079168", Offset = "0x1079168", VA = "0x1079168")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1079170", Offset = "0x1079170", VA = "0x1079170")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22548", Offset = "0x22548")]
		public string DeveloperProviderName
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x10791D0", Offset = "0x10791D0", VA = "0x10791D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x10791D8", Offset = "0x10791D8", VA = "0x10791D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22590", Offset = "0x22590")]
		public string IdentityPoolName
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x10791F0", Offset = "0x10791F0", VA = "0x10791F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x10791F8", Offset = "0x10791F8", VA = "0x10791F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Dictionary<string, string> IdentityPoolTags
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1079210", Offset = "0x1079210", VA = "0x1079210")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1079218", Offset = "0x1079218", VA = "0x1079218")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public List<string> OpenIdConnectProviderARNs
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x107927C", Offset = "0x107927C", VA = "0x107927C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1079284", Offset = "0x1079284", VA = "0x1079284")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public List<string> SamlProviderARNs
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x10792E4", Offset = "0x10792E4", VA = "0x10792E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x10792EC", Offset = "0x10792EC", VA = "0x10792EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x225E0", Offset = "0x225E0")]
		public Dictionary<string, string> SupportedLoginProviders
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x107934C", Offset = "0x107934C", VA = "0x107934C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x1079354", Offset = "0x1079354", VA = "0x1079354")]
			set
			{
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1079034", Offset = "0x1079034", VA = "0x1079034")]
		internal bool IsSetAllowClassicFlow()
		{
			return default;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1079128", Offset = "0x1079128", VA = "0x1079128")]
		internal bool IsSetAllowUnauthenticatedIdentities()
		{
			return default;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1079178", Offset = "0x1079178", VA = "0x1079178")]
		internal bool IsSetCognitoIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x10791E0", Offset = "0x10791E0", VA = "0x10791E0")]
		internal bool IsSetDeveloperProviderName()
		{
			return default;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1079200", Offset = "0x1079200", VA = "0x1079200")]
		internal bool IsSetIdentityPoolName()
		{
			return default;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1079220", Offset = "0x1079220", VA = "0x1079220")]
		internal bool IsSetIdentityPoolTags()
		{
			return default;
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x107928C", Offset = "0x107928C", VA = "0x107928C")]
		internal bool IsSetOpenIdConnectProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x10792F4", Offset = "0x10792F4", VA = "0x10792F4")]
		internal bool IsSetSamlProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x107935C", Offset = "0x107935C", VA = "0x107935C")]
		internal bool IsSetSupportedLoginProviders()
		{
			return default;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10793B8", Offset = "0x10793B8", VA = "0x10793B8")]
		public CreateIdentityPoolRequest()
		{
		}
	}
}
