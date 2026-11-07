using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000059")]
	public class ConcurrentModificationExceptionUnmarshaller : IErrorResponseUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>, IUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x0")]
		private static ConcurrentModificationExceptionUnmarshaller _instance;

		[Token(Token = "0x170000A8")]
		public static ConcurrentModificationExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x1078EB4", Offset = "0x1078EB4", VA = "0x1078EB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1078D68", Offset = "0x1078D68", VA = "0x1078D68", Slot = "5")]
		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1078DD0", Offset = "0x1078DD0", VA = "0x1078DD0", Slot = "4")]
		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1078F18", Offset = "0x1078F18", VA = "0x1078F18")]
		public ConcurrentModificationExceptionUnmarshaller()
		{
		}
	}
}
