using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200004B")]
	public class PackedPolicyTooLargeExceptionUnmarshaller : IErrorResponseUnmarshaller<PackedPolicyTooLargeException, XmlUnmarshallerContext>, IUnmarshaller<PackedPolicyTooLargeException, XmlUnmarshallerContext>
	{
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x0")]
		private static PackedPolicyTooLargeExceptionUnmarshaller _instance;

		[Token(Token = "0x1700006C")]
		public static PackedPolicyTooLargeExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x12E42EC", Offset = "0x12E42EC", VA = "0x12E42EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x12E4284", Offset = "0x12E4284", VA = "0x12E4284", Slot = "5")]
		public PackedPolicyTooLargeException Unmarshall(XmlUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x12D7FA0", Offset = "0x12D7FA0", VA = "0x12D7FA0", Slot = "4")]
		public PackedPolicyTooLargeException Unmarshall(XmlUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x12E4350", Offset = "0x12E4350", VA = "0x12E4350")]
		public PackedPolicyTooLargeExceptionUnmarshaller()
		{
		}
	}
}
