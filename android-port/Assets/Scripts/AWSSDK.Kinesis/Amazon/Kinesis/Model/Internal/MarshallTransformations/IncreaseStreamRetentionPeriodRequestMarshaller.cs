using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
	[Token(Token = "0x200007C")]
	public class IncreaseStreamRetentionPeriodRequestMarshaller : IMarshaller<IRequest, IncreaseStreamRetentionPeriodRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
	{
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x0")]
		private static IncreaseStreamRetentionPeriodRequestMarshaller _instance;

		[Token(Token = "0x170000C2")]
		public static IncreaseStreamRetentionPeriodRequestMarshaller Instance
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x12B501C", Offset = "0x12B501C", VA = "0x12B501C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x12B45CC", Offset = "0x12B45CC", VA = "0x12B45CC", Slot = "5")]
		public IRequest Marshall(AmazonWebServiceRequest input)
		{
			return null;
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x12B4660", Offset = "0x12B4660", VA = "0x12B4660", Slot = "4")]
		public IRequest Marshall(IncreaseStreamRetentionPeriodRequest publicRequest)
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x12B4FB8", Offset = "0x12B4FB8", VA = "0x12B4FB8")]
		internal static IncreaseStreamRetentionPeriodRequestMarshaller GetInstance()
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x12B5080", Offset = "0x12B5080", VA = "0x12B5080")]
		public IncreaseStreamRetentionPeriodRequestMarshaller()
		{
		}
	}
}
