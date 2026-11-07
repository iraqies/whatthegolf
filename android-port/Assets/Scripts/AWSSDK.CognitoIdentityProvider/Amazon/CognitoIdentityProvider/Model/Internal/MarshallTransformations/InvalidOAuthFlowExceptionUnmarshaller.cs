using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200020A")]
	public class InvalidOAuthFlowExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidOAuthFlowException, JsonUnmarshallerContext>, IUnmarshaller<InvalidOAuthFlowException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidOAuthFlowExceptionUnmarshaller _instance;

		[Token(Token = "0x1700039F")]
		public static InvalidOAuthFlowExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001070")]
			[Address(RVA = "0x112B688", Offset = "0x112B688", VA = "0x112B688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600106E")]
		[Address(RVA = "0x112B53C", Offset = "0x112B53C", VA = "0x112B53C", Slot = "5")]
		public InvalidOAuthFlowException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600106F")]
		[Address(RVA = "0x112B5A4", Offset = "0x112B5A4", VA = "0x112B5A4", Slot = "4")]
		public InvalidOAuthFlowException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001071")]
		[Address(RVA = "0x112B6EC", Offset = "0x112B6EC", VA = "0x112B6EC")]
		public InvalidOAuthFlowExceptionUnmarshaller()
		{
		}
	}
}
