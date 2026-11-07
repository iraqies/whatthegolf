using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006A")]
	public class DescribeStreamConsumerRequestMarshaller : IMarshaller<IRequest, DescribeStreamConsumerRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeStreamConsumerRequestMarshaller _instance;

		[Token(Token = "0x170000B0")]
		public static DescribeStreamConsumerRequestMarshaller Instance
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x12A9660", Offset = "0x12A9660", VA = "0x12A9660")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x12A8BEC", Offset = "0x12A8BEC", VA = "0x12A8BEC", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x12A8C80", Offset = "0x12A8C80", VA = "0x12A8C80", Slot = "4")]
		public IRequest Marshall(DescribeStreamConsumerRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x12A95FC", Offset = "0x12A95FC", VA = "0x12A95FC")]
		internal static DescribeStreamConsumerRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x12A96C4", Offset = "0x12A96C4", VA = "0x12A96C4")]
		public DescribeStreamConsumerRequestMarshaller()
		{
		}
	}
}
