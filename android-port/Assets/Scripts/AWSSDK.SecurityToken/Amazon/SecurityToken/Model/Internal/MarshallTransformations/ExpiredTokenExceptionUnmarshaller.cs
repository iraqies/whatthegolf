using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200003C")]
	public class ExpiredTokenExceptionUnmarshaller : IErrorResponseUnmarshaller<ExpiredTokenException, XmlUnmarshallerContext>, IUnmarshaller<ExpiredTokenException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x0")]
		private static ExpiredTokenExceptionUnmarshaller _instance;

		[Token(Token = "0x1700005D")]
		public static ExpiredTokenExceptionUnmarshaller Instance
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x12DE568", Offset = "0x12DE568", VA = "0x12DE568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x12DE500", Offset = "0x12DE500", VA = "0x12DE500", Slot = "5")]
		public ExpiredTokenException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x12DA64C", Offset = "0x12DA64C", VA = "0x12DA64C", Slot = "4")]
		public ExpiredTokenException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x12DE5CC", Offset = "0x12DE5CC", VA = "0x12DE5CC")]
		public ExpiredTokenExceptionUnmarshaller()
		{
		}
	}
}
