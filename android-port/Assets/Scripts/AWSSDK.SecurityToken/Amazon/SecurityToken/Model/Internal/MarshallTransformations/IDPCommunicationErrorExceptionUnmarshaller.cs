using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000046")]
	public class IDPCommunicationErrorExceptionUnmarshaller : IErrorResponseUnmarshaller<IDPCommunicationErrorException, XmlUnmarshallerContext>, IUnmarshaller<IDPCommunicationErrorException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x0")]
		private static IDPCommunicationErrorExceptionUnmarshaller _instance;

		[Token(Token = "0x17000067")]
		public static IDPCommunicationErrorExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x12E3AE0", Offset = "0x12E3AE0", VA = "0x12E3AE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x12E3A78", Offset = "0x12E3A78", VA = "0x12E3A78", Slot = "5")]
		public IDPCommunicationErrorException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x12DCDD4", Offset = "0x12DCDD4", VA = "0x12DCDD4", Slot = "4")]
		public IDPCommunicationErrorException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x12E3B44", Offset = "0x12E3B44", VA = "0x12E3B44")]
		public IDPCommunicationErrorExceptionUnmarshaller()
		{
		}
	}
}
