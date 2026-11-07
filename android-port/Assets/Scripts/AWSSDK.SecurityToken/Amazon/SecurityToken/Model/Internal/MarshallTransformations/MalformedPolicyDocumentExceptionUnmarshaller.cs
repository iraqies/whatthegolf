using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200004A")]
	public class MalformedPolicyDocumentExceptionUnmarshaller : IErrorResponseUnmarshaller<MalformedPolicyDocumentException, XmlUnmarshallerContext>, IUnmarshaller<MalformedPolicyDocumentException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x0")]
		private static MalformedPolicyDocumentExceptionUnmarshaller _instance;

		[Token(Token = "0x1700006B")]
		public static MalformedPolicyDocumentExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x12E4150", Offset = "0x12E4150", VA = "0x12E4150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x12E40E8", Offset = "0x12E40E8", VA = "0x12E40E8", Slot = "5")]
		public MalformedPolicyDocumentException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x12D7E84", Offset = "0x12D7E84", VA = "0x12D7E84", Slot = "4")]
		public MalformedPolicyDocumentException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x12E41B4", Offset = "0x12E41B4", VA = "0x12E41B4")]
		public MalformedPolicyDocumentExceptionUnmarshaller()
		{
		}
	}
}
