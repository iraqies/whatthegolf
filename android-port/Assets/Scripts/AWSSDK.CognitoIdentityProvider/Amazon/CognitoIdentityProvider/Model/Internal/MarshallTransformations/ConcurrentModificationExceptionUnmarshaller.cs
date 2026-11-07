using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001A6")]
	public class ConcurrentModificationExceptionUnmarshaller : IErrorResponseUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>, IUnmarshaller<ConcurrentModificationException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x0")]
		private static ConcurrentModificationExceptionUnmarshaller _instance;

		[Token(Token = "0x17000341")]
		public static ConcurrentModificationExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x10E4AF8", Offset = "0x10E4AF8", VA = "0x10E4AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x10E49AC", Offset = "0x10E49AC", VA = "0x10E49AC", Slot = "5")]
		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x10E4A14", Offset = "0x10E4A14", VA = "0x10E4A14", Slot = "4")]
		public ConcurrentModificationException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x10E4B5C", Offset = "0x10E4B5C", VA = "0x10E4B5C")]
		public ConcurrentModificationExceptionUnmarshaller()
		{
		}
	}
}
