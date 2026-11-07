using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005E")]
	public class LimitExceededExceptionUnmarshaller : IErrorResponseUnmarshaller<LimitExceededException, JsonUnmarshallerContext>, IUnmarshaller<LimitExceededException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x0")]
		private static LimitExceededExceptionUnmarshaller _instance;

		[Token(Token = "0x17000096")]
		public static LimitExceededExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x119E150", Offset = "0x119E150", VA = "0x119E150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x119E004", Offset = "0x119E004", VA = "0x119E004", Slot = "5")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x119E06C", Offset = "0x119E06C", VA = "0x119E06C", Slot = "4")]
		public LimitExceededException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x119E1B4", Offset = "0x119E1B4", VA = "0x119E1B4")]
		public LimitExceededExceptionUnmarshaller()
		{
		}
	}
}
