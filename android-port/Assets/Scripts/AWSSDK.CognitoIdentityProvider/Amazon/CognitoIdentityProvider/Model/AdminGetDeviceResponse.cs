using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000042")]
	public class AdminGetDeviceResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x28")]
		private DeviceType _device;

		[Token(Token = "0x17000033")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1B53C", Offset = "0x1B53C")]
		public DeviceType Device
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x10A9FF4", Offset = "0x10A9FF4", VA = "0x10A9FF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x10A9FFC", Offset = "0x10A9FFC", VA = "0x10A9FFC")]
			set
			{
			}
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x10AA004", Offset = "0x10AA004", VA = "0x10AA004")]
		internal bool IsSetDevice()
		{
			return default;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x10AA014", Offset = "0x10AA014", VA = "0x10AA014")]
		public AdminGetDeviceResponse()
		{
		}
	}
}
