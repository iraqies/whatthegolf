using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000237")]
	public class PreconditionNotMetExceptionUnmarshaller : IErrorResponseUnmarshaller<PreconditionNotMetException, JsonUnmarshallerContext>, IUnmarshaller<PreconditionNotMetException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x0")]
		private static PreconditionNotMetExceptionUnmarshaller _instance;

		[Token(Token = "0x170003C5")]
		public static PreconditionNotMetExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001157")]
			[Address(RVA = "0x1140FAC", Offset = "0x1140FAC", VA = "0x1140FAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001155")]
		[Address(RVA = "0x1140E60", Offset = "0x1140E60", VA = "0x1140E60", Slot = "5")]
		public PreconditionNotMetException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001156")]
		[Address(RVA = "0x1140EC8", Offset = "0x1140EC8", VA = "0x1140EC8", Slot = "4")]
		public PreconditionNotMetException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001158")]
		[Address(RVA = "0x1141010", Offset = "0x1141010", VA = "0x1141010")]
		public PreconditionNotMetExceptionUnmarshaller()
		{
		}
	}
}
