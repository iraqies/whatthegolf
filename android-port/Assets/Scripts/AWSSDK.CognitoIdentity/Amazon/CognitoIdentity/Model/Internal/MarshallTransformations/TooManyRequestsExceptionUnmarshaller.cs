using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200008E")]
	public class TooManyRequestsExceptionUnmarshaller : IErrorResponseUnmarshaller<TooManyRequestsException, JsonUnmarshallerContext>, IUnmarshaller<TooManyRequestsException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x0")]
		private static TooManyRequestsExceptionUnmarshaller _instance;

		[Token(Token = "0x170000DA")]
		public static TooManyRequestsExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1181A7C", Offset = "0x1181A7C", VA = "0x1181A7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x1181A14", Offset = "0x1181A14", VA = "0x1181A14", Slot = "5")]
		public TooManyRequestsException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x118018C", Offset = "0x118018C", VA = "0x118018C", Slot = "4")]
		public TooManyRequestsException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1181AE0", Offset = "0x1181AE0", VA = "0x1181AE0")]
		public TooManyRequestsExceptionUnmarshaller()
		{
		}
	}
}
