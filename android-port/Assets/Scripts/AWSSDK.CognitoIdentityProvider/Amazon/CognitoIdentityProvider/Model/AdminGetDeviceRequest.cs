using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000041")]
	public class AdminGetDeviceRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x30")]
		private string _deviceKey;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x38")]
		private string _username;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x40")]
		private string _userPoolId;

		[Token(Token = "0x17000030")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B44C", Offset = "0x1B44C")]
		public string DeviceKey
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x10A944C", Offset = "0x10A944C", VA = "0x10A944C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x10A9454", Offset = "0x10A9454", VA = "0x10A9454")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B49C", Offset = "0x1B49C")]
		public string Username
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x10A946C", Offset = "0x10A946C", VA = "0x10A946C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x10A9474", Offset = "0x10A9474", VA = "0x10A9474")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B4EC", Offset = "0x1B4EC")]
		public string UserPoolId
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x10A948C", Offset = "0x10A948C", VA = "0x10A948C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x10A9494", Offset = "0x10A9494", VA = "0x10A9494")]
			set
			{
			}
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x10A945C", Offset = "0x10A945C", VA = "0x10A945C")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x10A947C", Offset = "0x10A947C", VA = "0x10A947C")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x10A949C", Offset = "0x10A949C", VA = "0x10A949C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x10A94AC", Offset = "0x10A94AC", VA = "0x10A94AC")]
		public AdminGetDeviceRequest()
		{
		}
	}
}
