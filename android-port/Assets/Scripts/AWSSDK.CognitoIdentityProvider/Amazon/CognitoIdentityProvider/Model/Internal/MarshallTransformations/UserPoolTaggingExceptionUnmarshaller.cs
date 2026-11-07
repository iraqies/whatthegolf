using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000292")]
	public class UserPoolTaggingExceptionUnmarshaller : IErrorResponseUnmarshaller<UserPoolTaggingException, JsonUnmarshallerContext>, IUnmarshaller<UserPoolTaggingException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x0")]
		private static UserPoolTaggingExceptionUnmarshaller _instance;

		[Token(Token = "0x17000411")]
		public static UserPoolTaggingExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600132A")]
			[Address(RVA = "0x1175A90", Offset = "0x1175A90", VA = "0x1175A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001328")]
		[Address(RVA = "0x1175A28", Offset = "0x1175A28", VA = "0x1175A28", Slot = "5")]
		public UserPoolTaggingException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001329")]
		[Address(RVA = "0x1171EC8", Offset = "0x1171EC8", VA = "0x1171EC8", Slot = "4")]
		public UserPoolTaggingException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600132B")]
		[Address(RVA = "0x1175AF4", Offset = "0x1175AF4", VA = "0x1175AF4")]
		public UserPoolTaggingExceptionUnmarshaller()
		{
		}
	}
}
