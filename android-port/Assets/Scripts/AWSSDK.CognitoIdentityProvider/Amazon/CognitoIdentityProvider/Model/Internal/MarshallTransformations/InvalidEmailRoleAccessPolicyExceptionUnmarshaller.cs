using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000208")]
	public class InvalidEmailRoleAccessPolicyExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidEmailRoleAccessPolicyException, JsonUnmarshallerContext>, IUnmarshaller<InvalidEmailRoleAccessPolicyException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidEmailRoleAccessPolicyExceptionUnmarshaller _instance;

		[Token(Token = "0x1700039D")]
		public static InvalidEmailRoleAccessPolicyExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001066")]
			[Address(RVA = "0x112B2EC", Offset = "0x112B2EC", VA = "0x112B2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001064")]
		[Address(RVA = "0x112B284", Offset = "0x112B284", VA = "0x112B284", Slot = "5")]
		public InvalidEmailRoleAccessPolicyException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001065")]
		[Address(RVA = "0x1117490", Offset = "0x1117490", VA = "0x1117490", Slot = "4")]
		public InvalidEmailRoleAccessPolicyException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001067")]
		[Address(RVA = "0x112B350", Offset = "0x112B350", VA = "0x112B350")]
		public InvalidEmailRoleAccessPolicyExceptionUnmarshaller()
		{
		}
	}
}
