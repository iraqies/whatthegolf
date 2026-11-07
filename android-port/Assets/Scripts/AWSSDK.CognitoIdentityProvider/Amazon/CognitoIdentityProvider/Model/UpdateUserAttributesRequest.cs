using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000134")]
	public class UpdateUserAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _clientMetadata;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x40")]
		private List<AttributeType> _userAttributes;

		[Token(Token = "0x1700026B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20F60", Offset = "0x20F60")]
		public string AccessToken
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1167440", Offset = "0x1167440", VA = "0x1167440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1167448", Offset = "0x1167448", VA = "0x1167448")]
			set
			{
			}
		}

		[Token(Token = "0x1700026C")]
		public Dictionary<string, string> ClientMetadata
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x1167460", Offset = "0x1167460", VA = "0x1167460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1167468", Offset = "0x1167468", VA = "0x1167468")]
			set
			{
			}
		}

		[Token(Token = "0x1700026D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20F94", Offset = "0x20F94")]
		public List<AttributeType> UserAttributes
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x11674CC", Offset = "0x11674CC", VA = "0x11674CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x11674D4", Offset = "0x11674D4", VA = "0x11674D4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x1167450", Offset = "0x1167450", VA = "0x1167450")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x1167470", Offset = "0x1167470", VA = "0x1167470")]
		internal bool IsSetClientMetadata()
		{
			return default;
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x11674DC", Offset = "0x11674DC", VA = "0x11674DC")]
		internal bool IsSetUserAttributes()
		{
			return default;
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x1167534", Offset = "0x1167534", VA = "0x1167534", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x116758C", Offset = "0x116758C", VA = "0x116758C")]
		public UpdateUserAttributesRequest()
		{
		}
	}
}
