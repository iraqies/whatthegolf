using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200006C")]
	public class DescribeStreamRequestMarshaller : IMarshaller<IRequest, DescribeStreamRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x0")]
		private static DescribeStreamRequestMarshaller _instance;

		[Token(Token = "0x170000B2")]
		public static DescribeStreamRequestMarshaller Instance
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x12AAB70", Offset = "0x12AAB70", VA = "0x12AAB70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x12AA0B4", Offset = "0x12AA0B4", VA = "0x12AA0B4", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x12AA148", Offset = "0x12AA148", VA = "0x12AA148", Slot = "4")]
		public IRequest Marshall(DescribeStreamRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x12AAB0C", Offset = "0x12AAB0C", VA = "0x12AAB0C")]
		internal static DescribeStreamRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x12AABD4", Offset = "0x12AABD4", VA = "0x12AABD4")]
		public DescribeStreamRequestMarshaller()
		{
		}
	}
}
