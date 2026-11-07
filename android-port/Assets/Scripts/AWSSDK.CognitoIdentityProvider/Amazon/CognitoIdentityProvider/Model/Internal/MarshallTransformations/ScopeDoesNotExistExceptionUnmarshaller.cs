using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000249")]
	public class ScopeDoesNotExistExceptionUnmarshaller : IErrorResponseUnmarshaller<ScopeDoesNotExistException, JsonUnmarshallerContext>, IUnmarshaller<ScopeDoesNotExistException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x0")]
		private static ScopeDoesNotExistExceptionUnmarshaller _instance;

		[Token(Token = "0x170003D2")]
		public static ScopeDoesNotExistExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60011AB")]
			[Address(RVA = "0x114B67C", Offset = "0x114B67C", VA = "0x114B67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x114B530", Offset = "0x114B530", VA = "0x114B530", Slot = "5")]
		public ScopeDoesNotExistException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x114B598", Offset = "0x114B598", VA = "0x114B598", Slot = "4")]
		public ScopeDoesNotExistException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x114B6E0", Offset = "0x114B6E0", VA = "0x114B6E0")]
		public ScopeDoesNotExistExceptionUnmarshaller()
		{
		}
	}
}
