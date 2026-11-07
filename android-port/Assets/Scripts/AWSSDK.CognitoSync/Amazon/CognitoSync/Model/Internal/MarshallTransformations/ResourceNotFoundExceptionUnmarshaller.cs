using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006D")]
	public class ResourceNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceNotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x170000A3")]
		public static ResourceNotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x11A72EC", Offset = "0x11A72EC", VA = "0x11A72EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x11A7284", Offset = "0x11A7284", VA = "0x11A7284", Slot = "5")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1191C0C", Offset = "0x1191C0C", VA = "0x1191C0C", Slot = "4")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x11A7350", Offset = "0x11A7350", VA = "0x11A7350")]
		public ResourceNotFoundExceptionUnmarshaller()
		{
		}
	}
}
