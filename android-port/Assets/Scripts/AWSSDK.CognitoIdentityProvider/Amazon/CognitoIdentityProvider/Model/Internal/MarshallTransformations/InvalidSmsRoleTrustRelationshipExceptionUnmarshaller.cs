using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200020E")]
	public class InvalidSmsRoleTrustRelationshipExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidSmsRoleTrustRelationshipException, JsonUnmarshallerContext>, IUnmarshaller<InvalidSmsRoleTrustRelationshipException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidSmsRoleTrustRelationshipExceptionUnmarshaller _instance;

		[Token(Token = "0x170003A3")]
		public static InvalidSmsRoleTrustRelationshipExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001084")]
			[Address(RVA = "0x112BCDC", Offset = "0x112BCDC", VA = "0x112BCDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001082")]
		[Address(RVA = "0x112BC74", Offset = "0x112BC74", VA = "0x112BC74", Slot = "5")]
		public InvalidSmsRoleTrustRelationshipException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001083")]
		[Address(RVA = "0x111773C", Offset = "0x111773C", VA = "0x111773C", Slot = "4")]
		public InvalidSmsRoleTrustRelationshipException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001085")]
		[Address(RVA = "0x112BD40", Offset = "0x112BD40", VA = "0x112BD40")]
		public InvalidSmsRoleTrustRelationshipExceptionUnmarshaller()
		{
		}
	}
}
