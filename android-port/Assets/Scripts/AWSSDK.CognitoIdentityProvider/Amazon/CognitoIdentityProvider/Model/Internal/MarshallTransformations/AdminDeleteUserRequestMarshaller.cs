using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000166")]
	public class AdminDeleteUserRequestMarshaller : IMarshaller<IRequest, AdminDeleteUserRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x0")]
		private static AdminDeleteUserRequestMarshaller _instance;

		[Token(Token = "0x17000306")]
		public static AdminDeleteUserRequestMarshaller Instance
		{
			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x10A3574", Offset = "0x10A3574", VA = "0x10A3574")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x10A2B6C", Offset = "0x10A2B6C", VA = "0x10A2B6C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000CD5")]
		[Address(RVA = "0x10A2C00", Offset = "0x10A2C00", VA = "0x10A2C00", Slot = "4")]
		public IRequest Marshall(AdminDeleteUserRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x10A3510", Offset = "0x10A3510", VA = "0x10A3510")]
		internal static AdminDeleteUserRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x10A35D8", Offset = "0x10A35D8", VA = "0x10A35D8")]
		public AdminDeleteUserRequestMarshaller()
		{
		}
	}
}
