using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000074")]
	public class InvalidIdentityPoolConfigurationExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidIdentityPoolConfigurationException, JsonUnmarshallerContext>, IUnmarshaller<InvalidIdentityPoolConfigurationException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidIdentityPoolConfigurationExceptionUnmarshaller _instance;

		[Token(Token = "0x170000C3")]
		public static InvalidIdentityPoolConfigurationExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x108D518", Offset = "0x108D518", VA = "0x108D518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x108D4B0", Offset = "0x108D4B0", VA = "0x108D4B0", Slot = "5")]
		public InvalidIdentityPoolConfigurationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1085B08", Offset = "0x1085B08", VA = "0x1085B08", Slot = "4")]
		public InvalidIdentityPoolConfigurationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x108D57C", Offset = "0x108D57C", VA = "0x108D57C")]
		public InvalidIdentityPoolConfigurationExceptionUnmarshaller()
		{
		}
	}
}
