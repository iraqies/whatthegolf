using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000081")]
	public class KMSInvalidStateExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSInvalidStateException, JsonUnmarshallerContext>, IUnmarshaller<KMSInvalidStateException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x0")]
		private static KMSInvalidStateExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C7")]
		public static KMSInvalidStateExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x12B5E54", Offset = "0x12B5E54", VA = "0x12B5E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x12B5DEC", Offset = "0x12B5DEC", VA = "0x12B5DEC", Slot = "5")]
		public KMSInvalidStateException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x12B24B8", Offset = "0x12B24B8", VA = "0x12B24B8", Slot = "4")]
		public KMSInvalidStateException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x12B5EB8", Offset = "0x12B5EB8", VA = "0x12B5EB8")]
		public KMSInvalidStateExceptionUnmarshaller()
		{
		}
	}
}
