using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000083")]
	public class NotAuthorizedExceptionUnmarshaller : IErrorResponseUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>, IUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x0")]
		private static NotAuthorizedExceptionUnmarshaller _instance;

		[Token(Token = "0x170000D1")]
		public static NotAuthorizedExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x109629C", Offset = "0x109629C", VA = "0x109629C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1096234", Offset = "0x1096234", VA = "0x1096234", Slot = "5")]
		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x107C6CC", Offset = "0x107C6CC", VA = "0x107C6CC", Slot = "4")]
		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1096300", Offset = "0x1096300", VA = "0x1096300")]
		public NotAuthorizedExceptionUnmarshaller()
		{
		}
	}
}
