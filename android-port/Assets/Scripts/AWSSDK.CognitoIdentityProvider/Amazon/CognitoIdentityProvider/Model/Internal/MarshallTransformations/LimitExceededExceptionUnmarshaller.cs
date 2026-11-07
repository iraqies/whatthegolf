using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000212")]
	public class LimitExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<LimitExceededException, JsonUnmarshallerContext>, IUnmarshaller<LimitExceededException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x0")]
		private static LimitExceededExceptionUnmarshaller _instance;

		[Token(Token = "0x170003A6")]
		public static LimitExceededExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001096")]
			[Address(RVA = "0x112CC8C", Offset = "0x112CC8C", VA = "0x112CC8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001094")]
		[Address(RVA = "0x112CC24", Offset = "0x112CC24", VA = "0x112CC24", Slot = "5")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001095")]
		[Address(RVA = "0x1117820", Offset = "0x1117820", VA = "0x1117820", Slot = "4")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0x112CCF0", Offset = "0x112CCF0", VA = "0x112CCF0")]
		public LimitExceededExceptionUnmarshaller()
		{
		}
	}
}
