using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000065")]
	public class NotAuthorizedExceptionUnmarshaller : IErrorResponseUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>, IUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x0")]
		private static NotAuthorizedExceptionUnmarshaller _instance;

		[Token(Token = "0x1700009D")]
		public static NotAuthorizedExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x11A3BFC", Offset = "0x11A3BFC", VA = "0x11A3BFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x11A3B94", Offset = "0x11A3B94", VA = "0x11A3B94", Slot = "5")]
		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1191B28", Offset = "0x1191B28", VA = "0x1191B28", Slot = "4")]
		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11A3C60", Offset = "0x11A3C60", VA = "0x11A3C60")]
		public NotAuthorizedExceptionUnmarshaller()
		{
		}
	}
}
