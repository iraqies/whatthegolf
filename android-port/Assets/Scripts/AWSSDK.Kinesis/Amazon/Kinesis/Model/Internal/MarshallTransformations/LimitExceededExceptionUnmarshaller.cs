using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000085")]
	public class LimitExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<LimitExceededException, JsonUnmarshallerContext>, IUnmarshaller<LimitExceededException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x0")]
		private static LimitExceededExceptionUnmarshaller _instance;

		[Token(Token = "0x170000CB")]
		public static LimitExceededExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x12B64C4", Offset = "0x12B64C4", VA = "0x12B64C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x12B645C", Offset = "0x12B645C", VA = "0x12B645C", Slot = "5")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x129B4B4", Offset = "0x129B4B4", VA = "0x129B4B4", Slot = "4")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x12B6528", Offset = "0x12B6528", VA = "0x12B6528")]
		public LimitExceededExceptionUnmarshaller()
		{
		}
	}
}
