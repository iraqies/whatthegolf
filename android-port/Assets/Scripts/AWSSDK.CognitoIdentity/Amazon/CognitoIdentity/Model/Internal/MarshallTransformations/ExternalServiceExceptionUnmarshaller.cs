using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000066")]
	public class ExternalServiceExceptionUnmarshaller : IErrorResponseUnmarshaller<ExternalServiceException, JsonUnmarshallerContext>, IUnmarshaller<ExternalServiceException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x0")]
		private static ExternalServiceExceptionUnmarshaller _instance;

		[Token(Token = "0x170000B5")]
		public static ExternalServiceExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x1084094", Offset = "0x1084094", VA = "0x1084094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1083F48", Offset = "0x1083F48", VA = "0x1083F48", Slot = "5")]
		public ExternalServiceException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1083FB0", Offset = "0x1083FB0", VA = "0x1083FB0", Slot = "4")]
		public ExternalServiceException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x10840F8", Offset = "0x10840F8", VA = "0x10840F8")]
		public ExternalServiceExceptionUnmarshaller()
		{
		}
	}
}
