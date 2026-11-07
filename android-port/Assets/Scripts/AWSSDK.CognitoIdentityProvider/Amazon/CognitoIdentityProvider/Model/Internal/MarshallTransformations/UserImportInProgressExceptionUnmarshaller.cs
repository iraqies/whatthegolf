using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000282")]
	public class UserImportInProgressExceptionUnmarshaller : IErrorResponseUnmarshaller<UserImportInProgressException, JsonUnmarshallerContext>, IUnmarshaller<UserImportInProgressException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x0")]
		private static UserImportInProgressExceptionUnmarshaller _instance;

		[Token(Token = "0x17000404")]
		public static UserImportInProgressExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60012E0")]
			[Address(RVA = "0x1172294", Offset = "0x1172294", VA = "0x1172294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x117222C", Offset = "0x117222C", VA = "0x117222C", Slot = "5")]
		public UserImportInProgressException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x1171DE4", Offset = "0x1171DE4", VA = "0x1171DE4", Slot = "4")]
		public UserImportInProgressException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60012E1")]
		[Address(RVA = "0x11722F8", Offset = "0x11722F8", VA = "0x11722F8")]
		public UserImportInProgressExceptionUnmarshaller()
		{
		}
	}
}
