using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200022D")]
	public class NotAuthorizedExceptionUnmarshaller : IErrorResponseUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>, IUnmarshaller<NotAuthorizedException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x0")]
		private static NotAuthorizedExceptionUnmarshaller _instance;

		[Token(Token = "0x170003BF")]
		public static NotAuthorizedExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x113E1A0", Offset = "0x113E1A0", VA = "0x113E1A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600112B")]
		[Address(RVA = "0x113E138", Offset = "0x113E138", VA = "0x113E138", Slot = "5")]
		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600112C")]
		[Address(RVA = "0x1137B70", Offset = "0x1137B70", VA = "0x1137B70", Slot = "4")]
		public NotAuthorizedException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600112E")]
		[Address(RVA = "0x113E204", Offset = "0x113E204", VA = "0x113E204")]
		public NotAuthorizedExceptionUnmarshaller()
		{
		}
	}
}
