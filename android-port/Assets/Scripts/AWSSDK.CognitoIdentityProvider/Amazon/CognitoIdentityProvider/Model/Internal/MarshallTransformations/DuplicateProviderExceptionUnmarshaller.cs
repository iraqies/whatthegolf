using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001E1")]
	public class DuplicateProviderExceptionUnmarshaller : IErrorResponseUnmarshaller<DuplicateProviderException, JsonUnmarshallerContext>, IUnmarshaller<DuplicateProviderException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x0")]
		private static DuplicateProviderExceptionUnmarshaller _instance;

		[Token(Token = "0x17000378")]
		public static DuplicateProviderExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0x11103D0", Offset = "0x11103D0", VA = "0x11103D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x1110368", Offset = "0x1110368", VA = "0x1110368", Slot = "5")]
		public DuplicateProviderException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x10EECE4", Offset = "0x10EECE4", VA = "0x10EECE4", Slot = "4")]
		public DuplicateProviderException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000F8E")]
		[Address(RVA = "0x1110434", Offset = "0x1110434", VA = "0x1110434")]
		public DuplicateProviderExceptionUnmarshaller()
		{
		}
	}
}
