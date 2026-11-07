using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000207")]
	public class InternalErrorExceptionUnmarshaller : IErrorResponseUnmarshaller<InternalErrorException, JsonUnmarshallerContext>, IUnmarshaller<InternalErrorException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x0")]
		private static InternalErrorExceptionUnmarshaller _instance;

		[Token(Token = "0x1700039C")]
		public static InternalErrorExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001061")]
			[Address(RVA = "0x112B190", Offset = "0x112B190", VA = "0x112B190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600105F")]
		[Address(RVA = "0x112B128", Offset = "0x112B128", VA = "0x112B128", Slot = "5")]
		public InternalErrorException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001060")]
		[Address(RVA = "0x1114EF8", Offset = "0x1114EF8", VA = "0x1114EF8", Slot = "4")]
		public InternalErrorException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001062")]
		[Address(RVA = "0x112B1F4", Offset = "0x112B1F4", VA = "0x112B1F4")]
		public InternalErrorExceptionUnmarshaller()
		{
		}
	}
}
