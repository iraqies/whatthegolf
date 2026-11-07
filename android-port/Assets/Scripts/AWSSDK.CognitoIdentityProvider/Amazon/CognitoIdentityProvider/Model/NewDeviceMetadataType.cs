using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F3")]
	public class NewDeviceMetadataType
	{
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x10")]
		private string _deviceGroupKey;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x18")]
		private string _deviceKey;

		[Token(Token = "0x170001D0")]
		public string DeviceGroupKey
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x113DD74", Offset = "0x113DD74", VA = "0x113DD74")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x113DD7C", Offset = "0x113DD7C", VA = "0x113DD7C")]
			set
			{
			}
		}

		[Token(Token = "0x170001D1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FA10", Offset = "0x1FA10")]
		public string DeviceKey
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x113DD94", Offset = "0x113DD94", VA = "0x113DD94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x113DD9C", Offset = "0x113DD9C", VA = "0x113DD9C")]
			set
			{
			}
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x113DD84", Offset = "0x113DD84", VA = "0x113DD84")]
		internal bool IsSetDeviceGroupKey()
		{
			return default;
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x113DDA4", Offset = "0x113DDA4", VA = "0x113DDA4")]
		internal bool IsSetDeviceKey()
		{
			return default;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x113DDB4", Offset = "0x113DDB4", VA = "0x113DDB4")]
		public NewDeviceMetadataType()
		{
		}
	}
}
