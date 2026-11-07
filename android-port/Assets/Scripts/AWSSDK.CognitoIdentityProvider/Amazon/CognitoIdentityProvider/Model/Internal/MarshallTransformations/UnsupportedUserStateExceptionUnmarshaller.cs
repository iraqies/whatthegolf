using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200026C")]
	public class UnsupportedUserStateExceptionUnmarshaller : IErrorResponseUnmarshaller<UnsupportedUserStateException, JsonUnmarshallerContext>, IUnmarshaller<UnsupportedUserStateException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x0")]
		private static UnsupportedUserStateExceptionUnmarshaller _instance;

		[Token(Token = "0x170003EF")]
		public static UnsupportedUserStateExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001260")]
			[Address(RVA = "0x115DBD4", Offset = "0x115DBD4", VA = "0x115DBD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600125E")]
		[Address(RVA = "0x115DA88", Offset = "0x115DA88", VA = "0x115DA88", Slot = "5")]
		public UnsupportedUserStateException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600125F")]
		[Address(RVA = "0x115DAF0", Offset = "0x115DAF0", VA = "0x115DAF0", Slot = "4")]
		public UnsupportedUserStateException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001261")]
		[Address(RVA = "0x115DC38", Offset = "0x115DC38", VA = "0x115DC38")]
		public UnsupportedUserStateExceptionUnmarshaller()
		{
		}
	}
}
