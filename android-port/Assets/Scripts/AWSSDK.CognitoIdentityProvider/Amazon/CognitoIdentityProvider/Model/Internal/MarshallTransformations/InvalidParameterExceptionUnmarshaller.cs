using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200020B")]
	public class InvalidParameterExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidParameterException, JsonUnmarshallerContext>, IUnmarshaller<InvalidParameterException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidParameterExceptionUnmarshaller _instance;

		[Token(Token = "0x170003A0")]
		public static InvalidParameterExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001075")]
			[Address(RVA = "0x112B7E4", Offset = "0x112B7E4", VA = "0x112B7E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001073")]
		[Address(RVA = "0x112B77C", Offset = "0x112B77C", VA = "0x112B77C", Slot = "5")]
		public InvalidParameterException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001074")]
		[Address(RVA = "0x1114FDC", Offset = "0x1114FDC", VA = "0x1114FDC", Slot = "4")]
		public InvalidParameterException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001076")]
		[Address(RVA = "0x112B848", Offset = "0x112B848", VA = "0x112B848")]
		public InvalidParameterExceptionUnmarshaller()
		{
		}
	}
}
