using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001A0")]
	public class CodeDeliveryFailureExceptionUnmarshaller : IErrorResponseUnmarshaller<CodeDeliveryFailureException, JsonUnmarshallerContext>, IUnmarshaller<CodeDeliveryFailureException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x0")]
		private static CodeDeliveryFailureExceptionUnmarshaller _instance;

		[Token(Token = "0x1700033D")]
		public static CodeDeliveryFailureExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x10E35B8", Offset = "0x10E35B8", VA = "0x10E35B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x10E346C", Offset = "0x10E346C", VA = "0x10E346C", Slot = "5")]
		public CodeDeliveryFailureException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x10E34D4", Offset = "0x10E34D4", VA = "0x10E34D4", Slot = "4")]
		public CodeDeliveryFailureException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x10E361C", Offset = "0x10E361C", VA = "0x10E361C")]
		public CodeDeliveryFailureExceptionUnmarshaller()
		{
		}
	}
}
