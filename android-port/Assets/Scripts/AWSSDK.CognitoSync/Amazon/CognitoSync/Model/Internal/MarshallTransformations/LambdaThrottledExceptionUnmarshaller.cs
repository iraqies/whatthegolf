using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005D")]
	public class LambdaThrottledExceptionUnmarshaller : IErrorResponseUnmarshaller<LambdaThrottledException, JsonUnmarshallerContext>, IUnmarshaller<LambdaThrottledException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x0")]
		private static LambdaThrottledExceptionUnmarshaller _instance;

		[Token(Token = "0x17000095")]
		public static LambdaThrottledExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x119DED0", Offset = "0x119DED0", VA = "0x119DED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x119DD84", Offset = "0x119DD84", VA = "0x119DD84", Slot = "5")]
		public LambdaThrottledException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x119DDEC", Offset = "0x119DDEC", VA = "0x119DDEC", Slot = "4")]
		public LambdaThrottledException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x119DF34", Offset = "0x119DF34", VA = "0x119DF34")]
		public LambdaThrottledExceptionUnmarshaller()
		{
		}
	}
}
