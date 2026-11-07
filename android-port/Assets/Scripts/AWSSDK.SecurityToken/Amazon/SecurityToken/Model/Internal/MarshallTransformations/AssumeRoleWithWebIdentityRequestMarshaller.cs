using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000037")]
	public class AssumeRoleWithWebIdentityRequestMarshaller : IMarshaller<IRequest, AssumeRoleWithWebIdentityRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x0")]
		private static AssumeRoleWithWebIdentityRequestMarshaller _instance;

		[Token(Token = "0x17000058")]
		public static AssumeRoleWithWebIdentityRequestMarshaller Instance
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x12DBB5C", Offset = "0x12DBB5C", VA = "0x12DBB5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x12DAC58", Offset = "0x12DAC58", VA = "0x12DAC58", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x12DACEC", Offset = "0x12DACEC", VA = "0x12DACEC", Slot = "4")]
		public IRequest Marshall(AssumeRoleWithWebIdentityRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x12DBAF8", Offset = "0x12DBAF8", VA = "0x12DBAF8")]
		internal static AssumeRoleWithWebIdentityRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x12DBBC0", Offset = "0x12DBBC0", VA = "0x12DBBC0")]
		public AssumeRoleWithWebIdentityRequestMarshaller()
		{
		}
	}
}
