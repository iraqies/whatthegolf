using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000229")]
	public class MFAMethodNotFoundExceptionUnmarshaller : IErrorResponseUnmarshaller<MFAMethodNotFoundException, JsonUnmarshallerContext>, IUnmarshaller<MFAMethodNotFoundException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x0")]
		private static MFAMethodNotFoundExceptionUnmarshaller _instance;

		[Token(Token = "0x170003BC")]
		public static MFAMethodNotFoundExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600111B")]
			[Address(RVA = "0x113CD64", Offset = "0x113CD64", VA = "0x113CD64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001119")]
		[Address(RVA = "0x113CC18", Offset = "0x113CC18", VA = "0x113CC18", Slot = "5")]
		public MFAMethodNotFoundException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600111A")]
		[Address(RVA = "0x113CC80", Offset = "0x113CC80", VA = "0x113CC80", Slot = "4")]
		public MFAMethodNotFoundException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600111C")]
		[Address(RVA = "0x113CDC8", Offset = "0x113CDC8", VA = "0x113CDC8")]
		public MFAMethodNotFoundExceptionUnmarshaller()
		{
		}
	}
}
