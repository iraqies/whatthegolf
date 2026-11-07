using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000065")]
	public class DeveloperUserAlreadyRegisteredExceptionUnmarshaller : IErrorResponseUnmarshaller<DeveloperUserAlreadyRegisteredException, JsonUnmarshallerContext>, IUnmarshaller<DeveloperUserAlreadyRegisteredException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		private static DeveloperUserAlreadyRegisteredExceptionUnmarshaller _instance;

		[Token(Token = "0x170000B4")]
		public static DeveloperUserAlreadyRegisteredExceptionUnmarshaller Instance
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1083AF8", Offset = "0x1083AF8", VA = "0x1083AF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x10839AC", Offset = "0x10839AC", VA = "0x10839AC", Slot = "5")]
		public DeveloperUserAlreadyRegisteredException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1083A14", Offset = "0x1083A14", VA = "0x1083A14", Slot = "4")]
		public DeveloperUserAlreadyRegisteredException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1083B5C", Offset = "0x1083B5C", VA = "0x1083B5C")]
		public DeveloperUserAlreadyRegisteredExceptionUnmarshaller()
		{
		}
	}
}
