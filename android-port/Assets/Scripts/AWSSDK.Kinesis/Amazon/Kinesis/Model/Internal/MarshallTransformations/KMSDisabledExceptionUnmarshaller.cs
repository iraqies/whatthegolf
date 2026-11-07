using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000080")]
	public class KMSDisabledExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSDisabledException, JsonUnmarshallerContext>, IUnmarshaller<KMSDisabledException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x0")]
		private static KMSDisabledExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C6")]
		public static KMSDisabledExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x12B5CB8", Offset = "0x12B5CB8", VA = "0x12B5CB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x12B5C50", Offset = "0x12B5C50", VA = "0x12B5C50", Slot = "5")]
		public KMSDisabledException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x12B23D4", Offset = "0x12B23D4", VA = "0x12B23D4", Slot = "4")]
		public KMSDisabledException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x12B5D1C", Offset = "0x12B5D1C", VA = "0x12B5D1C")]
		public KMSDisabledExceptionUnmarshaller()
		{
		}
	}
}
