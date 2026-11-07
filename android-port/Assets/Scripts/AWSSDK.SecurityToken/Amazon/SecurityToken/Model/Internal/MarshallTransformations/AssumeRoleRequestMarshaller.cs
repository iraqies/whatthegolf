using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000033")]
	public class AssumeRoleRequestMarshaller : IMarshaller<IRequest, AssumeRoleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		private static AssumeRoleRequestMarshaller _instance;

		[Token(Token = "0x17000054")]
		public static AssumeRoleRequestMarshaller Instance
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x12D6AB0", Offset = "0x12D6AB0", VA = "0x12D6AB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x12D5310", Offset = "0x12D5310", VA = "0x12D5310", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x12D53A4", Offset = "0x12D53A4", VA = "0x12D53A4", Slot = "4")]
		public IRequest Marshall(AssumeRoleRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x12D6A4C", Offset = "0x12D6A4C", VA = "0x12D6A4C")]
		internal static AssumeRoleRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x12D6B14", Offset = "0x12D6B14", VA = "0x12D6B14")]
		public AssumeRoleRequestMarshaller()
		{
		}
	}
}
