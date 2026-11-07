using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000048")]
	public class InvalidAuthorizationMessageExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidAuthorizationMessageException, XmlUnmarshallerContext>, IUnmarshaller<InvalidAuthorizationMessageException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidAuthorizationMessageExceptionUnmarshaller _instance;

		[Token(Token = "0x17000069")]
		public static InvalidAuthorizationMessageExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x12E3E18", Offset = "0x12E3E18", VA = "0x12E3E18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x12E3DB0", Offset = "0x12E3DB0", VA = "0x12E3DB0", Slot = "5")]
		public InvalidAuthorizationMessageException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x12DE24C", Offset = "0x12DE24C", VA = "0x12DE24C", Slot = "4")]
		public InvalidAuthorizationMessageException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x12E3E7C", Offset = "0x12E3E7C", VA = "0x12E3E7C")]
		public InvalidAuthorizationMessageExceptionUnmarshaller()
		{
		}
	}
}
