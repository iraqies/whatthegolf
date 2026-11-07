using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000083")]
	public class KMSOptInRequiredExceptionUnmarshaller : IErrorResponseUnmarshaller<KMSOptInRequiredException, JsonUnmarshallerContext>, IUnmarshaller<KMSOptInRequiredException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x0")]
		private static KMSOptInRequiredExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C9")]
		public static KMSOptInRequiredExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x12B618C", Offset = "0x12B618C", VA = "0x12B618C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x12B6124", Offset = "0x12B6124", VA = "0x12B6124", Slot = "5")]
		public KMSOptInRequiredException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x12B2680", Offset = "0x12B2680", VA = "0x12B2680", Slot = "4")]
		public KMSOptInRequiredException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x12B61F0", Offset = "0x12B61F0", VA = "0x12B61F0")]
		public KMSOptInRequiredExceptionUnmarshaller()
		{
		}
	}
}
