using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000049")]
	public class AdminListDevicesRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x2C")]
		private int? _limit;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x38")]
		private string _paginationToken;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x1700004D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B818", Offset = "0x1B818")]
		public int Limit
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x10B10F0", Offset = "0x10B10F0", VA = "0x10B10F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x10B1130", Offset = "0x10B1130", VA = "0x10B1130")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B860", Offset = "0x1B860")]
		public string PaginationToken
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x10B11E4", Offset = "0x10B11E4", VA = "0x10B11E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x10B11EC", Offset = "0x10B11EC", VA = "0x10B11EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B898", Offset = "0x1B898")]
		public string Username
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x10B1204", Offset = "0x10B1204", VA = "0x10B1204")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x10B120C", Offset = "0x10B120C", VA = "0x10B120C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B8E8", Offset = "0x1B8E8")]
		public string UserPoolId
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x10B1224", Offset = "0x10B1224", VA = "0x10B1224")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x10B122C", Offset = "0x10B122C", VA = "0x10B122C")]
			set
			{
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x10B11A4", Offset = "0x10B11A4", VA = "0x10B11A4")]
		internal bool IsSetLimit()
		{
			return default;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x10B11F4", Offset = "0x10B11F4", VA = "0x10B11F4")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x10B1214", Offset = "0x10B1214", VA = "0x10B1214")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x10B1234", Offset = "0x10B1234", VA = "0x10B1234")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x10B1244", Offset = "0x10B1244", VA = "0x10B1244")]
		public AdminListDevicesRequest()
		{
		}
	}
}
