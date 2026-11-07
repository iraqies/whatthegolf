using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B9")]
	public class GetDeviceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x38")]
		private string _deviceKey;

		[Token(Token = "0x17000158")]
		public string AccessToken
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x11190EC", Offset = "0x11190EC", VA = "0x11190EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x11190F4", Offset = "0x11190F4", VA = "0x11190F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E3D0", Offset = "0x1E3D0")]
		public string DeviceKey
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x111910C", Offset = "0x111910C", VA = "0x111910C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x1119114", Offset = "0x1119114", VA = "0x1119114")]
			set
			{
			}
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x11190FC", Offset = "0x11190FC", VA = "0x11190FC")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x111911C", Offset = "0x111911C", VA = "0x111911C")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x111912C", Offset = "0x111912C", VA = "0x111912C")]
		public GetDeviceRequest()
		{
		}
	}
}
