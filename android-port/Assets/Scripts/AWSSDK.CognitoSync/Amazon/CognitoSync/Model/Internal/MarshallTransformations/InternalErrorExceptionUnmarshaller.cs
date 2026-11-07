using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000059")]
	public class InternalErrorExceptionUnmarshaller : IErrorResponseUnmarshaller<InternalErrorException, JsonUnmarshallerContext>, IUnmarshaller<InternalErrorException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		private static InternalErrorExceptionUnmarshaller _instance;

		[Token(Token = "0x17000091")]
		public static InternalErrorExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x119D5B4", Offset = "0x119D5B4", VA = "0x119D5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x119D54C", Offset = "0x119D54C", VA = "0x119D54C", Slot = "5")]
		public InternalErrorException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1191960", Offset = "0x1191960", VA = "0x1191960", Slot = "4")]
		public InternalErrorException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x119D618", Offset = "0x119D618", VA = "0x119D618")]
		public InternalErrorExceptionUnmarshaller()
		{
		}
	}
}
