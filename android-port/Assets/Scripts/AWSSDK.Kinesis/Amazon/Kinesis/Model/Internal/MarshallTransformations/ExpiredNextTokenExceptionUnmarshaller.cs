using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000076")]
	public class ExpiredNextTokenExceptionUnmarshaller : IErrorResponseUnmarshaller<ExpiredNextTokenException, JsonUnmarshallerContext>, IUnmarshaller<ExpiredNextTokenException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x0")]
		private static ExpiredNextTokenExceptionUnmarshaller _instance;

		[Token(Token = "0x170000BC")]
		public static ExpiredNextTokenExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x12B04D4", Offset = "0x12B04D4", VA = "0x12B04D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x12B0388", Offset = "0x12B0388", VA = "0x12B0388", Slot = "5")]
		public ExpiredNextTokenException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x12B03F0", Offset = "0x12B03F0", VA = "0x12B03F0", Slot = "4")]
		public ExpiredNextTokenException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x12B0538", Offset = "0x12B0538", VA = "0x12B0538")]
		public ExpiredNextTokenExceptionUnmarshaller()
		{
		}
	}
}
