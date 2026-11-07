using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000084")]
	public class ResourceConflictExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceConflictException, JsonUnmarshallerContext>, IUnmarshaller<ResourceConflictException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceConflictExceptionUnmarshaller _instance;

		[Token(Token = "0x170000D2")]
		public static ResourceConflictExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1096438", Offset = "0x1096438", VA = "0x1096438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x10963D0", Offset = "0x10963D0", VA = "0x10963D0", Slot = "5")]
		public ResourceConflictException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x107C7B0", Offset = "0x107C7B0", VA = "0x107C7B0", Slot = "4")]
		public ResourceConflictException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x109649C", Offset = "0x109649C", VA = "0x109649C")]
		public ResourceConflictExceptionUnmarshaller()
		{
		}
	}
}
