using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000074")]
	public class TooManyRequestsExceptionUnmarshaller : IErrorResponseUnmarshaller<TooManyRequestsException, JsonUnmarshallerContext>, IUnmarshaller<TooManyRequestsException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x0")]
		private static TooManyRequestsExceptionUnmarshaller _instance;

		[Token(Token = "0x170000AA")]
		public static TooManyRequestsExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x11AB8CC", Offset = "0x11AB8CC", VA = "0x11AB8CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x11AB864", Offset = "0x11AB864", VA = "0x11AB864", Slot = "5")]
		public TooManyRequestsException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1194E34", Offset = "0x1194E34", VA = "0x1194E34", Slot = "4")]
		public TooManyRequestsException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x11AB930", Offset = "0x11AB930", VA = "0x11AB930")]
		public TooManyRequestsExceptionUnmarshaller()
		{
		}
	}
}
