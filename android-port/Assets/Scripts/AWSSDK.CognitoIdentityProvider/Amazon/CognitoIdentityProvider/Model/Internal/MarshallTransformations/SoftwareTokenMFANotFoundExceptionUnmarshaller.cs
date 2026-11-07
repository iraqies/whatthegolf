using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200025D")]
	public class SoftwareTokenMFANotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<SoftwareTokenMFANotFoundException, JsonUnmarshallerContext>, IUnmarshaller<SoftwareTokenMFANotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x0")]
		private static SoftwareTokenMFANotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x170003E2")]
		public static SoftwareTokenMFANotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001213")]
			[Address(RVA = "0x1156D6C", Offset = "0x1156D6C", VA = "0x1156D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001211")]
		[Address(RVA = "0x1156D04", Offset = "0x1156D04", VA = "0x1156D04", Slot = "5")]
		public SoftwareTokenMFANotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001212")]
		[Address(RVA = "0x1148658", Offset = "0x1148658", VA = "0x1148658", Slot = "4")]
		public SoftwareTokenMFANotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001214")]
		[Address(RVA = "0x1156DD0", Offset = "0x1156DD0", VA = "0x1156DD0")]
		public SoftwareTokenMFANotFoundExceptionUnmarshaller()
		{
		}
	}
}
