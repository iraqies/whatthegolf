using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200003F")]
	public class AdminForgetDeviceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x30")]
		private string _deviceKey;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x1700002D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B35C", Offset = "0x1B35C")]
		public string DeviceKey
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x10A7E70", Offset = "0x10A7E70", VA = "0x10A7E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x10A7E78", Offset = "0x10A7E78", VA = "0x10A7E78")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B3AC", Offset = "0x1B3AC")]
		public string Username
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x10A7E90", Offset = "0x10A7E90", VA = "0x10A7E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x10A7E98", Offset = "0x10A7E98", VA = "0x10A7E98")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B3FC", Offset = "0x1B3FC")]
		public string UserPoolId
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x10A7EB0", Offset = "0x10A7EB0", VA = "0x10A7EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x10A7EB8", Offset = "0x10A7EB8", VA = "0x10A7EB8")]
			set
			{
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10A7E80", Offset = "0x10A7E80", VA = "0x10A7E80")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x10A7EA0", Offset = "0x10A7EA0", VA = "0x10A7EA0")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x10A7EC0", Offset = "0x10A7EC0", VA = "0x10A7EC0")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x10A7ED0", Offset = "0x10A7ED0", VA = "0x10A7ED0")]
		public AdminForgetDeviceRequest()
		{
		}
	}
}
