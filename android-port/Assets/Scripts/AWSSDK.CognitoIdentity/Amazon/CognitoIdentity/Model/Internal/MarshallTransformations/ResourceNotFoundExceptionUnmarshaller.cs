using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000085")]
	public class ResourceNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceNotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x170000D3")]
		public static ResourceNotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x10965D4", Offset = "0x10965D4", VA = "0x10965D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x109656C", Offset = "0x109656C", VA = "0x109656C", Slot = "5")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x107F900", Offset = "0x107F900", VA = "0x107F900", Slot = "4")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1096638", Offset = "0x1096638", VA = "0x1096638")]
		public ResourceNotFoundExceptionUnmarshaller()
		{
		}
	}
}
