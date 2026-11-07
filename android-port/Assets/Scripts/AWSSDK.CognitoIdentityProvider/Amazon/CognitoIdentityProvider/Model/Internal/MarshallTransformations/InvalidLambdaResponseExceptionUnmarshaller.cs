using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000209")]
	public class InvalidLambdaResponseExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidLambdaResponseException, JsonUnmarshallerContext>, IUnmarshaller<InvalidLambdaResponseException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidLambdaResponseExceptionUnmarshaller _instance;

		[Token(Token = "0x1700039E")]
		public static InvalidLambdaResponseExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600106B")]
			[Address(RVA = "0x112B448", Offset = "0x112B448", VA = "0x112B448")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001069")]
		[Address(RVA = "0x112B3E0", Offset = "0x112B3E0", VA = "0x112B3E0", Slot = "5")]
		public InvalidLambdaResponseException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600106A")]
		[Address(RVA = "0x1117574", Offset = "0x1117574", VA = "0x1117574", Slot = "4")]
		public InvalidLambdaResponseException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600106C")]
		[Address(RVA = "0x112B4AC", Offset = "0x112B4AC", VA = "0x112B4AC")]
		public InvalidLambdaResponseExceptionUnmarshaller()
		{
		}
	}
}
