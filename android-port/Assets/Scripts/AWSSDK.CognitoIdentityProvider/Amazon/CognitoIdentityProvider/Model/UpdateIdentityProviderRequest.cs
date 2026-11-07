using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000130")]
	public class UpdateIdentityProviderRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, string> _attributeMapping;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _idpIdentifiers;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, string> _providerDetails;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x48")]
		private string _providerName;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x50")]
		private string _userPoolId;

		[Token(Token = "0x17000260")]
		public Dictionary<string, string> AttributeMapping
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1163D5C", Offset = "0x1163D5C", VA = "0x1163D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x1163D64", Offset = "0x1163D64", VA = "0x1163D64")]
			set
			{
			}
		}

		[Token(Token = "0x17000261")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20CE8", Offset = "0x20CE8")]
		public List<string> IdpIdentifiers
		{
			[Token(Token = "0x6000A6E")]
			[Address(RVA = "0x1163DC8", Offset = "0x1163DC8", VA = "0x1163DC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A6F")]
			[Address(RVA = "0x1163DD0", Offset = "0x1163DD0", VA = "0x1163DD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000262")]
		public Dictionary<string, string> ProviderDetails
		{
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1163E30", Offset = "0x1163E30", VA = "0x1163E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1163E38", Offset = "0x1163E38", VA = "0x1163E38")]
			set
			{
			}
		}

		[Token(Token = "0x17000263")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20D30", Offset = "0x20D30")]
		public string ProviderName
		{
			[Token(Token = "0x6000A74")]
			[Address(RVA = "0x1163E9C", Offset = "0x1163E9C", VA = "0x1163E9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A75")]
			[Address(RVA = "0x1163EA4", Offset = "0x1163EA4", VA = "0x1163EA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000264")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20D80", Offset = "0x20D80")]
		public string UserPoolId
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1163EBC", Offset = "0x1163EBC", VA = "0x1163EBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1163EC4", Offset = "0x1163EC4", VA = "0x1163EC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1163D6C", Offset = "0x1163D6C", VA = "0x1163D6C")]
		internal bool IsSetAttributeMapping()
		{
			return default;
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x1163DD8", Offset = "0x1163DD8", VA = "0x1163DD8")]
		internal bool IsSetIdpIdentifiers()
		{
			return default;
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x1163E40", Offset = "0x1163E40", VA = "0x1163E40")]
		internal bool IsSetProviderDetails()
		{
			return default;
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1163EAC", Offset = "0x1163EAC", VA = "0x1163EAC")]
		internal bool IsSetProviderName()
		{
			return default;
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1163ECC", Offset = "0x1163ECC", VA = "0x1163ECC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1163EDC", Offset = "0x1163EDC", VA = "0x1163EDC")]
		public UpdateIdentityProviderRequest()
		{
		}
	}
}
