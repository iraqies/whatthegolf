using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200023E")]
	public class ResourceNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceNotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x170003CA")]
		public static ResourceNotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001178")]
			[Address(RVA = "0x1144BB8", Offset = "0x1144BB8", VA = "0x1144BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001176")]
		[Address(RVA = "0x1144B50", Offset = "0x1144B50", VA = "0x1144B50", Slot = "5")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001177")]
		[Address(RVA = "0x1137C54", Offset = "0x1137C54", VA = "0x1137C54", Slot = "4")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001179")]
		[Address(RVA = "0x1144C1C", Offset = "0x1144C1C", VA = "0x1144C1C")]
		public ResourceNotFoundExceptionUnmarshaller()
		{
		}
	}
}
