using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000221")]
	public abstract class EC2ResponseUnmarshaller : XmlResponseUnmarshaller
	{
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x11F849C", Offset = "0x11F849C", VA = "0x11F849C", Slot = "9")]
		public override AmazonWebServiceResponse Unmarshall(UnmarshallerContext input)
		{
			return null;
		}

		[Token(Token = "0x6001050")]
		[Address(RVA = "0x11F85A4", Offset = "0x11F85A4", VA = "0x11F85A4", Slot = "10")]
		protected override UnmarshallerContext ConstructUnmarshallerContext(Stream responseStream, bool maintainResponseBody, IWebResponseData response, bool isException)
		{
			return null;
		}

		[Token(Token = "0x6001051")]
		[Address(RVA = "0x11F8744", Offset = "0x11F8744", VA = "0x11F8744")]
		protected EC2ResponseUnmarshaller()
		{
		}
	}
}
