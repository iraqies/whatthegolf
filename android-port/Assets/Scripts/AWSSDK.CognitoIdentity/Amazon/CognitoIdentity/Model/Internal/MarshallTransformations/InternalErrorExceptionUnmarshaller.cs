using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000073")]
	public class InternalErrorExceptionUnmarshaller : IErrorResponseUnmarshaller<InternalErrorException, JsonUnmarshallerContext>, IUnmarshaller<InternalErrorException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x0")]
		private static InternalErrorExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C2")]
		public static InternalErrorExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x108D37C", Offset = "0x108D37C", VA = "0x108D37C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x108D314", Offset = "0x108D314", VA = "0x108D314", Slot = "5")]
		public InternalErrorException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x107C420", Offset = "0x107C420", VA = "0x107C420", Slot = "4")]
		public InternalErrorException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x108D3E0", Offset = "0x108D3E0", VA = "0x108D3E0")]
		public InternalErrorExceptionUnmarshaller()
		{
		}
	}
}
