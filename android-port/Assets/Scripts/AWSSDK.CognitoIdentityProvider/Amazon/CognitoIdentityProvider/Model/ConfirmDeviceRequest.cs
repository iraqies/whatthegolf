using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000074")]
	public class ConfirmDeviceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x38")]
		private string _deviceKey;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x40")]
		private string _deviceName;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x48")]
		private DeviceSecretVerifierConfigType _deviceSecretVerifierConfig;

		[Token(Token = "0x170000AE")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C88C", Offset = "0x1C88C")]
		public string AccessToken
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x10E4BC4", Offset = "0x10E4BC4", VA = "0x10E4BC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x10E4BCC", Offset = "0x10E4BCC", VA = "0x10E4BCC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C8C0", Offset = "0x1C8C0")]
		public string DeviceKey
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x10E4BE4", Offset = "0x10E4BE4", VA = "0x10E4BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x10E4BEC", Offset = "0x10E4BEC", VA = "0x10E4BEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C910", Offset = "0x1C910")]
		public string DeviceName
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x10E4C04", Offset = "0x10E4C04", VA = "0x10E4C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x10E4C0C", Offset = "0x10E4C0C", VA = "0x10E4C0C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public DeviceSecretVerifierConfigType DeviceSecretVerifierConfig
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x10E4C24", Offset = "0x10E4C24", VA = "0x10E4C24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x10E4C2C", Offset = "0x10E4C2C", VA = "0x10E4C2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x10E4BD4", Offset = "0x10E4BD4", VA = "0x10E4BD4")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x10E4BF4", Offset = "0x10E4BF4", VA = "0x10E4BF4")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x10E4C14", Offset = "0x10E4C14", VA = "0x10E4C14")]
		internal bool IsSetDeviceName()
		{
			return default;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x10E4C34", Offset = "0x10E4C34", VA = "0x10E4C34")]
		internal bool IsSetDeviceSecretVerifierConfig()
		{
			return default;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x10E4C44", Offset = "0x10E4C44", VA = "0x10E4C44")]
		public ConfirmDeviceRequest()
		{
		}
	}
}
