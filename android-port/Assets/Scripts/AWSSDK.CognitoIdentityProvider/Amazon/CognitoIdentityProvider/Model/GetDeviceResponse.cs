using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000BA")]
	public class GetDeviceResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x28")]
		private DeviceType _device;

		[Token(Token = "0x1700015A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E420", Offset = "0x1E420")]
		public DeviceType Device
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1119C08", Offset = "0x1119C08", VA = "0x1119C08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1119C10", Offset = "0x1119C10", VA = "0x1119C10")]
			set
			{
			}
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1119C18", Offset = "0x1119C18", VA = "0x1119C18")]
		internal bool IsSetDevice()
		{
			return default;
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1119C28", Offset = "0x1119C28", VA = "0x1119C28")]
		public GetDeviceResponse()
		{
		}
	}
}
