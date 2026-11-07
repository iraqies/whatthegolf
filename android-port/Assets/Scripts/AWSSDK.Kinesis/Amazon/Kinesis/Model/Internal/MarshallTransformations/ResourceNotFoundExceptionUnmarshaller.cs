using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200009D")]
	public class ResourceNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<ResourceNotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceNotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x170000E2")]
		public static ResourceNotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x12C5E28", Offset = "0x12C5E28", VA = "0x12C5E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x12C5DC0", Offset = "0x12C5DC0", VA = "0x12C5DC0", Slot = "5")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x12C5A28", Offset = "0x12C5A28", VA = "0x12C5A28", Slot = "4")]
		public ResourceNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x12C5E8C", Offset = "0x12C5E8C", VA = "0x12C5E8C")]
		public ResourceNotFoundExceptionUnmarshaller()
		{
		}
	}
}
