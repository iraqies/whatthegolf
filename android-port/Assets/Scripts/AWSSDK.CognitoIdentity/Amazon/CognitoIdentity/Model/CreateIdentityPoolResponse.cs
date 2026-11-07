using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200001E")]
	public class CreateIdentityPoolResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x24")]
		private bool? _allowClassicFlow;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x26")]
		private bool? _allowUnauthenticatedIdentities;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x28")]
		private List<CognitoIdentityProviderInfo> _cognitoIdentityProviders;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x30")]
		private string _developerProviderName;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolName;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, string> _identityPoolTags;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _openIdConnectProviderARNs;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x58")]
		private List<string> _samlProviderARNs;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, string> _supportedLoginProviders;

		[Token(Token = "0x17000027")]
		public bool AllowClassicFlow
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x107AB70", Offset = "0x107AB70", VA = "0x107AB70")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x107ABB0", Offset = "0x107ABB0", VA = "0x107ABB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22618", Offset = "0x22618")]
		public bool AllowUnauthenticatedIdentities
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x107AC64", Offset = "0x107AC64", VA = "0x107AC64")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x107ACA4", Offset = "0x107ACA4", VA = "0x107ACA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public List<CognitoIdentityProviderInfo> CognitoIdentityProviders
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x107AD58", Offset = "0x107AD58", VA = "0x107AD58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x107AD60", Offset = "0x107AD60", VA = "0x107AD60")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2264C", Offset = "0x2264C")]
		public string DeveloperProviderName
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x107ADC0", Offset = "0x107ADC0", VA = "0x107ADC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x107ADC8", Offset = "0x107ADC8", VA = "0x107ADC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22694", Offset = "0x22694")]
		public string IdentityPoolId
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x107ADE0", Offset = "0x107ADE0", VA = "0x107ADE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x107ADE8", Offset = "0x107ADE8", VA = "0x107ADE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x226E4", Offset = "0x226E4")]
		public string IdentityPoolName
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x107AE00", Offset = "0x107AE00", VA = "0x107AE00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x107AE08", Offset = "0x107AE08", VA = "0x107AE08")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public Dictionary<string, string> IdentityPoolTags
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x107AE20", Offset = "0x107AE20", VA = "0x107AE20")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x107AE28", Offset = "0x107AE28", VA = "0x107AE28")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public List<string> OpenIdConnectProviderARNs
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x107AE8C", Offset = "0x107AE8C", VA = "0x107AE8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x107AE94", Offset = "0x107AE94", VA = "0x107AE94")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public List<string> SamlProviderARNs
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x107AEF4", Offset = "0x107AEF4", VA = "0x107AEF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x107AEFC", Offset = "0x107AEFC", VA = "0x107AEFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22734", Offset = "0x22734")]
		public Dictionary<string, string> SupportedLoginProviders
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x107AF5C", Offset = "0x107AF5C", VA = "0x107AF5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x107AF64", Offset = "0x107AF64", VA = "0x107AF64")]
			set
			{
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x107AC24", Offset = "0x107AC24", VA = "0x107AC24")]
		internal bool IsSetAllowClassicFlow()
		{
			return default;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x107AD18", Offset = "0x107AD18", VA = "0x107AD18")]
		internal bool IsSetAllowUnauthenticatedIdentities()
		{
			return default;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x107AD68", Offset = "0x107AD68", VA = "0x107AD68")]
		internal bool IsSetCognitoIdentityProviders()
		{
			return default;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x107ADD0", Offset = "0x107ADD0", VA = "0x107ADD0")]
		internal bool IsSetDeveloperProviderName()
		{
			return default;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x107ADF0", Offset = "0x107ADF0", VA = "0x107ADF0")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x107AE10", Offset = "0x107AE10", VA = "0x107AE10")]
		internal bool IsSetIdentityPoolName()
		{
			return default;
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x107AE30", Offset = "0x107AE30", VA = "0x107AE30")]
		internal bool IsSetIdentityPoolTags()
		{
			return default;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x107AE9C", Offset = "0x107AE9C", VA = "0x107AE9C")]
		internal bool IsSetOpenIdConnectProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x107AF04", Offset = "0x107AF04", VA = "0x107AF04")]
		internal bool IsSetSamlProviderARNs()
		{
			return default;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x107AF6C", Offset = "0x107AF6C", VA = "0x107AF6C")]
		internal bool IsSetSupportedLoginProviders()
		{
			return default;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x107AFC8", Offset = "0x107AFC8", VA = "0x107AFC8")]
		public CreateIdentityPoolResponse()
		{
		}
	}
}
