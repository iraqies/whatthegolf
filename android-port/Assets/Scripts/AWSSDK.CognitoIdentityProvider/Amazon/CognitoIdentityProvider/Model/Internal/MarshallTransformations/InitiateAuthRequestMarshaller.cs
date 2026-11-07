using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000205")]
	public class InitiateAuthRequestMarshaller : IMarshaller<IRequest, InitiateAuthRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x0")]
		private static InitiateAuthRequestMarshaller _instance;

		[Token(Token = "0x1700039A")]
		public static InitiateAuthRequestMarshaller Instance
		{
			[Token(Token = "0x6001056")]
			[Address(RVA = "0x1129A30", Offset = "0x1129A30", VA = "0x1129A30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001053")]
		[Address(RVA = "0x11289B4", Offset = "0x11289B4", VA = "0x11289B4", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6001054")]
		[Address(RVA = "0x1128A48", Offset = "0x1128A48", VA = "0x1128A48", Slot = "4")]
		public IRequest Marshall(InitiateAuthRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6001055")]
		[Address(RVA = "0x11299CC", Offset = "0x11299CC", VA = "0x11299CC")]
		internal static InitiateAuthRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6001057")]
		[Address(RVA = "0x1129A94", Offset = "0x1129A94", VA = "0x1129A94")]
		public InitiateAuthRequestMarshaller()
		{
		}
	}
}
