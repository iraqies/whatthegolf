using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x20001CC")]
	public class DeleteUserRequestMarshaller : IMarshaller<IRequest, DeleteUserRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteUserRequestMarshaller _instance;

		[Token(Token = "0x17000365")]
		public static DeleteUserRequestMarshaller Instance
		{
			[Token(Token = "0x6000F19")]
			[Address(RVA = "0x1103E74", Offset = "0x1103E74", VA = "0x1103E74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x11034D8", Offset = "0x11034D8", VA = "0x11034D8", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x110356C", Offset = "0x110356C", VA = "0x110356C", Slot = "4")]
		public IRequest Marshall(DeleteUserRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x1103E10", Offset = "0x1103E10", VA = "0x1103E10")]
		internal static DeleteUserRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000F1A")]
		[Address(RVA = "0x1103ED8", Offset = "0x1103ED8", VA = "0x1103ED8")]
		public DeleteUserRequestMarshaller()
		{
		}
	}
}
