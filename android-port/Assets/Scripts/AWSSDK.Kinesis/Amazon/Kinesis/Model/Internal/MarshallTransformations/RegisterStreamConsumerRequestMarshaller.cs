using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000098")]
	public class RegisterStreamConsumerRequestMarshaller : IMarshaller<IRequest, RegisterStreamConsumerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		private static RegisterStreamConsumerRequestMarshaller _instance;

		[Token(Token = "0x170000DD")]
		public static RegisterStreamConsumerRequestMarshaller Instance
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x12C3B68", Offset = "0x12C3B68", VA = "0x12C3B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x12C3160", Offset = "0x12C3160", VA = "0x12C3160", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x12C31F4", Offset = "0x12C31F4", VA = "0x12C31F4", Slot = "4")]
		public IRequest Marshall(RegisterStreamConsumerRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x12C3B04", Offset = "0x12C3B04", VA = "0x12C3B04")]
		internal static RegisterStreamConsumerRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x12C3BCC", Offset = "0x12C3BCC", VA = "0x12C3BCC")]
		public RegisterStreamConsumerRequestMarshaller()
		{
		}
	}
}
