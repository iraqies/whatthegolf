using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000064")]
	public class DeleteStreamRequestMarshaller : IMarshaller<IRequest, DeleteStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x0")]
		private static DeleteStreamRequestMarshaller _instance;

		[Token(Token = "0x170000AA")]
		public static DeleteStreamRequestMarshaller Instance
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x12A5F84", Offset = "0x12A5F84", VA = "0x12A5F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12A5534", Offset = "0x12A5534", VA = "0x12A5534", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x12A55C8", Offset = "0x12A55C8", VA = "0x12A55C8", Slot = "4")]
		public IRequest Marshall(DeleteStreamRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x12A5F20", Offset = "0x12A5F20", VA = "0x12A5F20")]
		internal static DeleteStreamRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x12A5FE8", Offset = "0x12A5FE8", VA = "0x12A5FE8")]
		public DeleteStreamRequestMarshaller()
		{
		}
	}
}
