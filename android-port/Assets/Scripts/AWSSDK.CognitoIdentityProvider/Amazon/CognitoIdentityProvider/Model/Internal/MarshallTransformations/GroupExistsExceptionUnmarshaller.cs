using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000201")]
	public class GroupExistsExceptionUnmarshaller : IErrorResponseUnmarshaller<GroupExistsException, JsonUnmarshallerContext>, IUnmarshaller<GroupExistsException, JsonUnmarshallerContext>
	{
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0x0")]
		private static GroupExistsExceptionUnmarshaller _instance;

		[Token(Token = "0x17000397")]
		public static GroupExistsExceptionUnmarshaller Instance
		{
			[Token(Token = "0x6001043")]
			[Address(RVA = "0x1127578", Offset = "0x1127578", VA = "0x1127578")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001041")]
		[Address(RVA = "0x112742C", Offset = "0x112742C", VA = "0x112742C", Slot = "5")]
		public GroupExistsException Unmarshall(JsonUnmarshallerContext context)
		{
			return null;
		}

		[Token(Token = "0x6001042")]
		[Address(RVA = "0x1127494", Offset = "0x1127494", VA = "0x1127494", Slot = "4")]
		public GroupExistsException Unmarshall(JsonUnmarshallerContext context, ErrorResponse errorResponse)
		{
			return null;
		}

		[Token(Token = "0x6001044")]
		[Address(RVA = "0x11275DC", Offset = "0x11275DC", VA = "0x11275DC")]
		public GroupExistsExceptionUnmarshaller()
		{
		}
	}
}
