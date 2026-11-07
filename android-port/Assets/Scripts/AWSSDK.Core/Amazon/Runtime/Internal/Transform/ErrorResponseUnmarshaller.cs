using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200020F")]
	public class ErrorResponseUnmarshaller : IUnmarshaller<ErrorResponse, XmlUnmarshallerContext>
	{
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x0")]
		private static ErrorResponseUnmarshaller instance;

		[Token(Token = "0x6001004")]
		[Address(RVA = "0x120157C", Offset = "0x120157C", VA = "0x120157C", Slot = "4")]
		public ErrorResponse Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001005")]
		[Address(RVA = "0x12016E0", Offset = "0x12016E0", VA = "0x12016E0")]
		private static void PopulateErrorResponseFromXmlIfPossible(XmlUnmarshallerContext context, ErrorResponse response)
		{
		}

		[Token(Token = "0x6001006")]
		[Address(RVA = "0x1201A8C", Offset = "0x1201A8C", VA = "0x1201A8C")]
		private static bool TryReadContext(XmlUnmarshallerContext context)
		{
			return default;
		}

		[Token(Token = "0x6001007")]
		[Address(RVA = "0x1201B38", Offset = "0x1201B38", VA = "0x1201B38")]
		public static ErrorResponseUnmarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001008")]
		[Address(RVA = "0x1201BB0", Offset = "0x1201BB0", VA = "0x1201BB0")]
		public ErrorResponseUnmarshaller()
		{
		}
	}
}
