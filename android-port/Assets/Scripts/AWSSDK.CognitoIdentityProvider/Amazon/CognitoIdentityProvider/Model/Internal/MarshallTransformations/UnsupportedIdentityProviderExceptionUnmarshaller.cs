using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200026B")]
	public class UnsupportedIdentityProviderExceptionUnmarshaller : IErrorResponseUnmarshaller<UnsupportedIdentityProviderException, JsonUnmarshallerContext>, IUnmarshaller<UnsupportedIdentityProviderException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x0")]
		private static UnsupportedIdentityProviderExceptionUnmarshaller _instance;

		[Token(Token = "0x170003EE")]
		public static UnsupportedIdentityProviderExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600125B")]
			[Address(RVA = "0x115D994", Offset = "0x115D994", VA = "0x115D994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001259")]
		[Address(RVA = "0x115D848", Offset = "0x115D848", VA = "0x115D848", Slot = "5")]
		public UnsupportedIdentityProviderException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600125A")]
		[Address(RVA = "0x115D8B0", Offset = "0x115D8B0", VA = "0x115D8B0", Slot = "4")]
		public UnsupportedIdentityProviderException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600125C")]
		[Address(RVA = "0x115D9F8", Offset = "0x115D9F8", VA = "0x115D9F8")]
		public UnsupportedIdentityProviderExceptionUnmarshaller()
		{
		}
	}
}
