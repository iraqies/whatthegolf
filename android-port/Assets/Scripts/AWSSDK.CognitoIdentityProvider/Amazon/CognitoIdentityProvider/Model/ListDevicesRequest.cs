using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000DC")]
	public class ListDevicesRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x38")]
		private int? _limit;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x40")]
		private string _paginationToken;

		[Token(Token = "0x1700019A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EE60", Offset = "0x1EE60")]
		public string AccessToken
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x112CD58", Offset = "0x112CD58", VA = "0x112CD58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x112CD60", Offset = "0x112CD60", VA = "0x112CD60")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EE94", Offset = "0x1EE94")]
		public int Limit
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x112CD78", Offset = "0x112CD78", VA = "0x112CD78")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x112CDB8", Offset = "0x112CDB8", VA = "0x112CDB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1EEDC", Offset = "0x1EEDC")]
		public string PaginationToken
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x112CE6C", Offset = "0x112CE6C", VA = "0x112CE6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x112CE74", Offset = "0x112CE74", VA = "0x112CE74")]
			set
			{
			}
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x112CD68", Offset = "0x112CD68", VA = "0x112CD68")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x112CE2C", Offset = "0x112CE2C", VA = "0x112CE2C")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x112CE7C", Offset = "0x112CE7C", VA = "0x112CE7C")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x112CE8C", Offset = "0x112CE8C", VA = "0x112CE8C")]
		public ListDevicesRequest()
		{
		}
	}
}
