using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000084")]
	public class KMSThrottlingExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSThrottlingException, JsonUnmarshallerContext>, IUnmarshaller<KMSThrottlingException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x0")]
		private static KMSThrottlingExceptionUnmarshaller _instance;

		[Token(Token = "0x170000CA")]
		public static KMSThrottlingExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x12B6328", Offset = "0x12B6328", VA = "0x12B6328")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x12B62C0", Offset = "0x12B62C0", VA = "0x12B62C0", Slot = "5")]
		public KMSThrottlingException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x12B2764", Offset = "0x12B2764", VA = "0x12B2764", Slot = "4")]
		public KMSThrottlingException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x12B638C", Offset = "0x12B638C", VA = "0x12B638C")]
		public KMSThrottlingExceptionUnmarshaller()
		{
		}
	}
}
