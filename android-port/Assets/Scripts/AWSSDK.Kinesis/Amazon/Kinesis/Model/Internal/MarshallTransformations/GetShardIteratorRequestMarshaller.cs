using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000079")]
	public class GetShardIteratorRequestMarshaller : IMarshaller<IRequest, GetShardIteratorRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x0")]
		private static GetShardIteratorRequestMarshaller _instance;

		[Token(Token = "0x170000BF")]
		public static GetShardIteratorRequestMarshaller Instance
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x12B3874", Offset = "0x12B3874", VA = "0x12B3874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x12B2C44", Offset = "0x12B2C44", VA = "0x12B2C44", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x12B2CD8", Offset = "0x12B2CD8", VA = "0x12B2CD8", Slot = "4")]
		public IRequest Marshall(GetShardIteratorRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x12B3810", Offset = "0x12B3810", VA = "0x12B3810")]
		internal static GetShardIteratorRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x12B38D8", Offset = "0x12B38D8", VA = "0x12B38D8")]
		public GetShardIteratorRequestMarshaller()
		{
		}
	}
}
