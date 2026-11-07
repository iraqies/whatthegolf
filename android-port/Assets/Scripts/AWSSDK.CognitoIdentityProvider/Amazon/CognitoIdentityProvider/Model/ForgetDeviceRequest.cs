using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B3")]
	public class ForgetDeviceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x38")]
		private string _deviceKey;

		[Token(Token = "0x1700014C")]
		public string AccessToken
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x111394C", Offset = "0x111394C", VA = "0x111394C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1113954", Offset = "0x1113954", VA = "0x1113954")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E200", Offset = "0x1E200")]
		public string DeviceKey
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x111396C", Offset = "0x111396C", VA = "0x111396C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1113974", Offset = "0x1113974", VA = "0x1113974")]
			set
			{
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x111395C", Offset = "0x111395C", VA = "0x111395C")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x111397C", Offset = "0x111397C", VA = "0x111397C")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x111398C", Offset = "0x111398C", VA = "0x111398C")]
		public ForgetDeviceRequest()
		{
		}
	}
}
