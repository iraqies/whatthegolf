using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000284")]
	public class UserLambdaValidationExceptionUnmarshaller : IErrorResponseUnmarshaller<UserLambdaValidationException, JsonUnmarshallerContext>, IUnmarshaller<UserLambdaValidationException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x0")]
		private static UserLambdaValidationExceptionUnmarshaller _instance;

		[Token(Token = "0x17000406")]
		public static UserLambdaValidationExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x11731C4", Offset = "0x11731C4", VA = "0x11731C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x117315C", Offset = "0x117315C", VA = "0x117315C", Slot = "5")]
		public UserLambdaValidationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x11699EC", Offset = "0x11699EC", VA = "0x11699EC", Slot = "4")]
		public UserLambdaValidationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x1173228", Offset = "0x1173228", VA = "0x1173228")]
		public UserLambdaValidationExceptionUnmarshaller()
		{
		}
	}
}
