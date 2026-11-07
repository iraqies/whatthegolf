using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007F")]
	public class KMSAccessDeniedExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSAccessDeniedException, JsonUnmarshallerContext>, IUnmarshaller<KMSAccessDeniedException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x0")]
		private static KMSAccessDeniedExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C5")]
		public static KMSAccessDeniedExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x12B5B1C", Offset = "0x12B5B1C", VA = "0x12B5B1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x12B5AB4", Offset = "0x12B5AB4", VA = "0x12B5AB4", Slot = "5")]
		public KMSAccessDeniedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x12B22F0", Offset = "0x12B22F0", VA = "0x12B22F0", Slot = "4")]
		public KMSAccessDeniedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x12B5B80", Offset = "0x12B5B80", VA = "0x12B5B80")]
		public KMSAccessDeniedExceptionUnmarshaller()
		{
		}
	}
}
