using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200020D")]
	public class InvalidSmsRoleAccessPolicyExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidSmsRoleAccessPolicyException, JsonUnmarshallerContext>, IUnmarshaller<InvalidSmsRoleAccessPolicyException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidSmsRoleAccessPolicyExceptionUnmarshaller _instance;

		[Token(Token = "0x170003A2")]
		public static InvalidSmsRoleAccessPolicyExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600107F")]
			[Address(RVA = "0x112BB80", Offset = "0x112BB80", VA = "0x112BB80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600107D")]
		[Address(RVA = "0x112BB18", Offset = "0x112BB18", VA = "0x112BB18", Slot = "5")]
		public InvalidSmsRoleAccessPolicyException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600107E")]
		[Address(RVA = "0x1117658", Offset = "0x1117658", VA = "0x1117658", Slot = "4")]
		public InvalidSmsRoleAccessPolicyException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001080")]
		[Address(RVA = "0x112BBE4", Offset = "0x112BBE4", VA = "0x112BBE4")]
		public InvalidSmsRoleAccessPolicyExceptionUnmarshaller()
		{
		}
	}
}
