using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000076")]
	public class LimitExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<LimitExceededException, JsonUnmarshallerContext>, IUnmarshaller<LimitExceededException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		private static LimitExceededExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C5")]
		public static LimitExceededExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x108D850", Offset = "0x108D850", VA = "0x108D850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x108D7E8", Offset = "0x108D7E8", VA = "0x108D7E8", Slot = "5")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x107C5E8", Offset = "0x107C5E8", VA = "0x107C5E8", Slot = "4")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x108D8B4", Offset = "0x108D8B4", VA = "0x108D8B4")]
		public LimitExceededExceptionUnmarshaller()
		{
		}
	}
}
