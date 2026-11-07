using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000050")]
	public class DuplicateRequestExceptionUnmarshaller : IErrorResponseUnmarshaller<DuplicateRequestException, JsonUnmarshallerContext>, IUnmarshaller<DuplicateRequestException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x0")]
		private static DuplicateRequestExceptionUnmarshaller _instance;

		[Token(Token = "0x17000088")]
		public static DuplicateRequestExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x1198EA0", Offset = "0x1198EA0", VA = "0x1198EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1198E38", Offset = "0x1198E38", VA = "0x1198E38", Slot = "5")]
		public DuplicateRequestException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x119187C", Offset = "0x119187C", VA = "0x119187C", Slot = "4")]
		public DuplicateRequestException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1198F04", Offset = "0x1198F04", VA = "0x1198F04")]
		public DuplicateRequestExceptionUnmarshaller()
		{
		}
	}
}
