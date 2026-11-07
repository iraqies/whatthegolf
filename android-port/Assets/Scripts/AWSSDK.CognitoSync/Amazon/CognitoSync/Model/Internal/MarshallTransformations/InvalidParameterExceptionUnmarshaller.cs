using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200005C")]
	public class InvalidParameterExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidParameterException, JsonUnmarshallerContext>, IUnmarshaller<InvalidParameterException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidParameterExceptionUnmarshaller _instance;

		[Token(Token = "0x17000094")]
		public static InvalidParameterExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x119DC50", Offset = "0x119DC50", VA = "0x119DC50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x119DBE8", Offset = "0x119DBE8", VA = "0x119DBE8", Slot = "5")]
		public InvalidParameterException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1191A44", Offset = "0x1191A44", VA = "0x1191A44", Slot = "4")]
		public InvalidParameterException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x119DCB4", Offset = "0x119DCB4", VA = "0x119DCB4")]
		public InvalidParameterExceptionUnmarshaller()
		{
		}
	}
}
