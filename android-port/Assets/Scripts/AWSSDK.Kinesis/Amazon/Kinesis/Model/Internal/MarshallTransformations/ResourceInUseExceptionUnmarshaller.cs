using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200009C")]
	public class ResourceInUseExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceInUseException, JsonUnmarshallerContext>, IUnmarshaller<ResourceInUseException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceInUseExceptionUnmarshaller _instance;

		[Token(Token = "0x170000E1")]
		public static ResourceInUseExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x12C5CCC", Offset = "0x12C5CCC", VA = "0x12C5CCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x12C5C64", Offset = "0x12C5C64", VA = "0x12C5C64", Slot = "5")]
		public ResourceInUseException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x12C5944", Offset = "0x12C5944", VA = "0x12C5944", Slot = "4")]
		public ResourceInUseException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x12C5D30", Offset = "0x12C5D30", VA = "0x12C5D30")]
		public ResourceInUseExceptionUnmarshaller()
		{
		}
	}
}
