using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200028A")]
	public class UserPoolAddOnNotEnabledExceptionUnmarshaller : IErrorResponseUnmarshaller<UserPoolAddOnNotEnabledException, JsonUnmarshallerContext>, IUnmarshaller<UserPoolAddOnNotEnabledException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x0")]
		private static UserPoolAddOnNotEnabledExceptionUnmarshaller _instance;

		[Token(Token = "0x1700040B")]
		public static UserPoolAddOnNotEnabledExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001306")]
			[Address(RVA = "0x11735D8", Offset = "0x11735D8", VA = "0x11735D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001304")]
		[Address(RVA = "0x1173570", Offset = "0x1173570", VA = "0x1173570", Slot = "5")]
		public UserPoolAddOnNotEnabledException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001305")]
		[Address(RVA = "0x1160A38", Offset = "0x1160A38", VA = "0x1160A38", Slot = "4")]
		public UserPoolAddOnNotEnabledException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001307")]
		[Address(RVA = "0x117363C", Offset = "0x117363C", VA = "0x117363C")]
		public UserPoolAddOnNotEnabledExceptionUnmarshaller()
		{
		}
	}
}
