using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200020F")]
	public class InvalidUserPoolConfigurationExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidUserPoolConfigurationException, JsonUnmarshallerContext>, IUnmarshaller<InvalidUserPoolConfigurationException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidUserPoolConfigurationExceptionUnmarshaller _instance;

		[Token(Token = "0x170003A4")]
		public static InvalidUserPoolConfigurationExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001089")]
			[Address(RVA = "0x112BE38", Offset = "0x112BE38", VA = "0x112BE38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001087")]
		[Address(RVA = "0x112BDD0", Offset = "0x112BDD0", VA = "0x112BDD0", Slot = "5")]
		public InvalidUserPoolConfigurationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001088")]
		[Address(RVA = "0x11150C0", Offset = "0x11150C0", VA = "0x11150C0", Slot = "4")]
		public InvalidUserPoolConfigurationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600108A")]
		[Address(RVA = "0x112BE9C", Offset = "0x112BE9C", VA = "0x112BE9C")]
		public InvalidUserPoolConfigurationExceptionUnmarshaller()
		{
		}
	}
}
