using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000033")]
	public class RegisterDeviceResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x28")]
		private string _deviceId;

		[Token(Token = "0x17000061")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24DD4", Offset = "0x24DD4")]
		public string DeviceId
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x11A65DC", Offset = "0x11A65DC", VA = "0x11A65DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x11A65E4", Offset = "0x11A65E4", VA = "0x11A65E4")]
			set
			{
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x11A65EC", Offset = "0x11A65EC", VA = "0x11A65EC")]
		internal bool IsSetDeviceId()
		{
			return default;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x11A65FC", Offset = "0x11A65FC", VA = "0x11A65FC")]
		public RegisterDeviceResponse()
		{
		}
	}
}
