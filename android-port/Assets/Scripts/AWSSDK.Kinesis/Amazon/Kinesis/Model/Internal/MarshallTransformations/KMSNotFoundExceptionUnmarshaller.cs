using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000082")]
	public class KMSNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<KMSNotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x0")]
		private static KMSNotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C8")]
		public static KMSNotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x12B5FF0", Offset = "0x12B5FF0", VA = "0x12B5FF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x12B5F88", Offset = "0x12B5F88", VA = "0x12B5F88", Slot = "5")]
		public KMSNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x12B259C", Offset = "0x12B259C", VA = "0x12B259C", Slot = "4")]
		public KMSNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x12B6054", Offset = "0x12B6054", VA = "0x12B6054")]
		public KMSNotFoundExceptionUnmarshaller()
		{
		}
	}
}
