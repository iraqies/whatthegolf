using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200020C")]
	public class InvalidPasswordExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidPasswordException, JsonUnmarshallerContext>, IUnmarshaller<InvalidPasswordException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidPasswordExceptionUnmarshaller _instance;

		[Token(Token = "0x170003A1")]
		public static InvalidPasswordExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600107A")]
			[Address(RVA = "0x112BA24", Offset = "0x112BA24", VA = "0x112BA24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001078")]
		[Address(RVA = "0x112B8D8", Offset = "0x112B8D8", VA = "0x112B8D8", Slot = "5")]
		public InvalidPasswordException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001079")]
		[Address(RVA = "0x112B940", Offset = "0x112B940", VA = "0x112B940", Slot = "4")]
		public InvalidPasswordException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600107B")]
		[Address(RVA = "0x112BA88", Offset = "0x112BA88", VA = "0x112BA88")]
		public InvalidPasswordExceptionUnmarshaller()
		{
		}
	}
}
