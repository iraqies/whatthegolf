using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000075")]
	public class ExpiredIteratorExceptionUnmarshaller : IErrorResponseUnmarshaller<ExpiredIteratorException, JsonUnmarshallerContext>, IUnmarshaller<ExpiredIteratorException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x0")]
		private static ExpiredIteratorExceptionUnmarshaller _instance;

		[Token(Token = "0x170000BB")]
		public static ExpiredIteratorExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x12B0254", Offset = "0x12B0254", VA = "0x12B0254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x12B0108", Offset = "0x12B0108", VA = "0x12B0108", Slot = "5")]
		public ExpiredIteratorException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x12B0170", Offset = "0x12B0170", VA = "0x12B0170", Slot = "4")]
		public ExpiredIteratorException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x12B02B8", Offset = "0x12B02B8", VA = "0x12B02B8")]
		public ExpiredIteratorExceptionUnmarshaller()
		{
		}
	}
}
