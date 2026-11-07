using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000287")]
	public class UsernameExistsExceptionUnmarshaller : IErrorResponseUnmarshaller<UsernameExistsException, JsonUnmarshallerContext>, IUnmarshaller<UsernameExistsException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x0")]
		private static UsernameExistsExceptionUnmarshaller _instance;

		[Token(Token = "0x17000408")]
		public static UsernameExistsExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60012F7")]
			[Address(RVA = "0x1179C60", Offset = "0x1179C60", VA = "0x1179C60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x1179B14", Offset = "0x1179B14", VA = "0x1179B14", Slot = "5")]
		public UsernameExistsException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60012F6")]
		[Address(RVA = "0x1179B7C", Offset = "0x1179B7C", VA = "0x1179B7C", Slot = "4")]
		public UsernameExistsException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x1179CC4", Offset = "0x1179CC4", VA = "0x1179CC4")]
		public UsernameExistsExceptionUnmarshaller()
		{
		}
	}
}
