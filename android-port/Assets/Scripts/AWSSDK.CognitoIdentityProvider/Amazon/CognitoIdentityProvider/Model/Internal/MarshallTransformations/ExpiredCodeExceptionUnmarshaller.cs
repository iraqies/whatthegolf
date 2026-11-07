using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001E8")]
	public class ExpiredCodeExceptionUnmarshaller : IErrorResponseUnmarshaller<ExpiredCodeException, JsonUnmarshallerContext>, IUnmarshaller<ExpiredCodeException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x0")]
		private static ExpiredCodeExceptionUnmarshaller _instance;

		[Token(Token = "0x1700037E")]
		public static ExpiredCodeExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x1113068", Offset = "0x1113068", VA = "0x1113068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x1112F1C", Offset = "0x1112F1C", VA = "0x1112F1C", Slot = "5")]
		public ExpiredCodeException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x1112F84", Offset = "0x1112F84", VA = "0x1112F84", Slot = "4")]
		public ExpiredCodeException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x11130CC", Offset = "0x11130CC", VA = "0x11130CC")]
		public ExpiredCodeExceptionUnmarshaller()
		{
		}
	}
}
