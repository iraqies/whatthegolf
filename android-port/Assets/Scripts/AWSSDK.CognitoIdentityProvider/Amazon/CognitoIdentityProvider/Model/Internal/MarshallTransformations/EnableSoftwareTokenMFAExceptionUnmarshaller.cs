using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001E4")]
	public class EnableSoftwareTokenMFAExceptionUnmarshaller : IErrorResponseUnmarshaller<EnableSoftwareTokenMFAException, JsonUnmarshallerContext>, IUnmarshaller<EnableSoftwareTokenMFAException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x0")]
		private static EnableSoftwareTokenMFAExceptionUnmarshaller _instance;

		[Token(Token = "0x1700037A")]
		public static EnableSoftwareTokenMFAExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000F9A")]
			[Address(RVA = "0x111102C", Offset = "0x111102C", VA = "0x111102C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x1110EE0", Offset = "0x1110EE0", VA = "0x1110EE0", Slot = "5")]
		public EnableSoftwareTokenMFAException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x1110F48", Offset = "0x1110F48", VA = "0x1110F48", Slot = "4")]
		public EnableSoftwareTokenMFAException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x1111090", Offset = "0x1111090", VA = "0x1111090")]
		public EnableSoftwareTokenMFAExceptionUnmarshaller()
		{
		}
	}
}
