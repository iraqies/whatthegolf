using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000046")]
	public class ConcurrentModificationExceptionUnmarshaller : IErrorResponseUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>, IUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		private static ConcurrentModificationExceptionUnmarshaller _instance;

		[Token(Token = "0x1700007E")]
		public static ConcurrentModificationExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x1192EAC", Offset = "0x1192EAC", VA = "0x1192EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1192D60", Offset = "0x1192D60", VA = "0x1192D60", Slot = "5")]
		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1192DC8", Offset = "0x1192DC8", VA = "0x1192DC8", Slot = "4")]
		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1192F10", Offset = "0x1192F10", VA = "0x1192F10")]
		public ConcurrentModificationExceptionUnmarshaller()
		{
		}
	}
}
