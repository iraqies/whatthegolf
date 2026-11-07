using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000289")]
	public class UserNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<UserNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<UserNotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x0")]
		private static UserNotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x1700040A")]
		public static UserNotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001301")]
			[Address(RVA = "0x117347C", Offset = "0x117347C", VA = "0x117347C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012FF")]
		[Address(RVA = "0x1173414", Offset = "0x1173414", VA = "0x1173414", Slot = "5")]
		public UserNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001300")]
		[Address(RVA = "0x1160954", Offset = "0x1160954", VA = "0x1160954", Slot = "4")]
		public UserNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001302")]
		[Address(RVA = "0x11734E0", Offset = "0x11734E0", VA = "0x11734E0")]
		public UserNotFoundExceptionUnmarshaller()
		{
		}
	}
}
