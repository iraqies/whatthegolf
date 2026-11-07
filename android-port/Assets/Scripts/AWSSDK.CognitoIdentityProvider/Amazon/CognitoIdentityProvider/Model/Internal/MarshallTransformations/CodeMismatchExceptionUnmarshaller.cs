using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001A1")]
	public class CodeMismatchExceptionUnmarshaller : IErrorResponseUnmarshaller<CodeMismatchException, JsonUnmarshallerContext>, IUnmarshaller<CodeMismatchException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x0")]
		private static CodeMismatchExceptionUnmarshaller _instance;

		[Token(Token = "0x1700033E")]
		public static CodeMismatchExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0x10E3838", Offset = "0x10E3838", VA = "0x10E3838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x10E36EC", Offset = "0x10E36EC", VA = "0x10E36EC", Slot = "5")]
		public CodeMismatchException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x10E3754", Offset = "0x10E3754", VA = "0x10E3754", Slot = "4")]
		public CodeMismatchException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x10E389C", Offset = "0x10E389C", VA = "0x10E389C")]
		public CodeMismatchExceptionUnmarshaller()
		{
		}
	}
}
