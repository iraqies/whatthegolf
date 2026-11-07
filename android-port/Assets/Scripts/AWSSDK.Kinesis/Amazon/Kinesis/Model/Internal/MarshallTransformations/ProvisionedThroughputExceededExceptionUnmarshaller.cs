using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000090")]
	public class ProvisionedThroughputExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<ProvisionedThroughputExceededException, JsonUnmarshallerContext>, IUnmarshaller<ProvisionedThroughputExceededException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x0")]
		private static ProvisionedThroughputExceededExceptionUnmarshaller _instance;

		[Token(Token = "0x170000D6")]
		public static ProvisionedThroughputExceededExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x12BE4C0", Offset = "0x12BE4C0", VA = "0x12BE4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x12BE458", Offset = "0x12BE458", VA = "0x12BE458", Slot = "5")]
		public ProvisionedThroughputExceededException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x12B2848", Offset = "0x12B2848", VA = "0x12B2848", Slot = "4")]
		public ProvisionedThroughputExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x12BE524", Offset = "0x12BE524", VA = "0x12BE524")]
		public ProvisionedThroughputExceededExceptionUnmarshaller()
		{
		}
	}
}
