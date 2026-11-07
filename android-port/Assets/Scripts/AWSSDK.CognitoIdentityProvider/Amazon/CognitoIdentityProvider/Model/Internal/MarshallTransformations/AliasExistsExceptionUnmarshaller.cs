using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000192")]
	public class AliasExistsExceptionUnmarshaller : IErrorResponseUnmarshaller<AliasExistsException, JsonUnmarshallerContext>, IUnmarshaller<AliasExistsException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x0")]
		private static AliasExistsExceptionUnmarshaller _instance;

		[Token(Token = "0x17000332")]
		public static AliasExistsExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6000DDE")]
			[Address(RVA = "0x10C769C", Offset = "0x10C769C", VA = "0x10C769C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x10C7634", Offset = "0x10C7634", VA = "0x10C7634", Slot = "5")]
		public AliasExistsException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x10C57BC", Offset = "0x10C57BC", VA = "0x10C57BC", Slot = "4")]
		public AliasExistsException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x10C7700", Offset = "0x10C7700", VA = "0x10C7700")]
		public AliasExistsExceptionUnmarshaller()
		{
		}
	}
}
