using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000267")]
	public class TooManyFailedAttemptsExceptionUnmarshaller : IErrorResponseUnmarshaller<TooManyFailedAttemptsException, JsonUnmarshallerContext>, IUnmarshaller<TooManyFailedAttemptsException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x0")]
		private static TooManyFailedAttemptsExceptionUnmarshaller _instance;

		[Token(Token = "0x170003EA")]
		public static TooManyFailedAttemptsExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001247")]
			[Address(RVA = "0x115CA20", Offset = "0x115CA20", VA = "0x115CA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001245")]
		[Address(RVA = "0x115C8D4", Offset = "0x115C8D4", VA = "0x115C8D4", Slot = "5")]
		public TooManyFailedAttemptsException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001246")]
		[Address(RVA = "0x115C93C", Offset = "0x115C93C", VA = "0x115C93C", Slot = "4")]
		public TooManyFailedAttemptsException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001248")]
		[Address(RVA = "0x115CA84", Offset = "0x115CA84", VA = "0x115CA84")]
		public TooManyFailedAttemptsExceptionUnmarshaller()
		{
		}
	}
}
