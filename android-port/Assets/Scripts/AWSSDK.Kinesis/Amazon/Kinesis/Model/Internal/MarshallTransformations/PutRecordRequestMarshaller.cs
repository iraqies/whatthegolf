using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000091")]
	public class PutRecordRequestMarshaller : IMarshaller<IRequest, PutRecordRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x0")]
		private static PutRecordRequestMarshaller _instance;

		[Token(Token = "0x170000D7")]
		public static PutRecordRequestMarshaller Instance
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x12BF1C4", Offset = "0x12BF1C4", VA = "0x12BF1C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x12BE634", Offset = "0x12BE634", VA = "0x12BE634", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x12BE6C8", Offset = "0x12BE6C8", VA = "0x12BE6C8", Slot = "4")]
		public IRequest Marshall(PutRecordRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x12BF160", Offset = "0x12BF160", VA = "0x12BF160")]
		internal static PutRecordRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x12BF228", Offset = "0x12BF228", VA = "0x12BF228")]
		public PutRecordRequestMarshaller()
		{
		}
	}
}
