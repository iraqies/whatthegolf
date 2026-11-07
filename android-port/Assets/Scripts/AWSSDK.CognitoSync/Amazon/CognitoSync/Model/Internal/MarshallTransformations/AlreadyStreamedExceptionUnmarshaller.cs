using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000041")]
	public class AlreadyStreamedExceptionUnmarshaller : IErrorResponseUnmarshaller<AlreadyStreamedException, JsonUnmarshallerContext>, IUnmarshaller<AlreadyStreamedException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x0")]
		private static AlreadyStreamedExceptionUnmarshaller _instance;

		[Token(Token = "0x1700007A")]
		public static AlreadyStreamedExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x118C4C8", Offset = "0x118C4C8", VA = "0x118C4C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x118C37C", Offset = "0x118C37C", VA = "0x118C37C", Slot = "5")]
		public AlreadyStreamedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x118C3E4", Offset = "0x118C3E4", VA = "0x118C3E4", Slot = "4")]
		public AlreadyStreamedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x118C52C", Offset = "0x118C52C", VA = "0x118C52C")]
		public AlreadyStreamedExceptionUnmarshaller()
		{
		}
	}
}
