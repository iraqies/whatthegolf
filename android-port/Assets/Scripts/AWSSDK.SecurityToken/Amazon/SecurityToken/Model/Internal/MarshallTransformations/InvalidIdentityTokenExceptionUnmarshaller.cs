using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000049")]
	public class InvalidIdentityTokenExceptionUnmarshaller : IErrorResponseUnmarshaller<InvalidIdentityTokenException, XmlUnmarshallerContext>, IUnmarshaller<InvalidIdentityTokenException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x0")]
		private static InvalidIdentityTokenExceptionUnmarshaller _instance;

		[Token(Token = "0x1700006A")]
		public static InvalidIdentityTokenExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x12E3FB4", Offset = "0x12E3FB4", VA = "0x12E3FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x12E3F4C", Offset = "0x12E3F4C", VA = "0x12E3F4C", Slot = "5")]
		public InvalidIdentityTokenException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x12DA884", Offset = "0x12DA884", VA = "0x12DA884", Slot = "4")]
		public InvalidIdentityTokenException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x12E4018", Offset = "0x12E4018", VA = "0x12E4018")]
		public InvalidIdentityTokenExceptionUnmarshaller()
		{
		}
	}
}
