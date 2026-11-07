using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000236")]
	public class PasswordResetRequiredExceptionUnmarshaller : IErrorResponseUnmarshaller<PasswordResetRequiredException, JsonUnmarshallerContext>, IUnmarshaller<PasswordResetRequiredException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x0")]
		private static PasswordResetRequiredExceptionUnmarshaller _instance;

		[Token(Token = "0x170003C4")]
		public static PasswordResetRequiredExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001152")]
			[Address(RVA = "0x1140D6C", Offset = "0x1140D6C", VA = "0x1140D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001150")]
		[Address(RVA = "0x1140C20", Offset = "0x1140C20", VA = "0x1140C20", Slot = "5")]
		public PasswordResetRequiredException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001151")]
		[Address(RVA = "0x1140C88", Offset = "0x1140C88", VA = "0x1140C88", Slot = "4")]
		public PasswordResetRequiredException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001153")]
		[Address(RVA = "0x1140DD0", Offset = "0x1140DD0", VA = "0x1140DD0")]
		public PasswordResetRequiredExceptionUnmarshaller()
		{
		}
	}
}
