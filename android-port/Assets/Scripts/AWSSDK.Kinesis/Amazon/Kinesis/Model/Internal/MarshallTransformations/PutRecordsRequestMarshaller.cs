using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x2000094")]
	public class PutRecordsRequestMarshaller : IMarshaller<IRequest, PutRecordsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x0")]
		private static PutRecordsRequestMarshaller _instance;

		[Token(Token = "0x170000D9")]
		public static PutRecordsRequestMarshaller Instance
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x12C1128", Offset = "0x12C1128", VA = "0x12C1128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x12C051C", Offset = "0x12C051C", VA = "0x12C051C", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x12C05B0", Offset = "0x12C05B0", VA = "0x12C05B0", Slot = "4")]
		public IRequest Marshall(PutRecordsRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x12C10C4", Offset = "0x12C10C4", VA = "0x12C10C4")]
		internal static PutRecordsRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x12C118C", Offset = "0x12C118C", VA = "0x12C118C")]
		public PutRecordsRequestMarshaller()
		{
		}
	}
}
