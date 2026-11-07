using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000047")]
	public class IDPRejectedClaimExceptionUnmarshaller : IErrorResponseUnmarshaller<IDPRejectedClaimException, XmlUnmarshallerContext>, IUnmarshaller<IDPRejectedClaimException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x0")]
		private static IDPRejectedClaimExceptionUnmarshaller _instance;

		[Token(Token = "0x17000068")]
		public static IDPRejectedClaimExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x12E3C7C", Offset = "0x12E3C7C", VA = "0x12E3C7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x12E3C14", Offset = "0x12E3C14", VA = "0x12E3C14", Slot = "5")]
		public IDPRejectedClaimException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x12DA768", Offset = "0x12DA768", VA = "0x12DA768", Slot = "4")]
		public IDPRejectedClaimException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x12E3CE0", Offset = "0x12E3CE0", VA = "0x12E3CE0")]
		public IDPRejectedClaimExceptionUnmarshaller()
		{
		}
	}
}
