using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000288")]
	public class UserNotConfirmedExceptionUnmarshaller : IErrorResponseUnmarshaller<UserNotConfirmedException, JsonUnmarshallerContext>, IUnmarshaller<UserNotConfirmedException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x0")]
		private static UserNotConfirmedExceptionUnmarshaller _instance;

		[Token(Token = "0x17000409")]
		public static UserNotConfirmedExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60012FC")]
			[Address(RVA = "0x1173320", Offset = "0x1173320", VA = "0x1173320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x11732B8", Offset = "0x11732B8", VA = "0x11732B8", Slot = "5")]
		public UserNotConfirmedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x1162380", Offset = "0x1162380", VA = "0x1162380", Slot = "4")]
		public UserNotConfirmedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60012FD")]
		[Address(RVA = "0x1173384", Offset = "0x1173384", VA = "0x1173384")]
		public UserNotConfirmedExceptionUnmarshaller()
		{
		}
	}
}
