using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000268")]
	public class TooManyRequestsExceptionUnmarshaller : IErrorResponseUnmarshaller<TooManyRequestsException, JsonUnmarshallerContext>, IUnmarshaller<TooManyRequestsException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x0")]
		private static TooManyRequestsExceptionUnmarshaller _instance;

		[Token(Token = "0x170003EB")]
		public static TooManyRequestsExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600124C")]
			[Address(RVA = "0x115CB7C", Offset = "0x115CB7C", VA = "0x115CB7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600124A")]
		[Address(RVA = "0x115CB14", Offset = "0x115CB14", VA = "0x115CB14", Slot = "5")]
		public TooManyRequestsException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600124B")]
		[Address(RVA = "0x115AB68", Offset = "0x115AB68", VA = "0x115AB68", Slot = "4")]
		public TooManyRequestsException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600124D")]
		[Address(RVA = "0x115CBE0", Offset = "0x115CBE0", VA = "0x115CBE0")]
		public TooManyRequestsExceptionUnmarshaller()
		{
		}
	}
}
