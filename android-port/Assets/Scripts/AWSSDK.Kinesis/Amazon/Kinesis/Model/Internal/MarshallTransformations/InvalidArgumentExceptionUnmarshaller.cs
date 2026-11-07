using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007E")]
	public class InvalidArgumentExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidArgumentException, JsonUnmarshallerContext>, IUnmarshaller<InvalidArgumentException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidArgumentExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C4")]
		public static InvalidArgumentExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x12B5980", Offset = "0x12B5980", VA = "0x12B5980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x12B5918", Offset = "0x12B5918", VA = "0x12B5918", Slot = "5")]
		public InvalidArgumentException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x129B3D0", Offset = "0x129B3D0", VA = "0x129B3D0", Slot = "4")]
		public InvalidArgumentException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x12B59E4", Offset = "0x12B59E4", VA = "0x12B59E4")]
		public InvalidArgumentExceptionUnmarshaller()
		{
		}
	}
}
