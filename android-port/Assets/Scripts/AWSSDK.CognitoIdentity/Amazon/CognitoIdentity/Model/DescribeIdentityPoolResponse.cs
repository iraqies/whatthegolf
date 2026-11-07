using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000024")]
	public class DescribeIdentityPoolResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x24")]
		private bool? _allowClassicFlow;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x26")]
		private bool? _allowUnauthenticatedIdentities;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x28")]
		private List<CognitoIdentityProviderInfo> _cognitoIdentityProviders;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x30")]
		private string _developerProviderName;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolName;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> _identityPoolTags;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _openIdConnectProviderARNs;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x58")]
		private List<string> _samlProviderARNs;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, string> _supportedLoginProviders;

		[Token(Token = "0x17000035")]
		public bool AllowClassicFlow
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x108059C", Offset = "0x108059C", VA = "0x108059C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x10805DC", Offset = "0x10805DC", VA = "0x10805DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22894", Offset = "0x22894")]
		public bool AllowUnauthenticatedIdentities
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1080690", Offset = "0x1080690", VA = "0x1080690")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x10806D0", Offset = "0x10806D0", VA = "0x10806D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public List<CognitoIdentityProviderInfo> CognitoIdentityProviders
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1080784", Offset = "0x1080784", VA = "0x1080784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x108078C", Offset = "0x108078C", VA = "0x108078C")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x228C8", Offset = "0x228C8")]
		public string DeveloperProviderName
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x10807EC", Offset = "0x10807EC", VA = "0x10807EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x10807F4", Offset = "0x10807F4", VA = "0x10807F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22910", Offset = "0x22910")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x108080C", Offset = "0x108080C", VA = "0x108080C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x1080814", Offset = "0x1080814", VA = "0x1080814")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22960", Offset = "0x22960")]
		public string IdentityPoolName
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x108082C", Offset = "0x108082C", VA = "0x108082C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x1080834", Offset = "0x1080834", VA = "0x1080834")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public Dictionary<string, string> IdentityPoolTags
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x108084C", Offset = "0x108084C", VA = "0x108084C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1080854", Offset = "0x1080854", VA = "0x1080854")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public List<string> OpenIdConnectProviderARNs
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x10808B8", Offset = "0x10808B8", VA = "0x10808B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x10808C0", Offset = "0x10808C0", VA = "0x10808C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public List<string> SamlProviderARNs
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1080920", Offset = "0x1080920", VA = "0x1080920")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x1080928", Offset = "0x1080928", VA = "0x1080928")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x229B0", Offset = "0x229B0")]
		public Dictionary<string, string> SupportedLoginProviders
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1080988", Offset = "0x1080988", VA = "0x1080988")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1080990", Offset = "0x1080990", VA = "0x1080990")]
			set
			{
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1080650", Offset = "0x1080650", VA = "0x1080650")]
		internal bool IsSetAllowClassicFlow()
		{
			return default;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1080744", Offset = "0x1080744", VA = "0x1080744")]
		internal bool IsSetAllowUnauthenticatedIdentities()
		{
			return default;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1080794", Offset = "0x1080794", VA = "0x1080794")]
		internal bool IsSetCognitoIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x10807FC", Offset = "0x10807FC", VA = "0x10807FC")]
		internal bool IsSetDeveloperProviderName()
		{
			return default;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x108081C", Offset = "0x108081C", VA = "0x108081C")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x108083C", Offset = "0x108083C", VA = "0x108083C")]
		internal bool IsSetIdentityPoolName()
		{
			return default;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x108085C", Offset = "0x108085C", VA = "0x108085C")]
		internal bool IsSetIdentityPoolTags()
		{
			return default;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x10808C8", Offset = "0x10808C8", VA = "0x10808C8")]
		internal bool IsSetOpenIdConnectProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1080930", Offset = "0x1080930", VA = "0x1080930")]
		internal bool IsSetSamlProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1080998", Offset = "0x1080998", VA = "0x1080998")]
		internal bool IsSetSupportedLoginProviders()
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x10809F4", Offset = "0x10809F4", VA = "0x10809F4")]
		public DescribeIdentityPoolResponse()
		{
		}
	}
}
