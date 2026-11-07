using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000075")]
	public class InvalidParameterExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidParameterException, JsonUnmarshallerContext>, IUnmarshaller<InvalidParameterException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidParameterExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C4")]
		public static InvalidParameterExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x108D6B4", Offset = "0x108D6B4", VA = "0x108D6B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x108D64C", Offset = "0x108D64C", VA = "0x108D64C", Slot = "5")]
		public InvalidParameterException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x107C504", Offset = "0x107C504", VA = "0x107C504", Slot = "4")]
		public InvalidParameterException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x108D718", Offset = "0x108D718", VA = "0x108D718")]
		public InvalidParameterExceptionUnmarshaller()
		{
		}
	}
}
