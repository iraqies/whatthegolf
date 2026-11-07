using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005A")]
	public class InvalidConfigurationExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidConfigurationException, JsonUnmarshallerContext>, IUnmarshaller<InvalidConfigurationException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidConfigurationExceptionUnmarshaller _instance;

		[Token(Token = "0x17000092")]
		public static InvalidConfigurationExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x119D834", Offset = "0x119D834", VA = "0x119D834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x119D6E8", Offset = "0x119D6E8", VA = "0x119D6E8", Slot = "5")]
		public InvalidConfigurationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x119D750", Offset = "0x119D750", VA = "0x119D750", Slot = "4")]
		public InvalidConfigurationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x119D898", Offset = "0x119D898", VA = "0x119D898")]
		public InvalidConfigurationExceptionUnmarshaller()
		{
		}
	}
}
