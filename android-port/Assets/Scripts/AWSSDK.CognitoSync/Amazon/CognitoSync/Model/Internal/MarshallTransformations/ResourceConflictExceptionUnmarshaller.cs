using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006C")]
	public class ResourceConflictExceptionUnmarshaller : IErrorResponseUnmarshaller<ResourceConflictException, JsonUnmarshallerContext>, IUnmarshaller<ResourceConflictException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceConflictExceptionUnmarshaller _instance;

		[Token(Token = "0x170000A2")]
		public static ResourceConflictExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x11A7150", Offset = "0x11A7150", VA = "0x11A7150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11A70E8", Offset = "0x11A70E8", VA = "0x11A70E8", Slot = "5")]
		public ResourceConflictException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1194D50", Offset = "0x1194D50", VA = "0x1194D50", Slot = "4")]
		public ResourceConflictException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x11A71B4", Offset = "0x11A71B4", VA = "0x11A71B4")]
		public ResourceConflictExceptionUnmarshaller()
		{
		}
	}
}
