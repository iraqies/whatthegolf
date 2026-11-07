using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200012C")]
	public class UpdateDeviceStatusRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x38")]
		private string _deviceKey;

		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x40")]
		private DeviceRememberedStatusType _deviceRememberedStatus;

		[Token(Token = "0x17000257")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20B0C", Offset = "0x20B0C")]
		public string AccessToken
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x1160C4C", Offset = "0x1160C4C", VA = "0x1160C4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x1160C54", Offset = "0x1160C54", VA = "0x1160C54")]
			set
			{
			}
		}

		[Token(Token = "0x17000258")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20B40", Offset = "0x20B40")]
		public string DeviceKey
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x1160C6C", Offset = "0x1160C6C", VA = "0x1160C6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x1160C74", Offset = "0x1160C74", VA = "0x1160C74")]
			set
			{
			}
		}

		[Token(Token = "0x17000259")]
		public DeviceRememberedStatusType DeviceRememberedStatus
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1160C8C", Offset = "0x1160C8C", VA = "0x1160C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1160C94", Offset = "0x1160C94", VA = "0x1160C94")]
			set
			{
			}
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x1160C5C", Offset = "0x1160C5C", VA = "0x1160C5C")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x1160C7C", Offset = "0x1160C7C", VA = "0x1160C7C")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x1160C9C", Offset = "0x1160C9C", VA = "0x1160C9C")]
		internal bool IsSetDeviceRememberedStatus()
		{
			return default;
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x1160D18", Offset = "0x1160D18", VA = "0x1160D18")]
		public UpdateDeviceStatusRequest()
		{
		}
	}
}
